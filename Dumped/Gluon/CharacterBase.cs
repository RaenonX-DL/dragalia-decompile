using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri;
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

namespace Gluon
{
	public class CharacterBase : RenderObjectBase
	{
		public enum ModelType
		{
			Normal,
			Simple
		}

		public enum HandID
		{
			LeftHand,
			RightHand
		}

		public enum AttachWeaponHandType
		{
			Origin,
			Right,
			Left
		}

		public enum ActionSignal
		{
			Input,
			SuperArmor,
			Invincible,
			AttachWeaponLeft,
			AttachWeaponRight,
			NonUse01,
			NonUse02,
			PutUpEffect,
			Show,
			Hide,
			NoReaction,
			SuperArmorLv1,
			SuperArmorLv2,
			SuperArmorLv3,
			Omit01,
			AdditionalInput,
			InvincibleLv1,
			InvincibleLv2,
			InvincibleLv3,
			SpecialDead,
			NoTarget,
			SuperArmorLv4,
			DisableCheckOutside,
			DisableExternalVelocity,
			ShowWeapon,
			HideWeapon,
			DamageCounter,
			CancelInvincible,
			ChangePartsMesh,
			EnableAction,
			RecordHitTarget,
			GuardCounter,
			GuardReactionInCharge,
			HideStockBullet,
			Stop1,
			HitCount,
			ActionCriticalStatus,
			RecoveryOnDamage,
			RESERVE_04,
			RESERVE_05,
			RESERVE_06,
			RESERVE_07,
			RESERVE_08,
			RESERVE_09,
			RESERVE_10
		}

		public static class NodeName
		{
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
			Player,
			Enemy,
			AllyPlayer,
			EnemyPlayer,
			HostEnemy,
			GuestEnemy,
			Other
		}

		public enum HitProduction
		{
			None = 0,
			HitValue = 1,
			HitEffect = 2,
			HitFlash = 4,
			HitFont = 8,
			HpGage = 0x10,
			HitSE = 0x20,
			All = 47
		}

		public enum DamageReaction
		{
			Normal,
			BlastUp,
			BlastHalf,
			BlastDown,
			BlastInherit,
			NoReaction,
			SuperArmor,
			Invincible,
			SuperArmorBreak,
			Throw,
			Freeze
		}

		private enum ShadowCastMethod
		{
			TexturedQuad,
			TextureProjection,
			MaxNum
		}

		private struct ReserveAction
		{
			public int actionId;

			public CommonObjectStatus target;

			public int skill;

			public CharacterBase murderer;

			public Action<ActionBase> actionFinishCallback;

			public bool resistClearExcludeDead;

			public bool viaAttackState;
		}

		private struct StackAction
		{
			public int actionId;

			public Vector3 parentBulletPosition;
		}

		private struct ResponseEventAction
		{
			public EventActionData.EventType type;

			public UnityEvent responseEvent;
		}

		private struct ReservableActionInfo
		{
			public ActionSignal type;

			public int actionId;
		}

		public struct AbnormalStatusProbabilityResult
		{
			public float total;

			public static readonly AbnormalStatusProbabilityResult Zero;
		}

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

		private Vector3 _lastHitPosition;

		private Quaternion _lastHitRotation;

		public List<Vector3> registeredPositionList;

		private bool _enableSetSp;

		protected int _thisLayer;

		private int[] prevSp;

		public string additionAttackEffect;

		public FollowerController followerController;

		protected ControlDeath _ctrlDeath;

		public OnCollidedEffectResult designatedHitResult;

		private bool isInvalidBlastForNoDamage;

		public readonly int AdditionalActionEffectBeginTrigger;

		public int AdditionalInputlastKickedTrigger;

		[SerializeField]
		private bool _isSpecialHate;

		private CharacterStates _state;

		public StateMachine<CharacterBase> stateMachine;

		private short bulletIndex;

		private BulletManager _bulletManager;

		protected float _moveSpeed;

		protected float _dashSpeedRatio;

		protected AttackHit attackHit;

		private CharacterDamageIntermediate _damageIntermediate;

		public AudioPlayback skillVoicePlayBack;

		[SerializeField]
		public float _rotateSpeed;

		private float _speedRate;

		public CharacterHitStopCaster hitStopCaster;

		public CharacterHitStopPlayer hitStopPlayer;

		[SerializeField]
		protected float _scaleRate;

		protected float _prevScaleRate;

		private float _baseRadius;

		private float _baseHeight;

		public EnemyCylinderCollider enemyCylinderCollider;

		private AnimatorCullingMode _defaultAnimatorCullMode;

		protected CharacterExternalMove externalMove;

		protected float _localTimeScale;

		private Dictionary<int, ActionContainer> dictAction;

		protected List<ActionBase> _actions;

		private Action<int> onActionAddedCallback;

		private Action<int> onActionRemovedCallback;

		private CharacterBase _carryTarget;

		private float releaseCarriedTimer;

		private List<ReserveAction> _reserveActions;

		private List<StackAction> _stackOptionActions;

		public Action deadEndEvent;

		private List<ResponseEventAction> _responseEventActions;

		private int _receivedApproachEventId;

		private Coroutine _delayActionCoroutine;

		public CharacterBase murdererCharacter;

		private List<EffectObject> _attachEffects;

		private List<EffectObject> stateAttackEffects;

		private Vector3 _pivotBase;

		private Transform _areaAnchor;

		private Vector3 _previousPosition;

		private bool _isCheckWall;

		private bool slipMoving;

		private static CharacterManager _charaManForOutside;

		private List<int> _listActionId;

		protected CharacterStateBase reserveActionState;

		protected CommonObjectStatus reserveActionTarget;

		public Dictionary<int, int> actionHitCountDic;

		public Dictionary<int, List<CharacterBase>> actionHitCharaDic;

		public List<int> _listOneTimeTalkAction;

		private GameObject[] _shadowObject;

		private Transform _shadowTrans;

		private Projector _shadowProjector;

		private const float kShadowSizeCoef = 0.6f;

		public float dynamicShadowScale;

		private List<ReservableActionInfo> _reservableActionIdList;

		private List<int> _activeCancelActionIdList;

		private List<int> _needCheckListOfActionShiftByInputSkillActionId;

		private List<int> _keepComboActionIds;

		protected Dictionary<int, AttachObject> _attachObjects;

		private int mainWeaponIndex;

		private int decoWeaponIndex;

		protected int[] mainWeaponIndicesForDmode;

		protected int[] decoWeaponIndicesForDmode;

		private int defaultMainWeaponIndex;

		private int defaultDecoWeaponIndex;

		private bool ignoreCheckWeaponVisible;

		private bool enableGlobalTimeScale;

		private static readonly float[] kCastMargin;

		private ShadowCastMethod _shadowCastMethod;

		private NotifyCharacter.Damage damageUI;

		public List<CharacterBase> BindTargets;

		public CharacterBase BindOwner;

		public DungeonObjectStatus BindOwnerGimmick;

		private CharacterDamageRecord damageRecord;

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

		public Dictionary<int, int> skillProductIdDic;

		public bool isSP0ForDmode;

		private const int ResourceIdOffset = 10000;

		private List<Coroutine> _coDelayEffects;

		private bool isResetChangeMeshRequested;

		private float lastWakeOnCollidedTime;

		public CharacterBase lastAttackedCharacter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 lastAttackedPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 lastHitPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion LastHitRotation => default(Quaternion);

		public bool enableSetSp
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int characterId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int dungeonPartyIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int actorIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int partySwitchIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int dungeonPartyPosition
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CharacterId multiPlayId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int battleGroup
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public InGameDef.CharacterType type
		{
			[CompilerGenerated]
			get
			{
				return default(InGameDef.CharacterType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public HitType hitType
		{
			[CompilerGenerated]
			get
			{
				return default(HitType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CharacterParameter param
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isSharingParam
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual int level => default(int);

		public int hp
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int maxHp => default(int);

		public int hpForPhoton
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float hpRate => default(float);

		public float prevHp
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float shpRate => default(float);

		public int attack => default(int);

		public int attackWhenAdditionalAttackBuffReceived
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual float defense => default(float);

		public float defCoef
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ElementalType element
		{
			[CompilerGenerated]
			get
			{
				return default(ElementalType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SecondElementsUniqueCtrl.ElementType secondElement
		{
			[CompilerGenerated]
			get
			{
				return default(SecondElementsUniqueCtrl.ElementType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual CharacterBuff buffCtrl => null;

		public bool resistBuffDebuff
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CharacterAbnormalStatus abnormalStatus
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual CharacterAbnormalStatus abnormalStatusForDamageCalc => null;

		public ResistAllAbnormal resistAllAbnormal
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected float hpDrainValue
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected float hpDrainBuffValue
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected List<CharacterBase> hpDrainTargets
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected bool isExecSelfDamage
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int timeStopDamage
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float exAbility2ImmutableHp
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual string DebugName => null;

		public virtual bool IsBoss => default(bool);

		public virtual bool IsRaidBoss => default(bool);

		public virtual bool IsStronger => default(bool);

		public bool nextCtrlChara
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isFollower => default(bool);

		protected float disableAvoidSecForFollower
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isGuest
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int aiType
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isEnemyTarget
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ChainCtrl chainCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected CharacterColor colorCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CharacterEffect effectCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CharacterSound soundCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public InvincibleControl invincibleCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual DamageImmunity damageImmCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isStop1
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isDead => default(bool);

		public bool isForceDead
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool wasForcedDead
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ControlDeath ctrlDeath => null;

		public virtual bool isOverdriveMode => default(bool);

		public virtual bool isBreakMode
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual bool isBarrierMode
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual bool isActiveBoundaryAction => default(bool);

		public bool isPause
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isPauseAction
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool canFinishDragonOnPause => default(bool);

		public bool isNoSound
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isNoReaction
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isSuperArmor
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isDisableExternalVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isExtraActionMode
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isSpacialDead
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual bool isNoTarget
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isEnableAdditionalInput
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int additionalInputCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int maxAdditionalInputCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool reachMaxAdditionalInput
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int additionalCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isUnusualPosture
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isNoCancelActionOnFreese
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isSpecialHate
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int superArmorLv
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool autoRecoveryOnDamageFlag
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public CharacterStates state
		{
			get
			{
				return default(CharacterStates);
			}
			set
			{
			}
		}

		public CharacterStates prevState
		{
			[CompilerGenerated]
			get
			{
				return default(CharacterStates);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public short stateIndex
		{
			[CompilerGenerated]
			get
			{
				return default(short);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BulletManager bulletManager => null;

		public float moveSpeed => default(float);

		public float dashSpeedRatio => default(float);

		public float curseMoveSpeedRatio
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float riptideSpeedRatio
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 actionMoveVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 externalVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 panelMoveVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 skillMoveVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 slipMoveVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isChargeCompleted => default(bool);

		public ChargeMarker chargeMarker
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ChargeMarker[] nextLevelChargeMarkers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ChargeMarker originalChargeMarker
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int chargeMarkerBulletEffectTriggerId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float chargePullLength
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 chargeMovePosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 chargeForward
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 chargeMarkerPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected CharacterDamageIntermediate damageIntermediate => null;

		public int damageIntermediateValue => default(int);

		public float speedRate => default(float);

		public float motionSpeed
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float actionSpeedScale
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float moveSpeedDownRatio => default(float);

		public float scaleRate
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Vector3 scale => default(Vector3);

		public float baseScaleRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public float baseRadius
		{
			get
			{
				return default(float);
			}
			protected set
			{
			}
		}

		public float radius => default(float);

		public float baseHeight
		{
			get
			{
				return default(float);
			}
			protected set
			{
			}
		}

		public float height => default(float);

		public virtual int IsHitCollisionOnCenter => default(int);

		public NavMeshAgent navMeshAgent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Collider collisionCollide
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Vector3 colliderPosition => default(Vector3);

		public Animator animator
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected RuntimeAnimatorController defaultAnimatorController
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Rigidbody rigidBody
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsExternalMoveAffected => default(bool);

		public CharacterFreeFall freeFall
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CharacterSlipCtrl slipCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform rootTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform centerTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform headTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform hipTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform weaponLTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform weaponRTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform muzzleTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float localTimeScale
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public List<ActionBase> actions => null;

		public int lastActionId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int nextActionIdForSendSignal
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool useAction
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool hasFirstAction
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ActionContainer lastActionContainer => null;

		public int carrySequenceId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isCarryMode => default(bool);

		public bool isCarryConfirmed
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float carryTimer
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int ParentBulletId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CommonObjectStatus targetObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float approachEventActionRange
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EventActionData.TargetType approachEventActionTargetType
		{
			[CompilerGenerated]
			get
			{
				return default(EventActionData.TargetType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string approachEventTargetEnemyName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int approachEventId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string watchingActionEventTargetEnemyName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int watchingActionEventTargetActionId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 pivotBase
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 basePosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Transform areaAnchor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EnemyOutsideWall enemyCheckOutside
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Vector3 previousPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool isCheckWall
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public CharacterManager charaManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected Dictionary<int, ActionContainerElement> dictActionDataResource => null;

		public List<int> listActionId => null;

		public int currentCombo
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isShiftPrevCombo
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float chargePrepareTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected Vector3 moveStartDirection
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected int reserveActionId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected int reserveSkillIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected Vector3? reserveDirection
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ActionHitRecord actionHitRecord
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GameObject bulletObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isUsedTransformDragon
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CharacterMoveEventClock moveEventClock
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AbnormalStatusMultiPlayService AbnormalStatusMultiPlayService
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BuffMultiPlayService BuffMultiPlayService => null;

		public virtual SkillPointMultiPlayService SkillPointMultiPlayService => null;

		public virtual EnergyPointMultiPlayService EnergyPointMultiPlayService => null;

		public virtual AbilityGaugeMultiPlayService AbilityGaugeMultiPlayService => null;

		public virtual WarpRoom.RoomGroup warpRoomGroupId
		{
			[CompilerGenerated]
			get
			{
				return default(WarpRoom.RoomGroup);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isSkipActionEndPlayIdleMotion
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool motionBlendToIdle
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CUGCtrl uniqueGimmick
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public CtrlBind ctrlBind
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isBind => default(bool);

		public int boundNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isBindOnTransform => default(bool);

		public CharacterDamageRecord DamageRecord => null;

		public float idleBlendDuration
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual int sameHitPriority => default(int);

		public bool IsInsideBRBush => default(bool);

		public bool isInvisibleByInsideBRHouse
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsInsideBRBushOrHouse => default(bool);

		public virtual string effNameCriticalHit => null;

		public virtual string IdleStateName => null;

		public virtual string WalkStateName => null;

		public event Action<int, int[], float[], RunActionEvent, bool> stateChangedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<CharacterBase> deadEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action initStateEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public virtual void SetModelType(ModelType type)
		{
		}

		public virtual void UpdateFace()
		{
		}

		public void SetFaceEyeDirect(int index)
		{
		}

		public void SetFaceMouthDirect(int index)
		{
		}

		public virtual void SetCharaColor()
		{
		}

		public static bool IsHitTypeManagedOhter(HitType hitType)
		{
			return default(bool);
		}

		public bool IsPlayer(out PlayerCharacter player)
		{
			return default(bool);
		}

		public bool IsPlayerCharacter(bool ignoreTransform = false)
		{
			return default(bool);
		}

		public bool IsSupportCharacter()
		{
			return default(bool);
		}

		public bool IsSupportRequestCharacter()
		{
			return default(bool);
		}

		public bool IsServantForPlayerCharacter()
		{
			return default(bool);
		}

		private bool IsLAN5WATER04()
		{
			return default(bool);
		}

		public bool IsRockman()
		{
			return default(bool);
		}

		public bool IsRockmanBoss()
		{
			return default(bool);
		}

		public bool IsEightPt()
		{
			return default(bool);
		}

		public bool IsEightServant()
		{
			return default(bool);
		}

		public bool IsAttackHitResistAbnormalStatus()
		{
			return default(bool);
		}

		public virtual void IgnoreCollide(CharacterBase target, bool isIgnore = true)
		{
		}

		public void SetDefaultAnimatorController(RuntimeAnimatorController value)
		{
		}

		public void disableFreeFall()
		{
		}

		public void EnterCarryMode(CharacterBase targetChara)
		{
		}

		public void LeaveCarryMode(bool isThrow)
		{
		}

		public void SetIsCheckWallForcibly(bool value)
		{
		}

		public bool IsHiding()
		{
			return default(bool);
		}

		public bool IsHidingOrInsideBRBushOrHouse(bool exceptsCameraFocusChara = true)
		{
			return default(bool);
		}

		protected override void Awake()
		{
		}

		public void Initialize(InGameDef.CharacterType charaType, bool isNeedShadow)
		{
		}

		protected void InitializeParts()
		{
		}

		public virtual void SetupAbilityCommonData(bool isQuestStart)
		{
		}

		protected virtual void SetupCharacterState()
		{
		}

		public void InvokeStateChangedEvent(int[] param, float[] paramf, RunActionEvent runActionEvent, bool ignoreSync)
		{
		}

		public virtual Vector3 EffectScale()
		{
			return default(Vector3);
		}

		public virtual Vector3 AuraScale(bool isDynamicScale = false)
		{
			return default(Vector3);
		}

		public virtual Vector4 EmotionIconParam()
		{
			return default(Vector4);
		}

		public virtual float ShadowSize()
		{
			return default(float);
		}

		private void ChangeShadowCastMethod(ShadowCastMethod method)
		{
		}

		private void UpdateShadowSizeByHeight()
		{
		}

		private float GetShadowSizeHeightCoef()
		{
			return default(float);
		}

		protected virtual void PreChangeState(CharacterState characterState)
		{
		}

		protected virtual void PostChangeState(CharacterState characterState)
		{
		}

		public virtual void ChangeState(CharacterState characterState)
		{
		}

		public int GetBulletId()
		{
			return default(int);
		}

		public virtual bool RunningBarrier(CollisionHitAttribute data)
		{
			return default(bool);
		}

		public virtual bool IsCounterAction(Vector3 attackDir, CollisionHitAttribute data)
		{
			return default(bool);
		}

		public bool IsGuardState()
		{
			return default(bool);
		}

		public bool IsValidTarget(bool includeDeadman = true)
		{
			return default(bool);
		}

		public virtual bool IsTimeStop()
		{
			return default(bool);
		}

		public virtual bool IsTimeStopInput()
		{
			return default(bool);
		}

		public virtual bool IsTimeStopBuffAbnormalStatusDragonTimer()
		{
			return default(bool);
		}

		protected virtual bool IsSuperArmor()
		{
			return default(bool);
		}

		public bool IsInvincible(int breakLevel = 0)
		{
			return default(bool);
		}

		protected bool IsBreakInvincible(int breakLevel)
		{
			return default(bool);
		}

		public bool IsInvincibleOnHitCheck(CollisionHitAttribute attr)
		{
			return default(bool);
		}

		public virtual void AddInvincible(InvincibleControl.Type type, int level, float sec, int uid = 0)
		{
		}

		public virtual void RemoveInvincible(InvincibleControl.Type type, int uid = 0)
		{
		}

		public void AddInvincibleFromAction(int level)
		{
		}

		public void CancelInvincible()
		{
		}

		public void CancelUnderLevelInvincible(int level)
		{
		}

		public void CancelInvincibleForAllKillAttack()
		{
		}

		public void ActivateDownRecovery()
		{
		}

		public void InactivateDownRecovery()
		{
		}

		public bool IsShieldBlock(int damage)
		{
			return default(bool);
		}

		protected virtual bool IsHitFlash()
		{
			return default(bool);
		}

		protected virtual bool IsResistBlast()
		{
			return default(bool);
		}

		protected virtual bool IsBreakAction()
		{
			return default(bool);
		}

		public virtual void StartBreak()
		{
		}

		public virtual void BreakFinish()
		{
		}

		public virtual void CutoffBreak()
		{
		}

		public virtual void OnBreakDamage(int breakDamage)
		{
		}

		protected virtual bool DropDp(float prevHpRate, CharacterBase triggerChara, float coef)
		{
			return default(bool);
		}

		public virtual void FreezePosition()
		{
		}

		public virtual void UnFreezePosition()
		{
		}

		protected virtual bool IsTurnToDamageDir(DamageReaction reaction)
		{
			return default(bool);
		}

		public bool IsTransformDragonOrUnique()
		{
			return default(bool);
		}

		public bool CancelTransformDragonOrUnique(bool isCancel)
		{
			return default(bool);
		}

		public virtual bool IsTransformDragon()
		{
			return default(bool);
		}

		public virtual bool IsEnhanceDragon()
		{
			return default(bool);
		}

		public virtual bool IsPureDragon()
		{
			return default(bool);
		}

		public virtual bool IsServant()
		{
			return default(bool);
		}

		public virtual bool IsServitor()
		{
			return default(bool);
		}

		public virtual void CancelTransform()
		{
		}

		public virtual bool IsUniqueTransformMode()
		{
			return default(bool);
		}

		public virtual void ReleaseUniqueTransform(bool isCancel)
		{
		}

		public void CancelTransformForAnnihilationAttack()
		{
		}

		public virtual void SetIsPauseDragonTime(bool isPause)
		{
		}

		public virtual bool IsPauseDragonTime()
		{
			return default(bool);
		}

		public void LoadAnimationController(string path, Action<CharacterAnimationEvent> animEventSetupAction, int baseId = -1, int variationId = -1, bool ignoreBRSkin = false)
		{
		}

		protected void LoadActionContainerElements(InGameDef.CharacterType characterType, string groupName, bool isOtherPlayer, bool exceptOtherSkills = false, bool isShareSkill = false)
		{
		}

		public void LoadActionResources()
		{
		}

		protected void LoadActionContainers(List<int> actions, string groupName, bool isOtherPlayer, bool exceptOtherSkills = false, bool isShareSkill = false)
		{
		}

		protected void AddLoadActions(List<int> actions, SkillDataElement skillData)
		{
		}

		protected void AddLoadActions(List<int> actions, int actionId)
		{
		}

		public int GetAdvancedActionId(SkillDataElement skillData)
		{
			return default(int);
		}

		public int GetBaseIdActionId(SkillDataElement skillData)
		{
			return default(int);
		}

		private bool LoadActionPartsSpecificAction(List<int> actions, int actionId)
		{
			return default(bool);
		}

		private bool LoadEnhancedSkillAction(List<int> actions, int actionId, int skillId, string groupName, bool isOtherPlayer, int depth = 0)
		{
			return default(bool);
		}

		public bool LoadEnhancedAbilityBurstAttackAction(List<int> actions, int actionId)
		{
			return default(bool);
		}

		protected bool LoadNextAction(List<int> actions, int actionId)
		{
			return default(bool);
		}

		private bool LoadCastingAction(List<int> actions, int actionId)
		{
			return default(bool);
		}

		public void AddAttachEffect(EffectObject effectObject)
		{
		}

		public void ClearAttachEffect()
		{
		}

		public void SetPauseAttachEffect(bool isPause)
		{
		}

		public void SetPauseAttachEffectForTimeStop(bool isPause)
		{
		}

		public void AddStateAttackEffect(EffectObject eo)
		{
		}

		public void ClearStateAttackEffect()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public void SetSlip(bool b)
		{
		}

		private void FixedUpdate()
		{
		}

		protected void UpdateAction()
		{
		}

		protected void FixedUpdateAction()
		{
		}

		protected void UpdateCheckWall()
		{
		}

		public override void LateUpdate()
		{
		}

		public Vector3 GetCenterPosition()
		{
			return default(Vector3);
		}

		public Transform GetCenterTransform()
		{
			return null;
		}

		public Transform GetHeadTransform()
		{
			return null;
		}

		protected void SetMuzzleTransform()
		{
		}

		public Transform GetMuzzleTransform()
		{
			return null;
		}

		public bool GetAutoDashPosition(out Vector3 pos)
		{
			return default(bool);
		}

		public Vector3 GetForwardMove()
		{
			return default(Vector3);
		}

		public void SetMoveStartDirection()
		{
		}

		public bool UpdateRotateToTarget(CommonObjectStatus target, bool useLegacyRotate)
		{
			return default(bool);
		}

		public bool UpdateRotateToTarget(Vector3 targetPos, bool useLegacyRotate, float speed = 1f)
		{
			return default(bool);
		}

		public float CalcRotateSpeed(float speed = 1f)
		{
			return default(float);
		}

		public bool IsLookTarget(Vector3 targetPos, float speed = 1f)
		{
			return default(bool);
		}

		public void LookAt(Vector3 position)
		{
		}

		public void LookTo(Vector3 direction)
		{
		}

		private void LookToDamageDirection(CollisionHitAttribute attr)
		{
		}

		public void PlayAnimation(string stateName)
		{
		}

		public void PlayBlendAnimation(string stateName, float blendDuration, bool checkSame)
		{
		}

		public void PlayAnimationForAttachObject(string stateName)
		{
		}

		public void PlayBlendAnimationForAttachObject(string stateName, float blendDuration, bool checkSame)
		{
		}

		public virtual void PlayDefaultMoveAnimationForEventRecevier()
		{
		}

		public void PlayDefaultIdleAnimationForEventRecevier(float blendDuration, bool checkSame)
		{
		}

		public bool CanPlayAnimationForEventRecevier()
		{
			return default(bool);
		}

		public float GetAnimationTime()
		{
			return default(float);
		}

		public float GetAnimationLength()
		{
			return default(float);
		}

		public float GetAnimationNormalizedTime()
		{
			return default(float);
		}

		public bool IsAnimationState(string stateName)
		{
			return default(bool);
		}

		public bool IsNextAnimationState(string stateName)
		{
			return default(bool);
		}

		public bool IsLoopAnimation()
		{
			return default(bool);
		}

		public void SetAnimationTime(float time)
		{
		}

		public void RestoreAnimation()
		{
		}

		public bool IsEnableAction()
		{
			return default(bool);
		}

		protected void AddReserveAction(int actionId, int skillId, CommonObjectStatus target, [Optional] Action<ActionBase> argActionEndCallback, bool resistClear = false, bool viaAttackState = false)
		{
		}

		public virtual void AddAction(int actionId, int skillId = 0, [Optional] CommonObjectStatus target, [Optional] Action<ActionBase> argActionEndCallback, bool viaAttackState = false)
		{
		}

		public bool IsContainsReserveAction(int actionId)
		{
			return default(bool);
		}

		public void RemoveReserveAction(int actionId)
		{
		}

		private void ClearReserveActionList()
		{
		}

		public void AddStackOptionAction(int actionId, Vector3 position)
		{
		}

		public void DelayAction(float delay, int actionId)
		{
		}

		public IEnumerator DelayRunAction(float delay, int actionId)
		{
			return null;
		}

		protected ActionContainer LoadActionContainer(int actionId)
		{
			return null;
		}

		public static long GetActionPartsResouceId(int actionId, int partsIndex)
		{
			return default(long);
		}

		public Gluon.ActionData.ActionParts.PartsData GetActionPartsResource(long resourceId)
		{
			return null;
		}

		public ActionParts GetActionPartsByResourceId(long resourceId)
		{
			return null;
		}

		public RunActionResult RunAction(int actionId, int skillId = 0, float tempoScale = 1f, [Optional] CommonObjectStatus target, [Optional] Action<ActionBase> actionFinishCallback, [Optional] RunActionParameterBase startActionContext, int overrideActionProductId = -1, bool setUseActionFlag = true, bool isFromOption = false, bool dontLootAtReservedTarget = false, [Optional] Action<ActionBase> onActionLoadedCallback, [Optional] Action<ActionBase> onActionRunCallback)
		{
			return default(RunActionResult);
		}

		public bool IsActionDataResource(int actionId)
		{
			return default(bool);
		}

		public bool GetActionContainer(int actionId, out ActionContainer container)
		{
			return default(bool);
		}

		public RunActionResult RunAction(ActionBase action, [Optional] RunActionParameterBase runActionParam, bool setUseActionFlag = true, bool isFromOption = false)
		{
			return default(RunActionResult);
		}

		public void ClearActionIdList()
		{
		}

		public void RemoveAction(ActionBase action)
		{
		}

		public void ClearActionByActionId(int actionId)
		{
		}

		public void ForceClearAllActions()
		{
		}

		public void ClearAction(bool allClear = true, int excludeId = 0)
		{
		}

		private void ResetReserveAction()
		{
		}

		public void ClearReserveAction()
		{
		}

		protected void ClearInputReserveAction()
		{
		}

		public void ResetAction(bool bResetHitStopPlayer = true, bool allClear = true, int excludeId = 0, bool resetReserve = true, bool stopAdditionalInputUI = true)
		{
		}

		public void PauseAction(bool isPause)
		{
		}

		public void StopAdditionalInputUI()
		{
		}

		public bool IsRunningAction(bool excludeOptionActions = false)
		{
			return default(bool);
		}

		public int RunningActionNum(bool excludeOptionActions = false)
		{
			return default(int);
		}

		public int GetCurrentActionId(bool excludeOptionActions = false)
		{
			return default(int);
		}

		public void RegisterKeepComboAction(int actionId)
		{
		}

		public bool CanKeepCombo()
		{
			return default(bool);
		}

		public virtual void ResetSuperArmorLevel()
		{
		}

		public void SendSignal(SendSignalData sendSignalData, ActionSignal type, int actionId, int decoId, CharacterBuffType hitRecordTargetBuffType = CharacterBuffType.None)
		{
		}

		public void RemoveSignal(SendSignalData sendSignalData, ActionSignal type, int actionId, int decoId, bool isActionEnd = false)
		{
		}

		protected virtual void ResetAttachSignal(int actionId, int skillId)
		{
		}

		public bool IsReservableActionID(ActionSignal type, int actionId)
		{
			return default(bool);
		}

		public void SetActiveCancelActionID(int id)
		{
		}

		public void RemoveActiveCancelActionID(int id)
		{
		}

		public bool CanCancelAction(int nextActionId)
		{
			return default(bool);
		}

		public bool CanCancelReservedAction()
		{
			return default(bool);
		}

		public bool CanAttackAction()
		{
			return default(bool);
		}

		public void AddEventAction(EventActionData.EventType type, UnityEvent resEvent)
		{
		}

		public void DelEventAction(UnityEvent resEvent)
		{
		}

		public void ResponseEventActions(EventActionData.EventType type)
		{
		}

		private void UpdateEventActionCondition()
		{
		}

		private void CheckApproachEventAction()
		{
		}

		protected virtual void CheckStopAbnormalEventAction()
		{
		}

		private void CheckWatchingActionEventAction()
		{
		}

		public virtual bool ReserveMoveAction()
		{
			return default(bool);
		}

		private void RunAvoidAction(Vector3 dir, InGameDef.Direction dirType)
		{
		}

		public bool ReserveAvoidAction(Vector3 dir, bool withStateChange = true)
		{
			return default(bool);
		}

		public bool IsEnableAvoidActionImmediately()
		{
			return default(bool);
		}

		private bool IsEnableAvoidAction()
		{
			return default(bool);
		}

		public bool CanReserveAvoidAction(CollisionHitAttribute hitAttr, bool withStateChange)
		{
			return default(bool);
		}

		protected virtual float AvoidDirectionCoef(InGameDef.Direction dirType, int actionId)
		{
			return default(float);
		}

		public virtual void UpdateChargeMarker()
		{
		}

		public virtual void CreateChargeBullet(string effectName)
		{
		}

		public virtual void DeleteChargeBullet()
		{
		}

		public void ClearChargeMarker(bool setImpact, bool setNull)
		{
		}

		public virtual void AdvanceChargeLevel(int level)
		{
		}

		public virtual float GetSuperArmorTimeOnCharge()
		{
			return default(float);
		}

		public bool EnableChargeStart()
		{
			return default(bool);
		}

		public bool ShouldDisableSkillByRequiredBuff(int i, out int spGaugeCount)
		{
			return default(bool);
		}

		public bool EnableSkillAction(int idx, int nextActionIdForActiveCancel = 0)
		{
			return default(bool);
		}

		public bool NeedRunSkillCastAction(int actionId)
		{
			return default(bool);
		}

		public bool RunSkillAction(int idx, int actionId, CommonObjectStatus target, bool checkEnable = true, bool SkillProduction = false)
		{
			return default(bool);
		}

		public bool RunSkillCastAction(int skillIdx, int actionId, CommonObjectStatus target, bool checkEnable = true)
		{
			return default(bool);
		}

		public bool IsActivateSkill(int idx)
		{
			return default(bool);
		}

		public int GetActiveSkillId()
		{
			return default(int);
		}

		public virtual void SetupSkillMoveInput(MoveInputData data)
		{
		}

		public virtual void ResetSkillMoveInput()
		{
		}

		public virtual void SetupSkillRotateInput(RotateInputData data)
		{
		}

		public virtual void ResetSkillRotateInput()
		{
		}

		public virtual bool RunGuardAction()
		{
			return default(bool);
		}

		public void RunGuardCancel()
		{
		}

		public bool RunGuardCancelAttack()
		{
			return default(bool);
		}

		public bool RunBlastRecoveryAction(Vector3 look, bool isCtrl)
		{
			return default(bool);
		}

		public void RunGuts()
		{
		}

		public GameObject GetAttachObject(int decoId)
		{
			return null;
		}

		private void SetVisible(bool visible, int decoId)
		{
		}

		public bool SetVisibleMainWeapon(bool visible, bool forcibly = false)
		{
			return default(bool);
		}

		protected void SetVisibleDecoWeapon(bool visible, bool forcibly = false)
		{
		}

		private bool IsVisibleMainWeapon()
		{
			return default(bool);
		}

		private bool IsVisibleDecoWeapon()
		{
			return default(bool);
		}

		private bool IsVisibleWeapon(int index)
		{
			return default(bool);
		}

		public void SetVisibleMainWeaponWithIgnoreCheck(bool visible)
		{
		}

		private void SetVisibleWeaponForSendSignal(bool visible, int actionId)
		{
		}

		public void SetVisibleWeaponForCommand(CommandData partsData, int key)
		{
		}

		public void ChangeAttachWeapon(HandID handId, int weaponKey = -1)
		{
		}

		protected void ChangeAttachWeaponForSendSignal(HandID handId, int actionId)
		{
		}

		public virtual bool IsMatchAttachWeaponHandType(AttachWeaponHandType type)
		{
			return default(bool);
		}

		public GameObject GetMainAttachWeapon()
		{
			return null;
		}

		public GameObject GetDecoAttachWeapon()
		{
			return null;
		}

		public void AttachHumanWeaponSkin(int weaponSkinId, bool isNondominanntHand = false)
		{
		}

		protected string GetWeaponAttachNode(WeaponType weaponType, bool isNondominanntHand = false)
		{
			return null;
		}

		public virtual void SwitchHumanWeaponSkinAsMainWeapon(int weaponSkinId, bool isDeco, int skillIndex)
		{
		}

		public void SwitchHumanWeaponSkinForDmodeChangeEquipWeapon(int weaponSkinId)
		{
		}

		protected int ConvertWeaponSkinIdToIndex(int weaponSkinId)
		{
			return default(int);
		}

		private int ConvertWeaponSkinIdToIndex(int baseId, int varId)
		{
			return default(int);
		}

		public int AttachHumanWeaponSkinForCommand(CommandData partsData)
		{
			return default(int);
		}

		public void DestroyAttachedHumanWeapon()
		{
		}

		public void DestroyAttachedHumanWeapon(int mainIndex, int decoIndex)
		{
		}

		public int AttachHumanWeapon(int baseId, int variationId, string nodeName)
		{
			return default(int);
		}

		public GameObject LoadHumanWeapon(int baseId, int variationId)
		{
			return null;
		}

		public static GameObject LoadHumanWeapon(string path)
		{
			return null;
		}

		public void AttachHumanEnemyObject(string eoModelStr)
		{
		}

		public virtual bool IsKatAndOriginalHandType()
		{
			return default(bool);
		}

		public virtual WeaponType GetWeaponType()
		{
			return default(WeaponType);
		}

		public virtual WeaponTypeElement GetWeaponTypeElement()
		{
			return null;
		}

		public virtual ElementalType GetWeaponElement()
		{
			return default(ElementalType);
		}

		public virtual ElementalType GetDragonElement()
		{
			return default(ElementalType);
		}

		public virtual int GetBaseAuraMaxLimitLevel(int defaultBaseMaxLimitLevel)
		{
			return default(int);
		}

		public virtual CharacterBase GetOriginalChara()
		{
			return null;
		}

		public virtual CharacterBase GetDragonChara()
		{
			return null;
		}

		public virtual CharacterBase GetCurrentChara()
		{
			return null;
		}

		public virtual CharacterSelector GetSelecter()
		{
			return null;
		}

		public virtual TribeType GetTribe()
		{
			return default(TribeType);
		}

		public virtual int GetComboAttackId(int idx, bool ex)
		{
			return default(int);
		}

		public int GetNextAttackId(bool ex)
		{
			return default(int);
		}

		public virtual int GetMaxCombo()
		{
			return default(int);
		}

		public virtual int GetAvoidActionId(InGameDef.Direction dir)
		{
			return default(int);
		}

		public virtual int[] GetAllAvoidActions(InGameDef.Direction dir)
		{
			return null;
		}

		public int[] GetAllComboActions()
		{
			return null;
		}

		public virtual int GetDashAttackActionId()
		{
			return default(int);
		}

		public virtual int GetDashOnAvoidActionId(bool forAI)
		{
			return default(int);
		}

		public virtual int GetBurstAttackActionId()
		{
			return default(int);
		}

		public virtual int GetGuardActionId()
		{
			return default(int);
		}

		public virtual int GetGuardCancelAttackId()
		{
			return default(int);
		}

		public virtual int GetDamagedActionId()
		{
			return default(int);
		}

		public virtual int GetParalysisActionId()
		{
			return default(int);
		}

		public virtual int GetDragonTransformActionId()
		{
			return default(int);
		}

		public virtual bool IsTurnToTarget(int id)
		{
			return default(bool);
		}

		public virtual bool IsRequestGuardRigor()
		{
			return default(bool);
		}

		public virtual void CancelRequestGuardRigor()
		{
		}

		public virtual bool IsCombo(int actionId)
		{
			return default(bool);
		}

		public bool IsSkill(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false, bool includeChainSkill = false, bool includeActionShiftByInput = false)
		{
			return default(bool);
		}

		public bool IsNormalSkill(int actionId, bool includeTransSkill, bool includeEnhancedSkill, bool includeChainSkill)
		{
			return default(bool);
		}

		public bool IsSkill1(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false, bool includeChainSkill = false, bool includeActionShiftByInput = false)
		{
			return default(bool);
		}

		public bool IsSkill2(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false, bool includeChainSkill = false, bool includeActionShiftByInput = false)
		{
			return default(bool);
		}

		public bool IsWeaponSkill(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false)
		{
			return default(bool);
		}

		public bool IsSkill3(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false)
		{
			return default(bool);
		}

		public bool IsSkill4(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false)
		{
			return default(bool);
		}

		public bool IsSkillFA(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false)
		{
			return default(bool);
		}

		public bool IsSkillDmode(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false)
		{
			return default(bool);
		}

		private bool IsSkillForSkillIndex(int skillIndex, int actionId, bool includeTransSkill, bool includeEnhancedSkill, bool includeChainSkill, bool includeActionShiftByInput)
		{
			return default(bool);
		}

		private bool IsTransSkill(int skillIndex, int actionId)
		{
			return default(bool);
		}

		private bool IsEnhancedSkill(int skillIndex, int actionId)
		{
			return default(bool);
		}

		private bool IsChainSkill(int skillIndex, int actionId)
		{
			return default(bool);
		}

		private bool IsActionShiftByInputSkill(SkillDataElement sde, int skillIndex, int actionId)
		{
			return default(bool);
		}

		protected bool IsSkill(SkillDataElement sde, int actionId)
		{
			return default(bool);
		}

		public virtual bool IsDashAttack(int actionId)
		{
			return default(bool);
		}

		public virtual bool IsBurstAttack(int actionId, bool isIncludeDragonBurst = true)
		{
			return default(bool);
		}

		public virtual bool IsInputCharge()
		{
			return default(bool);
		}

		public virtual bool IsInputMove()
		{
			return default(bool);
		}

		protected virtual AbnormalStatusProbabilityResult GetAbnormalStatusProbability(CollisionHitAttribute attr, int type, float probablity)
		{
			return default(AbnormalStatusProbabilityResult);
		}

		protected virtual float GetAbnormalStatusResistRate(int type)
		{
			return default(float);
		}

		public virtual float GetSearchRange()
		{
			return default(float);
		}

		public bool ReserveNextAttackAction(CommonObjectStatus target, bool isAI)
		{
			return default(bool);
		}

		private bool ReserveNextAttackAction(int nextId, CommonObjectStatus target)
		{
			return default(bool);
		}

		public int DashAttack()
		{
			return default(int);
		}

		public bool IsDashAttackAction()
		{
			return default(bool);
		}

		public void StartCharge(int chargePhase)
		{
		}

		public void CancelCharge(bool keepCurrentAction = false)
		{
		}

		public bool IsChargeCancel()
		{
			return default(bool);
		}

		public bool IsRunningBurstAttack(bool checkCurrentAction = false)
		{
			return default(bool);
		}

		public bool IsMovingBurstAttack()
		{
			return default(bool);
		}

		public bool IsActionReserved()
		{
			return default(bool);
		}

		public bool IsReserveDisturbanceAction()
		{
			return default(bool);
		}

		public bool IsReserveFreezeAction()
		{
			return default(bool);
		}

		public bool IsReserveSwoonAction()
		{
			return default(bool);
		}

		public bool IsReserveSleepAction()
		{
			return default(bool);
		}

		public bool IsReserveParalysisAction()
		{
			return default(bool);
		}

		public virtual int GetSkillNum()
		{
			return default(int);
		}

		public virtual CharacterSkillData GetSkillData(int index)
		{
			return null;
		}

		public virtual SkillDataElement GetSkillDataElement(int index)
		{
			return null;
		}

		public virtual SkillDataElement GetTransSkillDataElement(int index, int phase)
		{
			return null;
		}

		public virtual SkillDataElement GetNextTransSkillDataElement(int index)
		{
			return null;
		}

		public virtual AbilityDataElement GetAbilityDataElement(int index)
		{
			return null;
		}

		public virtual AbilityDataElement GetAmuletAbilityDataElement(int crestSlotNo, int abilitySlotNo)
		{
			return null;
		}

		public virtual AbilityDataElement GetTalismanAbilityDataElement(int talismanSlotNo, int abilitySlotNo)
		{
			return null;
		}

		public virtual AbilityDataElement GetDragonAbilityDataElement(int idx)
		{
			return null;
		}

		public virtual AbilityDataElement GetWeaponAbilityDataElement(int idx)
		{
			return null;
		}

		public virtual AbilityDataElement GetSkillAbilityDataElement(int index)
		{
			return null;
		}

		public virtual AbilityDataElement GetExAbility2DataElement(int index)
		{
			return null;
		}

		public virtual AbilityDataElement GetEventAbilityDataElement(int index)
		{
			return null;
		}

		public virtual TalismanDataElement GetTalismanDataElement(int index)
		{
			return null;
		}

		public virtual PlayerActionElement GetParentNextActionDataElement(int actionId)
		{
			return null;
		}

		public virtual string GetAttackCueName(int comboIndex)
		{
			return null;
		}

		public virtual string GetDashAttackCueName()
		{
			return null;
		}

		public virtual string GetSkillCueName(int idx)
		{
			return null;
		}

		public virtual string GetDamageCueName()
		{
			return null;
		}

		public virtual string GetBlastCueName()
		{
			return null;
		}

		public virtual string GetAvoidCueName()
		{
			return null;
		}

		public virtual string GetContinueCueName()
		{
			return null;
		}

		public virtual string GetChangePlayerCueName()
		{
			return null;
		}

		public virtual string GetDragonTransformCueName()
		{
			return null;
		}

		public virtual string GetWinCueName()
		{
			return null;
		}

		public virtual string GetQuestFailedCueName()
		{
			return null;
		}

		public virtual string GetTalkCueNamePrefix()
		{
			return null;
		}

		public void ChargePrepare()
		{
		}

		public void ResetChargePrepare()
		{
		}

		public void RestartSlip()
		{
		}

		public virtual void CallbackHitAction(CollisionHitAttribute attr)
		{
		}

		public virtual void SetEnhancedBurstAttackId(int actionId, int modifyChargeLevel)
		{
		}

		public virtual void ResetEnhancedBurstAttackId()
		{
		}

		public virtual int GetEnhancedBurstAttackId()
		{
			return default(int);
		}

		public virtual int GetActualEnhancedBurstAttackId()
		{
			return default(int);
		}

		public virtual void SetEnhancedAbilityBurstAttackId(int actionId)
		{
		}

		public virtual void SetEnhancedSkillId(int enhancedIndex, int enhancedId, int skillId, int depth)
		{
		}

		public virtual int GetEnhancedSkillId(int skillIndex, int depth)
		{
			return default(int);
		}

		public virtual void SetupEnhancedSkill(int enhancedIndex, int enhancedId, int skillId)
		{
		}

		public virtual void ResetEnhancedSkill(CharacterBuffType buffType, int conditionId)
		{
		}

		public virtual void ResetEnhancedSkill(int skillIndex)
		{
		}

		public virtual void CheckTransSkill(CollisionHitAttribute attr)
		{
		}

		public virtual void CheckTransOverChargeSkill(int skillIndex)
		{
		}

		public virtual void TransformSkillForSkillId(int skillId)
		{
		}

		public virtual void ResetTransSkill(int skillId)
		{
		}

		public virtual void DisableTrans(int skillIndex)
		{
		}

		public virtual bool IsPauseTransBuff(int skillId)
		{
			return default(bool);
		}

		public virtual void PauseTransBuff(int skillIndex, bool pause)
		{
		}

		public void RecoveryHpOnHitCount(CollisionHitAttribute attr, int hitCount)
		{
		}

		protected int ActivateAbilityOnDamaged(int damage, bool isAnnihilationAttack)
		{
			return default(int);
		}

		protected void ActivateAbilityOnHeal()
		{
		}

		protected void ActivateAbilityOnRevive(bool isReborn)
		{
		}

		protected bool ActivateAbilityOnAvoid(CharacterBase attacker)
		{
			return default(bool);
		}

		public bool CheckOnAttackedDuringInvincible(int invincibleBreakLv)
		{
			return default(bool);
		}

		private void OnAttackedDuringInvincible(CharacterBase attacker, int invincibleBreakLv)
		{
		}

		public bool CheckFollowerAvoid(int probability)
		{
			return default(bool);
		}

		public virtual bool OnCollided(CollisionHitAttribute hitAttr, HitProduction hitProduction = HitProduction.All, int followerAvoid = 0)
		{
			return default(bool);
		}

		protected virtual void ProcedureDamage(CollisionHitAttribute hitAttr, int damage, float pureElementRate, bool isCritical, bool isTolerance, bool isKiller, bool isLethal, bool isPenetrateShield, HitProduction hitProduction, string additionalAttackEffect)
		{
		}

		protected virtual void ProcedureZeroDamage(CollisionHitAttribute hitAttr, float pureElementRate, HitProduction hitProduction, bool buffApplied)
		{
		}

		protected virtual void ProcedureDamageToDragon(CollisionHitAttribute hitAttr, int damage, float dragonTimerDamage, float pureElementRate, bool isTolerance, bool isPenetrateShield, HitProduction hitProduction)
		{
		}

		private void ProcedureHeal(CollisionHitAttribute hitAttr, int damage)
		{
		}

		private void ProcessHitStop(CollisionHitAttribute hitAttr, bool isNoDamage)
		{
		}

		public virtual void OnDamaged(AttackHit hitData, CollisionHitAttribute hitAttr, CharacterBase from)
		{
		}

		private bool CanDispHeadText(CollisionHitAttribute hitAttr)
		{
			return default(bool);
		}

		public virtual void BuildDamage(int damage, CollisionHitAttribute hitAttr, Vector3 hitPos, CharacterDamageIntermediate outIntermediate)
		{
		}

		public virtual void ApplyDamage(CharacterDamageIntermediate intermediate)
		{
		}

		private void CalcDrainValue(CharacterDamageIntermediate intermediate)
		{
		}

		public virtual void DrainHp(CollisionHitAttribute attr)
		{
		}

		public void ResetDrainValue()
		{
		}

		protected CharacterBase GetDrainTarget()
		{
			return null;
		}

		public virtual void ExecSelfDamage(CollisionHitAttribute attr)
		{
		}

		public virtual void ApplySubstitudeDamage(int damage, bool fromSync = false)
		{
		}

		public void ThrowDamage(CharacterBase attacker)
		{
		}

		public void CalcParalysisDamage(int slipDamage, bool isFollower, bool isNotify)
		{
		}

		public void CalcAbnormalStatusDamage(CharacterBase attacker, int damage, bool isFollower, AbnormalStatusType type, [Optional] Dictionary<CharacterBase, int> froms)
		{
		}

		public virtual void ApplySlipDamage(CharacterBase attacker, int damage, bool isFollower, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int buffIconId, [Optional] Dictionary<CharacterBase, int> froms)
		{
		}

		public virtual bool ApplyDragonTimerSlipDamage(int damage, bool isFollower, CharacterBuffType buffType, int buffIconId, float dragonTimerDamageFromMulti = 0f)
		{
			return default(bool);
		}

		public bool IsCorrosionSlipDamage(CharacterBuffType buffType, int buffIconId)
		{
			return default(bool);
		}

		public void CalcHitPosAndRot(CollisionHitAttribute attr, out Vector3 pos, out Quaternion rot, bool isPenetrateShield = false)
		{
		}

		private void PlayDamageEffect(CollisionHitAttribute hitAttr, Vector3 hitPos, Quaternion rot, bool isCritical, bool isKiller, bool isTolerance, bool isLethal, bool isPenetrateShield, HitProduction hitProduction, DamageReaction reaction, string additionalAttackEffect = "")
		{
		}

		private void PlayDamageEffect(CharacterBase owner, CollisionHitAttribute hitAttr, Vector3 hitPos, Quaternion rot, bool isCritical, bool isKiller, bool isTolerance, bool isLethal, bool isPenetrateShield, HitProduction hitProduction, DamageReaction reaction, string additionalAttackEffect = "")
		{
		}

		protected virtual void DamageHitFlash()
		{
		}

		private bool CheckGraphicQualityForPlayEffect()
		{
			return default(bool);
		}

		private void PlaySPHealEffect(CollisionHitAttribute attr)
		{
		}

		private void PlayHealEffect(CollisionHitAttribute attr)
		{
		}

		private void PlayZeroDamageEffect(CollisionHitAttribute attr)
		{
		}

		private void PlayHealSE()
		{
		}

		private void PlayDefaultHealEffect()
		{
		}

		public void PlayCommonHealEffectAndSE()
		{
		}

		protected void PlayHpPotionEffect()
		{
		}

		public void PlaySpPotionEffect()
		{
		}

		protected virtual void PlayHitEffect(CharacterBase owner, Vector3 hitPos, Quaternion rot, bool isCritical, bool isKiller, bool isTolerance, bool isTorpedo, bool isPenetrateShield, CollisionHitAttribute hitAttr, string additionalAttackEffect = "")
		{
		}

		protected virtual void PlayHitFontEffect(CharacterBase owner, string fontEffectName, Vector3 hitPos)
		{
		}

		protected virtual void PlayDamageSE(CharacterBase owner, int actionId, Vector3 hitPos, bool isCritical, bool isLethal)
		{
		}

		protected void PlayDamageSE(Vector3 hitPos, bool isCritical, CharacterBase damagedChara)
		{
		}

		protected virtual void PlayHitSE(int actionId, Vector3 hitPos, bool isCritical, bool isLethal, CharacterBase damagedChara)
		{
		}

		private void PlayDamageCameraShake(CharacterBase owner, CollisionHitAttribute hitAttr, bool isCritical, DamageReaction reaction)
		{
		}

		protected virtual void PlayHitCameraShake(CameraController.ShakeType shakeType)
		{
		}

		public void ShowDamageUI(CharacterBase attacker, int damage, Vector3 hitPos, bool isCritical, float pureElementRate, float delaySec, int splitDmgNum = 0, bool isSelf = false, AbnormalStatusType abnormalStatusType = AbnormalStatusType.NONE, CharacterBuffType buffType = CharacterBuffType.None, int splitDmgNum2 = 0, bool isSkill = false, [Optional] Dictionary<CharacterBase, int> slipDamageOwners, [Optional] CharacterBase extraDamageOwner, int buffIconId = 0, bool isDebuffExtraDamage = false, [Optional] CharacterBase additionAttackFrom, bool isAdditionAttackDamage = false, bool isQuestSKill = false, bool isSubstitudeDamage = false)
		{
		}

		protected virtual bool IsDamageReaction(CollisionHitAttribute attr, int damage)
		{
			return default(bool);
		}

		protected virtual DamageReaction CheckDamageReaction(CollisionHitAttribute attr, int damage)
		{
			return default(DamageReaction);
		}

		private DamageReaction CheckDamageReaction(CollisionHitAttribute attr)
		{
			return default(DamageReaction);
		}

		protected virtual int CheckOverwhelm(int attack)
		{
			return default(int);
		}

		protected virtual int CheckParameterDisparity()
		{
			return default(int);
		}

		private bool IsDamagedFromEnemyPlayerInBattle(CollisionHitAttribute attr)
		{
			return default(bool);
		}

		protected DamageReaction SetupDamageAction(CollisionHitAttribute attr, Vector3 collisionPos, int damage)
		{
			return default(DamageReaction);
		}

		private bool SetupDamageActionCommon(CollisionHitAttribute attr, Vector3 collisionPos)
		{
			return default(bool);
		}

		private void SetupDamageActionNormal(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		private void SetupDamageActionBlastUp(CollisionHitAttribute attr, Vector3 collisionPos, DamageReaction reaction)
		{
		}

		private void SetupDamageActionBlastDown(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		private void SetupDamageActionNoReaction(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		private void SetupDamageActionSuperArmor(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		private void SetupDamageActionSuperArmorBreak(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		private void SetupDamageActionFreeze(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		protected virtual void SetupExternalMove(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		protected virtual void SetupSuperArmorBreakMove(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		protected virtual void ActivateGrantedBuff(CollisionHitAttribute attr)
		{
		}

		public static void VisitActivateGrantedBuff(CollisionHitAttribute attr, Action<CollisionHitAttribute, int> callback)
		{
		}

		private static void VisitGrantedBuff(List<CharacterBuff.GrantData> list, CollisionHitAttribute attr, Action<CollisionHitAttribute, int> callback)
		{
		}

		private static void VisitGrantedBuff(AbilityTargetAction targetAction, CollisionHitAttribute attr, Action<CollisionHitAttribute, int> callback)
		{
		}

		public virtual ApplyAbnormalStatusResult CheckAbnormalStatus(CollisionHitAttribute attr, int damage, DamageReaction reaction)
		{
			return default(ApplyAbnormalStatusResult);
		}

		private ApplyAbnormalStatusResult ActivateGrantedAbnormalStatus(CollisionHitAttribute attr, int damage, DamageReaction reaction)
		{
			return default(ApplyAbnormalStatusResult);
		}

		private ApplyAbnormalStatusResult ApplyGrantedAbnormalStatus(CollisionHitAttribute attr, List<CharacterBuff.GrantData> list, int damage, DamageReaction reaction)
		{
			return default(ApplyAbnormalStatusResult);
		}

		private ApplyAbnormalStatusResult ApplyAbnormalStatus(CollisionHitAttribute attr, int conditionId, int damage, DamageReaction reaction)
		{
			return default(ApplyAbnormalStatusResult);
		}

		protected virtual ApplyAbnormalStatusResult SetAbnormalStatus(CollisionHitAttribute attr, int conditionId, int damage, DamageReaction reaction)
		{
			return default(ApplyAbnormalStatusResult);
		}

		private ApplyAbnormalStatusResult SetAbnormalSwoon(CollisionHitAttribute attr, int conditionId, int damage, DamageReaction reaction, AbnormalStatusProbabilityResult probability)
		{
			return default(ApplyAbnormalStatusResult);
		}

		private ApplyAbnormalStatusResult SetAbnormalSleep(CollisionHitAttribute attr, int conditionId, int damage, DamageReaction reaction, AbnormalStatusProbabilityResult probability)
		{
			return default(ApplyAbnormalStatusResult);
		}

		private ApplyAbnormalStatusResult RecoveryAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement ace, int conditionId)
		{
			return default(ApplyAbnormalStatusResult);
		}

		private bool IsRecoveryAbnormalStatus(int conditionId)
		{
			return default(bool);
		}

		public virtual void ResistUpAbnormalStatus(int type)
		{
		}

		private void ReleaseAbnormalKillerState(CollisionHitAttribute attr)
		{
		}

		private void ReserveAbnormalStatus(CollisionHitAttribute hitAttr, ActionConditionElement ace)
		{
		}

		public bool RunAbnormalStatusAction()
		{
			return default(bool);
		}

		private bool ReleaseAbnormalStatus(AbnormalStatusType type)
		{
			return default(bool);
		}

		private void ReleaseAbnormalStatus(int damage)
		{
		}

		public bool HasAbnormalStatus(AbnormalStatusType type, bool noneIsInvalid = false)
		{
			return default(bool);
		}

		public bool HasDebuff(CharacterBuff.ActionDefDebuff debuffType, int slipHpGroupId = -1)
		{
			return default(bool);
		}

		public void Idle()
		{
		}

		public void Guard()
		{
		}

		public virtual void Damaged(float motionTimeScale = 1f)
		{
		}

		protected virtual void Freeze()
		{
		}

		public virtual bool CheckParalysis(CharacterBase attacker, int slipDamage)
		{
			return default(bool);
		}

		protected virtual bool Paralysis(int slipDamage, bool isFollower)
		{
			return default(bool);
		}

		protected virtual void Swoon()
		{
		}

		protected virtual void Sleep()
		{
		}

		public void Bind(CharacterBase bindOwner, bool change_state = false, bool freeze = true, bool ground = false, int invincible = 0)
		{
		}

		public void BindForGimmick(DungeonObjectStatus bindOwner, bool change_state = false, bool freeze = true)
		{
		}

		public void BlastUp(float gravity, float angle, float height, DamageReaction reaction, CharacterBase attacker, bool disallowRecovery = false)
		{
		}

		public void BlastDown(float gravity, float angle, float height)
		{
		}

		public void BlastSp(float gravity, float angle, float height)
		{
		}

		private void Fall()
		{
		}

		public void Fallout(CharacterBase from)
		{
		}

		public virtual void PlayFallMotion()
		{
		}

		public virtual void PlayLandingMotion()
		{
		}

		public virtual void PlayIdleMotion()
		{
		}

		public void ControlDead()
		{
		}

		protected virtual void OnDead(bool isPlayMotion, bool isRestoreMotion, CollisionHitAttribute hitAttr)
		{
		}

		public virtual void Dead(bool isPlayMotion = true, bool isRestoreMotion = false, [Optional] CollisionHitAttribute hitAttr)
		{
		}

		public virtual void SuddenDeath(DeadReason reason = DeadReason.None)
		{
		}

		public virtual void ForcedDead(bool isRegistLastDead = true, bool isShowRareDefeat = true, bool isInvolveBossDead = false, DeadReason reason = DeadReason.None)
		{
		}

		public virtual void PlayDeadAction()
		{
		}

		public bool HasDisappearAction()
		{
			return default(bool);
		}

		public void EnterSuppression()
		{
		}

		public void LeaveSuppression()
		{
		}

		public void Carry(CharacterBase carriedChara)
		{
		}

		public void Carried(CharacterBase carryChara)
		{
		}

		public void Throw()
		{
		}

		public void Torpedo(CharacterBase throwChara)
		{
		}

		public bool CanAcceptThrowCarry()
		{
			return default(bool);
		}

		public void ReleaseCarried()
		{
		}

		public void SetZeroHeight()
		{
		}

		public void ResetPitchRoll()
		{
		}

		public void SetQuestClear()
		{
		}

		public void SetQuestFailure()
		{
		}

		public void RestorePrevHpAs(float value)
		{
		}

		public virtual void InitState(bool isContinue = false, float hpRatio = 1f)
		{
		}

		public void Continue()
		{
		}

		public float StartReborn(float baseRebornHpRatio, bool withSpCharge = false)
		{
			return default(float);
		}

		private IEnumerator RebornCoroutine()
		{
			return null;
		}

		public virtual void Revive(bool production = true, bool hasInvincibleTime = true, bool isReborn = false, float respawnInvincibleSec = 0f, float hpRatio = 1f)
		{
		}

		public void SetReviveState()
		{
		}

		public bool HasReviveAction()
		{
			return default(bool);
		}

		public void ReserverIn()
		{
		}

		public void SetEventMode(CharacterStates eventState, FaceType faceType = FaceType.NORMAL)
		{
		}

		public void Event(FaceType faceType = FaceType.NORMAL)
		{
		}

		public void EventMove()
		{
		}

		public void StartAreaChange()
		{
		}

		public void EndAreaChange()
		{
		}

		public void PrevState()
		{
		}

		public void StopStatusEffectForLowQualitySetting()
		{
		}

		public virtual void StopStatusEffect()
		{
		}

		public void RestoreStatusEffectForLowQualitySetting()
		{
		}

		public virtual void RestoreStatusEffect()
		{
		}

		public static Transform FindNode(Transform current, string name)
		{
			return null;
		}

		public bool IsDown()
		{
			return default(bool);
		}

		public bool IsStopAbnormal()
		{
			return default(bool);
		}

		public bool IsFreeze()
		{
			return default(bool);
		}

		public bool IsParalysis()
		{
			return default(bool);
		}

		public ActionBlastBase GetBlastAction()
		{
			return null;
		}

		public bool IsFallingOnCarriedState()
		{
			return default(bool);
		}

		public virtual bool EnableReduceFreezeTime(CollisionHitAttribute attr)
		{
			return default(bool);
		}

		private bool IsPartyAttackForUnfreeze(CollisionHitAttribute attr)
		{
			return default(bool);
		}

		public bool IsSwoon()
		{
			return default(bool);
		}

		public bool IsSleep()
		{
			return default(bool);
		}

		public bool IsDisabledControlAbnormalStatus()
		{
			return default(bool);
		}

		public bool IsPartyAttackForUnDoll(CollisionHitAttribute attr)
		{
			return default(bool);
		}

		public bool IsBlastState()
		{
			return default(bool);
		}

		public bool IsAerialState()
		{
			return default(bool);
		}

		private bool IsAerial()
		{
			return default(bool);
		}

		public bool IsDeadEnd()
		{
			return default(bool);
		}

		public virtual void RecoveryHpPotion(int value, bool dispUi, bool dispEffect, bool forcibly)
		{
		}

		public void RecoverySpPotion(int value, int idx)
		{
		}

		public void RecoveryHp(int value)
		{
		}

		public void RecoverySpOnHit(int value, float originValue, float rate)
		{
		}

		private int ApplySpGainCut(int value, int idx)
		{
			return default(int);
		}

		public void RecoverySp(int value, int idx, bool withSE = true)
		{
		}

		public bool IsSkillAvailable(int idx)
		{
			return default(bool);
		}

		public bool IsSpAvailable(int idx)
		{
			return default(bool);
		}

		public bool IsSpFull(int idx)
		{
			return default(bool);
		}

		public float GetSpRate(int idx)
		{
			return default(float);
		}

		private bool IsNotSpShare(PlayerCharacter player, int idx)
		{
			return default(bool);
		}

		public int GetMaxSp(int idx)
		{
			return default(int);
		}

		public int GetConsumeSp(int idx)
		{
			return default(int);
		}

		public int GetSp(int idx)
		{
			return default(int);
		}

		public int GetPrevSp(int idx)
		{
			return default(int);
		}

		public void SetSp(int value, int idx, bool immediate = false)
		{
		}

		public EffectObject PlayEffect(string effectName, GameObject go, int trig = 0)
		{
			return null;
		}

		public EffectObject PlayEffect(string effectName, GameObject go, Vector3 offset, int trig = 0)
		{
			return null;
		}

		public void DelayEffect(string effectName, float delayTime, string nodeName, Vector3 offset, [Optional] string ctrl_key)
		{
		}

		private IEnumerator CoDelayEffect(string effectName, float delayTime, string nodeName, Vector3 offset, string ctrl_key)
		{
			return null;
		}

		public void CancelAllDelayEffect()
		{
		}

		public virtual void PlayDashEffect()
		{
		}

		private void PlayPutUpEffect()
		{
		}

		public void ForceStopActionEffect(bool isAnimatableObjectOnly = false)
		{
		}

		public bool IsFinishedActionMove()
		{
			return default(bool);
		}

		public ActionContainer GetActionContainer()
		{
			return null;
		}

		public virtual void ClearColor()
		{
		}

		public bool IsColorActive()
		{
			return default(bool);
		}

		public virtual void SetColorState(CharacterColor.State state, bool forwardToParts = true)
		{
		}

		public virtual void FinishColorState(CharacterColor.State state, bool forwardToParts = true)
		{
		}

		public void SetColorSmooth(ColorParam toBasicColor, float smoothSec, bool forwardToParts = true)
		{
		}

		public void StopEffectOnChangeCharacter()
		{
		}

		public virtual void AddStockBullet(StockBulletObject bullet)
		{
		}

		public virtual List<StockBulletObject> GetStockBullets()
		{
			return null;
		}

		public virtual void RemoveStockBullet(StockBulletObject bullet)
		{
		}

		public virtual void RemoveStockBulletAll()
		{
		}

		public virtual void RestartStockBullet(bool refreshBulletState = true)
		{
		}

		protected override void OnDisable()
		{
		}

		public virtual void NotifyLeaveActor(int actorId)
		{
		}

		public virtual void OnEntry()
		{
		}

		public virtual string GetFacePath()
		{
			return null;
		}

		public virtual int GetFaceID()
		{
			return default(int);
		}

		private bool CanFollowerAvoidAction()
		{
			return default(bool);
		}

		public virtual void StartupChargeMarker()
		{
		}

		public virtual void FinishChargeMarker(bool isAttack, bool isGuard)
		{
		}

		public virtual void ForceCompleteChargeMarker()
		{
		}

		public virtual bool IsAttackHitSender(AttackHit attackHit)
		{
			return default(bool);
		}

		public void SetHpZero()
		{
		}

		public bool IsExistWallBetweenTarget(CommonObjectStatus target, [Optional] Collider ignoreCollider)
		{
			return default(bool);
		}

		public static bool IsExistWallBetweenTarget(Vector3 fromPos, CommonObjectStatus target, [Optional] Collider ignoreCollider)
		{
			return default(bool);
		}

		public void PlaySwitchingTexture(int in_idx, int out_idx, float duration, bool initializeIfNeed = false)
		{
		}

		public bool CanPlaySwitchingTexture()
		{
			return default(bool);
		}

		public virtual void OnCharacterSpecialState(CharacterSpecialState state)
		{
		}

		public virtual void RefreshDashSpeedRatio()
		{
		}

		public virtual void InitUniqueGimmick(bool isContinue)
		{
		}

		public bool IsTransformDontEscapeMarkerDragon()
		{
			return default(bool);
		}

		public void AddHidingLevel(int value)
		{
		}

		public void AddSkillCounter(int skillId)
		{
		}

		public bool IsModelVisible()
		{
			return default(bool);
		}

		public void SetModelVisibility(bool visibility, bool force = false)
		{
		}

		public void SetModelVisibilityForSkillCutInCamera(bool visibility)
		{
		}

		public void RequestResetChangeMesh()
		{
		}

		public void SendDodge(CharacterBase attacker, bool showDodge = false)
		{
		}

		public void OnRecieveDodge(Dodge recvEvent)
		{
		}

		public void OnReceiveTriggerAbility(TriggerAbility recvEvent, CharacterBase from, CharacterBase target)
		{
		}

		public void SetVisibleParts(string partsName, bool flag)
		{
		}

		public virtual float GetOriginalDragonTime()
		{
			return default(float);
		}

		private void WakeOnCollided(CharacterBase target)
		{
		}

		public void UpdateLastWakeOnCollidedTime()
		{
		}

		public float GetElapsedSecFromLastWakeOnCollided()
		{
			return default(float);
		}
	}
}
