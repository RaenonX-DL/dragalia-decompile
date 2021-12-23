using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.ActionData;
using Gluon.Dungeon.Gimmick;
using Gluon.Event;
using Gluon.GraphicParameter;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class EnemyCharacter : CharacterBase
	{
		private enum BarrierState
		{
			BarrierState_OFF,
			BarrierState_CARRIAGE,
			BarrierState_ON
		}

		public enum DamageHateType
		{
			Direct,
			Indirect,
			Term
		}

		public class CallMinionInfo
		{
			public EnemyCharacter _caller;

			public string _label;

			public CallMinionData.BaseType _base;

			public Vector3 _position;

			public bool _editDirection;

			public Quaternion _rotation;

			public float _areaRadius;

			public int _setupHP;

			public bool _isMirage;

			public bool _byGMAI;

			public uint _randomSeed;

			public void Reset()
			{
			}

			public void CopyTo(CallMinionInfo dest)
			{
			}
		}

		public enum UniqueActionId
		{
			InitialAction,
			HomeAction,
			CounterAction,
			BarrierAction,
			RageAction,
			ShiftAction,
			GetupAction,
			UnusualDead,
			UniqueDeadAction,
			BreakAction,
			UnusualBreak,
			DissolutionAction,
			AlternativeAction
		}

		private EnemyActionSetElement _actionSetElm;

		private EnemyActionSetElement _actionSetElm_Fire;

		private EnemyActionSetElement _actionSetElm_Water;

		private EnemyActionSetElement _actionSetElm_Wind;

		private EnemyActionSetElement _actionSetElm_Light;

		private EnemyActionSetElement _actionSetElm_Dark;

		private bool _hasSwitchedElement;

		private Action<CharacterBase> _searchEvent;

		private SphereCollider _searchCollider;

		private EnemyGuardMultiPlayService _guardMultiPlayService;

		[SerializeField]
		[ReadOnly]
		protected MaterialPropertyRenderer breakMaterialPropertyData;

		private const float BARRIER_DURATION = 30f;

		private const int BARRIER_HIT_TIMES = 25;

		private const int BARRIER_WANING_TIMES = 6;

		private const float BARRIER_INTERVAL_TIME = 8f;

		private bool _isBarrierBroken;

		private const float BARRIER_BREAK_KNOCKBACK_RATE = 1.5f;

		private EnemyBarrierReaction _reactBarrier;

		private static CharacterSpecialState _tmpChangeBossState;

		private static BarrieredHit _tmpBarrieredHit;

		private bool _isBarrierMode;

		private BarrierState _barrierState;

		private bool _isBoost;

		private CtrlOverdrive _ctrlOverdrive;

		private bool _isBreakMode;

		public const int PARTS_MAX = 4;

		protected EnemyCharacter[] _partsCharacters;

		public List<EnemyCharacter> _subCharacters;

		public EnemyCharacter _centerCharacter;

		public EnemyWeakCtrl _setentaiseiWeakCtrl;

		public List<EnemyCharacter> _mirageCharacters;

		private bool _wasLeaveEff;

		private EnemyTalk _talk;

		private int[] _damageHateCounter;

		private CharacterBase _deadHitAttrOwner;

		private int _deadHitAttrSkillId;

		private bool playDeadHitEffect;

		private bool isDeadDamageProcessed;

		private bool _isShowRareDefeat;

		private const int CoinDropIconLimitNum = 20;

		private const int ManaDropIconLimitNum = 20;

		private DropItemUI.Parameter[] _dropItems;

		public bool _hideDropItemIcon;

		public bool isIgnoreBossUI;

		private bool _abnormalSwitch;

		private List<EnemyCtrl> _tmpEnemyCtrlList;

		public Action onEntryAction;

		public List<EnemyUniqueCtrl> _listUniqueCtrl;

		private List<DmodeDungeonDropItemParam> dmodeDropItems;

		private IEnumerator coBreakMode;

		private IEnumerator coBarrierMode;

		public bool generatedInPool
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

		public bool activeFromPool
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

		public EnemyParamElement ParamElm
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

		private DmodeEnemyParamElement DmodeParamElm
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

		public EnemyDataElement DataElm
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

		public EnemyActionSetElement ActionSetElm => null;

		public EnemyActionSetElement ActionSetElmBoost
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

		public bool hasSwitchedElement
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public EnemyCtrl enemyCtrl
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

		public int enemyIdx
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

		public SphereCollider searchCollider => null;

		public override int IsHitCollisionOnCenter => default(int);

		public EnemyGuardMultiPlayService GuardMultiPlayService => null;

		public List<EntityData> outsideEntityDatas
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

		public override int level => default(int);

		public override float defense => default(float);

		public override CharacterBuff buffCtrl => null;

		public override CharacterAbnormalStatus abnormalStatusForDamageCalc => null;

		public override DamageImmunity damageImmCtrl
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public float barrierInterval
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float barrierHitCount
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string barrierEffName
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

		public string barrierBrokenEffName
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

		public override bool isBarrierMode
		{
			get
			{
				return default(bool);
			}
			protected set
			{
			}
		}

		public bool isBoost
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isParamRegistAbnormalPerfect
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

		public int overwhelmPoint
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

		public int baseOd
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

		public int baseBreak
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

		public CtrlOverdrive ctrlOverdrive => null;

		public override bool isOverdriveMode => default(bool);

		public bool hasOverDrive => default(bool);

		public override bool isBreakMode
		{
			get
			{
				return default(bool);
			}
			protected set
			{
			}
		}

		public bool IsBreakRecovery
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

		public override bool isNoTarget
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public EnemyAbility enemyAbility
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

		public bool hasSlipHpDebuff => default(bool);

		public bool isExistParts => default(bool);

		public int partsCharaNum => default(int);

		public int partsIdx
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

		public EnemyCharacter[] PartsCharacters => null;

		public string partsCharactersMeshName
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

		public bool IsPartsCharacter => default(bool);

		public EnemyCharacter BodyCharacter
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

		public int partsDeadNum
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

		public EnemyCharacter lastDeadParts
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

		public int partsCrashedTimes
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

		public bool isDeleteDeadParts => default(bool);

		public bool isZombieParts
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

		public bool isPartsSelfDef => default(bool);

		public bool IsSub => default(bool);

		public bool IsSeitentaiseiWeak => default(bool);

		public EnemyCharacter GetSeitentaiseiWeak => null;

		public CtrlMultiWeak ctrlMultiWeak
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

		public List<EnemyCharacter> minions
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int isCallMinionTiming
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

		public int callMinionNum
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

		public List<CallMinionInfo> callMinionInfo
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EnemyCharacter summonerCharacter
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

		public bool IsMinion => default(bool);

		public bool isAppearReserved
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

		public List<EnemyCharacter> mirageCharacters => null;

		public EnemyCharacter realCharacter
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

		public bool IsMirage => default(bool);

		public bool isSquadChief
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

		public EnemyCharacter myChief
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

		public float dropDelayTime
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

		public CtrlForm2nd ctrlForm2nd
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

		public bool isForm2nd => default(bool);

		public EnemyCharacter form2ndCharacter
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

		public bool isExistForm2nd => default(bool);

		public bool isShapeShifting
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

		public bool hasShapeShifted
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

		public float rareStayTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public EnemyTalk talk => null;

		public CharacterBase DeadHitAttrOwner => null;

		public int DeadHitAttrSkillId => default(int);

		public bool isForcedDeadNoReaction
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

		public int GeneratorId
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

		public int EnemySerialId => default(int);

		public Vector3 dropPositionOffset
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

		public bool isAiSpecialMode
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

		public Dictionary<int, CharaFaceEyeMotion> eyeFaceTypeDict
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

		public Dictionary<int, CharaFaceMouthMotion> mouthFaceTypeDict
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

		public override WarpRoom.RoomGroup warpRoomGroupId
		{
			get
			{
				return default(WarpRoom.RoomGroup);
			}
			set
			{
			}
		}

		public CtrlBoundaryAction ctrlBoundary
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

		public override bool isActiveBoundaryAction => default(bool);

		public override int sameHitPriority => default(int);

		public DeadReason deadReason
		{
			[CompilerGenerated]
			get
			{
				return default(DeadReason);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override string DebugName => null;

		public bool isDmodeEnemy => default(bool);

		public int dmodeLv
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

		public int dmodeExp => default(int);

		public int dmodePoint => default(int);

		public int dmodeRarePoint => default(int);

		public int dmodeScore => default(int);

		public bool IsReservedLeave
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

		public OrderFromSubData RecoveryOrderFromSubData
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

		public EventActionData RecoveryEventAction
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

		public CommonObjectStatus RecoveryEventActionTarget
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

		public int popCount
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

		public bool useBodyScaleAura
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

		public override string IdleStateName => null;

		public override string WalkStateName => null;

		public bool isCountDownHP => default(bool);

		public override bool IsBoss => default(bool);

		public override bool IsRaidBoss => default(bool);

		public bool IsRare => default(bool);

		public override bool IsStronger => default(bool);

		public bool IsSyncEnemy => default(bool);

		public bool IsGameMaster => default(bool);

		public bool IsProtection => default(bool);

		public bool IsFriend => default(bool);

		public bool IsNetworkSynchronizedEnemy => default(bool);

		public bool isPlayerSide => default(bool);

		public bool isNoActionCharacter => default(bool);

		public DefWarHouseUniqueCtrl defWarHouseUniqueCtrl
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

		public bool IsDefWarHouse => default(bool);

		public SeitentaiseiUniqueCtrl seitentaiseiUniqueCtrl
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

		public int actionId_Initial => default(int);

		public int actionId_Home => default(int);

		public int actionId_Counter => default(int);

		public int actionId_Barrier => default(int);

		public int actionId_Rage => default(int);

		public int actionId_Shift => default(int);

		public int actionId_Getup => default(int);

		public int actionId_UnusualDead => default(int);

		public int actionId_UniqueDead => default(int);

		public int actionId_Break => default(int);

		public int actionId_UnusualBreak => default(int);

		public int actionId_Dissolution => default(int);

		public int actionId_Alternative => default(int);

		public event Action<CollisionHitAttribute, int> _damageEvent
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

		public event Action<EnemyCharacter> _deadEvent
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

		public event Action<EnemyCharacter> _leaveEvent
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

		public event Func<bool, CharacterBase, bool> _fatalEvent
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

		public event Action<CharacterBase> _initStateEvent
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

		public void CreateOverdrive(float baseOD, float baseBreak)
		{
		}

		public EnemyCharacter GetPartsCharacters(int parts_idx)
		{
			return null;
		}

		public EnemyCharacter GetPartsCharacters(string meshName)
		{
			return null;
		}

		public bool IsExistWeakPoint(EnemyCharacter target)
		{
			return default(bool);
		}

		protected override void Awake()
		{
		}

		public override void FastUpdate()
		{
		}

		public override int GetSortingOrderOffset()
		{
			return default(int);
		}

		public EnemyCtrl AddEnemyCtrlComponent()
		{
			return null;
		}

		public static EnemyCharacter Create(int paramId, int enemyIdx = -1, [Optional] CharacterManager charaManager)
		{
			return null;
		}

		public static EnemyCharacter CreateFromEnemyData(int dataId, int level = 1, [Optional] CharacterManager charaManager)
		{
			return null;
		}

		public static void InitializeEnemyCharacterByDataId(int dataId, EnemyCharacter character)
		{
		}

		public void Initialize(int paramId, int idx)
		{
		}

		protected void InitializeByDataId(int dataId)
		{
		}

		protected void LoadActionContainerElements(InGameDef.CharacterType characterType, string groupName)
		{
		}

		private void LoadUniqueEffectSe()
		{
		}

		public override void InitializeRenderState([Optional] Renderer[] setRenderers, [Optional] Func<Renderer, bool> entryRendererFunc, [Optional] Action setInitializeRenderStateFunc)
		{
		}

		protected override void SetupCharacterState()
		{
		}

		public void CreateUI()
		{
		}

		private EnemyCharacter CreateParts(int idx, int paramId, EnemyCharacter parentChara)
		{
			return null;
		}

		private void SetEffectMeshRendererForPartsCharacter(EnemyCharacter parts, GameObject go)
		{
		}

		protected void InitializeParts(int idx, int paramId)
		{
		}

		private void SetPartsLayer()
		{
		}

		public static string GetPartsMeshName(int partsIndex)
		{
			return null;
		}

		public static string GetRenderPartsName(int partsIndex)
		{
			return null;
		}

		public static string GetBrokenPartsMeshName(string standardMeshName)
		{
			return null;
		}

		public bool SetVisiblePartsMesh(int partsIndex, bool visible)
		{
			return default(bool);
		}

		public void AllPartsCharacterRevive()
		{
		}

		private void OnDeadParts()
		{
		}

		private static int GetPartsObjectParam(EnemyParamElement paramElement, int partsIndex)
		{
			return default(int);
		}

		private static EnemyParamElement GetPartsObjectParamElement(EnemyParamElement paramElement, int partsIndex)
		{
			return null;
		}

		public override void OnEntry()
		{
		}

		public IEnumerator CoTalkEntryTiming(float duration)
		{
			return null;
		}

		public IEnumerator CoTalkEntryTiming2()
		{
			return null;
		}

		public override void Revive(bool production = true, bool hasInvincibleTime = true, bool isReborn = false, float respawnInvincibleSec = 0f, float hpRatio = 1f)
		{
		}

		public EnemyCtrl FindNextSubCharacter(int id)
		{
			return null;
		}

		private void UpdateRareStay()
		{
		}

		public override void AddInvincible(InvincibleControl.Type type, int level, float sec, int uid = 0)
		{
		}

		public override void RemoveInvincible(InvincibleControl.Type type, int uid = 0)
		{
		}

		public override Vector3 EffectScale()
		{
			return default(Vector3);
		}

		public override Vector3 AuraScale(bool isDynamicScale = false)
		{
			return default(Vector3);
		}

		public override Vector4 EmotionIconParam()
		{
			return default(Vector4);
		}

		public override float ShadowSize()
		{
			return default(float);
		}

		protected void SetStatus()
		{
		}

		private void SetDmodeLevelingParameter()
		{
		}

		public bool IsRunningExtraAction()
		{
			return default(bool);
		}

		public bool IsRunningForcedAnnihilationAction()
		{
			return default(bool);
		}

		public override void PlayIdleMotion()
		{
		}

		public override void InitState(bool isContinue = false, float hpRatio = 1f)
		{
		}

		public override void InitUniqueGimmick(bool isContinue)
		{
		}

		public void InitDamageHateCounter()
		{
		}

		private void UpdateDamageHateCounter(CharacterBase owner)
		{
		}

		public int GetDamageHateCounter(DamageHateType type)
		{
			return default(int);
		}

		public override CharacterBase GetCurrentChara()
		{
			return null;
		}

		protected override MaterialPropertyData GetMaterialPropertyBlockFromName(string partsName)
		{
			return null;
		}

		public override void SetMaterialPropertyBlock()
		{
		}

		private void ShowBossGaugeUI()
		{
		}

		public void ShowBossPartGaugeUI(bool isChangeBoss)
		{
		}

		public void PlayUIOnProtectionDamage(CollisionHitAttribute hitAttr, int damage)
		{
		}

		public override TribeType GetTribe()
		{
			return default(TribeType);
		}

		protected override bool IsResistBlast()
		{
			return default(bool);
		}

		protected override bool IsHitFlash()
		{
			return default(bool);
		}

		protected override bool IsTurnToDamageDir(DamageReaction reaction)
		{
			return default(bool);
		}

		public override void Damaged(float motionTimeScale = 1f)
		{
		}

		public override void BuildDamage(int damage, CollisionHitAttribute hitAttr, Vector3 hitPos, CharacterDamageIntermediate outIntermediate)
		{
		}

		public override void ApplyDamage(CharacterDamageIntermediate intermediate)
		{
		}

		private bool ApplyReduceHp(int damage, int skillId, CharacterBase damageOwner, bool isQuestSkill = false)
		{
			return default(bool);
		}

		public override void ApplySlipDamage(CharacterBase attacker, int damage, bool isFollower, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int buffIconId, [Optional] Dictionary<CharacterBase, int> froms)
		{
		}

		public void ApplyRemoveBuffExtraDamage(int damage, CharacterBase from, int actionConditionId, int actionId, string hitAttributeLabel, int buffExplosionHitId, bool isHostSync, bool isPropagation)
		{
		}

		public void OnReceiveRemoveBuffExtraDamage(DebuffExtraDamage recvEvent)
		{
		}

		private void ApplyRemoveBuffExtraDamage(CharacterBase attacker, int damage, int actionConditionId, int actionId, string hitAttrLabel, int buffExplosionHitId = 0, bool isPropagation = false, float extraElementRate = 0f)
		{
		}

		public EnemyCharacter GetDamagePropagationParentEnemy()
		{
			return null;
		}

		public override void DrainHp(CollisionHitAttribute attr)
		{
		}

		public bool SetSmash(bool excludeAddedIdx)
		{
			return default(bool);
		}

		public void GuaranteeDeadDamageIfNeed()
		{
		}

		private void DeadDamage([Optional] CharacterBase attacker)
		{
		}

		public override bool OnCollided(CollisionHitAttribute hitAttr, HitProduction hitProduction = HitProduction.All, int followerAvoid = 0)
		{
			return default(bool);
		}

		public override void OnDamaged(AttackHit attackHit, CollisionHitAttribute hitAttr, CharacterBase from)
		{
		}

		public override void Dead(bool isPlayMotion = true, bool isRestoreMotion = false, [Optional] CollisionHitAttribute hitAttr)
		{
		}

		protected override void OnDead(bool isPlayMotion, bool isRestoreMotion, CollisionHitAttribute hitAttr)
		{
		}

		public override void SuddenDeath(DeadReason reason = DeadReason.None)
		{
		}

		public override void ForcedDead(bool isRegistLastDead = true, bool isShowRareDefeat = true, bool isInvolveBossDead = false, DeadReason reason = DeadReason.ForcedDead)
		{
		}

		private void PreOnLeave()
		{
		}

		private void PostOnLeave()
		{
		}

		public void Leave()
		{
		}

		public override void PlayDeadAction()
		{
		}

		public void LeaveWeakPoint()
		{
		}

		public override void AddAction(int actionId, int skillId = 0, [Optional] CommonObjectStatus target, [Optional] Action<ActionBase> argActionEndCallback, bool viaAttackState = false)
		{
		}

		private int CalcDamageToOverdirve(int hp_dmg, CollisionHitAttribute hitAttr)
		{
			return default(int);
		}

		public override void StartBreak()
		{
		}

		public IEnumerator CoBreakMode(float duration)
		{
			return null;
		}

		public override void BreakFinish()
		{
		}

		public override void CutoffBreak()
		{
		}

		public override bool RunningBarrier(CollisionHitAttribute data)
		{
			return default(bool);
		}

		public bool CountBarrierHit(bool isAdditionAttack)
		{
			return default(bool);
		}

		public void StartBarrier(bool carriage, bool fromNetwork = false)
		{
		}

		private IEnumerator CoBarrierMode(bool carriage, bool fromNetwork)
		{
			return null;
		}

		private void UpdateBarrier()
		{
		}

		public void CutoffBarrier()
		{
		}

		private void FinishBarrier()
		{
		}

		private void SendBarrier()
		{
		}

		private void SendBarrieredHit(int characterId, int actionId, Vector3 hitPos, bool isFromAdditionalAttack)
		{
		}

		private void PlayBarrierBrokenEffect()
		{
		}

		protected override DamageReaction CheckDamageReaction(CollisionHitAttribute attr, int damage)
		{
			return default(DamageReaction);
		}

		protected override bool IsDamageReaction(CollisionHitAttribute attr, int damage)
		{
			return default(bool);
		}

		protected override int CheckOverwhelm(int attack)
		{
			return default(int);
		}

		protected override int CheckParameterDisparity()
		{
			return default(int);
		}

		public override void ResetSuperArmorLevel()
		{
		}

		public void SetAction(int acitonId, CharacterStates state_, bool firstAction = false, [Optional] CommonObjectStatus target, bool ignoreSync = false, int boundaryDataId = 0)
		{
		}

		public override int GetParalysisActionId()
		{
			return default(int);
		}

		public override bool IsCounterAction(Vector3 attackDir, CollisionHitAttribute data)
		{
			return default(bool);
		}

		public void RunCounterAction(CharacterBase targetChara)
		{
		}

		public void SetSearchDiscoverEvent(Action<CharacterBase> searchResponse, float searchRange)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public void ReactionSearch()
		{
		}

		protected override void SetupExternalMove(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		protected override void SetupSuperArmorBreakMove(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		protected override void PlayHitEffect(CharacterBase owner, Vector3 hitPos, Quaternion rot, bool isCritical, bool isKiller, bool isTolerance, bool isTorpedo, bool isPenetrateShield, CollisionHitAttribute hitAttr, string additionalAttackEffect = "")
		{
		}

		protected override void PlayHitFontEffect(CharacterBase owner, string fontEffectName, Vector3 hitPos)
		{
		}

		protected override void PlayDamageSE(CharacterBase owner, int actionId, Vector3 hitPos, bool isCritical, bool isLethal)
		{
		}

		protected override AbnormalStatusProbabilityResult GetAbnormalStatusProbability(CollisionHitAttribute attr, int type, float probability)
		{
			return default(AbnormalStatusProbabilityResult);
		}

		public void InitAbnormalStatus()
		{
		}

		public void SetupAbnormalStatus_ForDmodeLevel()
		{
		}

		public override void ResistUpAbnormalStatus(int type)
		{
		}

		public bool IsPerfectResistAbnormalStatus(int type)
		{
			return default(bool);
		}

		public bool HasAbnormalStatusReferToBody(AbnormalStatusType type, bool noneIsInvalid = false)
		{
			return default(bool);
		}

		protected override ApplyAbnormalStatusResult SetAbnormalStatus(CollisionHitAttribute attr, int conditionId, int damage, DamageReaction reaction)
		{
			return default(ApplyAbnormalStatusResult);
		}

		public void DropDp(CharacterBase attacker, float prevHpRate, int additionRecoveryDp)
		{
		}

		public void DropDp(CharacterBase attacker, int dp)
		{
		}

		public void DropDp(List<CharacterBase> attackers, float prevHpRate)
		{
		}

		protected override bool DropDp(float prevHpRate, CharacterBase triggerChara, float coef)
		{
			return default(bool);
		}

		private void DropDp(int dp, bool isTransformed, CharacterBase triggerChara, float coef, int limitNum = -1)
		{
		}

		private void DropDpHpRate(int dp, float prevHpRate, bool isTransformed, CharacterBase triggerChara, float coef)
		{
		}

		private void DropSp(int value, CharacterBase attacker)
		{
		}

		public override void PlayDefaultMoveAnimationForEventRecevier()
		{
		}

		private void SetupFaceTypeDict()
		{
		}

		public override void SetFaceType(FaceType type, bool force = false)
		{
		}

		public override void SetModelType(ModelType type)
		{
		}

		public override void SetColorState(CharacterColor.State state, bool forwardToParts = true)
		{
		}

		public override void ClearColor()
		{
		}

		public override void FinishColorState(CharacterColor.State state, bool forwardToParts = true)
		{
		}

		public override void SetCharaColor()
		{
		}

		protected override void DamageHitFlash()
		{
		}

		public override bool IsAttackHitSender(AttackHit attackHit)
		{
			return default(bool);
		}

		public override void OnCharacterSpecialState(CharacterSpecialState state)
		{
		}

		public void OnBarrieredHit(BarrieredHit barrieredHit)
		{
		}

		public static int GetQuesetDifficulty()
		{
			return default(int);
		}

		public static Tuple<int, EnemyActionHitAttributeElement> GetHitAttributeForDifficulty(string label)
		{
			return null;
		}

		public static string GetElementalSkillName(ElementalType element, EnemyActionElement action)
		{
			return null;
		}

		public override void StopStatusEffect()
		{
		}

		public override void RestoreStatusEffect()
		{
		}

		public override void IgnoreCollide(CharacterBase target, bool isIgnore = true)
		{
		}

		public void SetupForm2nd(EnemyCharacter orignal)
		{
		}

		public void ShiftIntoForm2nd()
		{
		}

		public void TakeOverStatus(EnemyCharacter src, bool restoreEff = true)
		{
		}

		protected override void CheckStopAbnormalEventAction()
		{
		}

		public T AddUniqueCtrl<T>() where T : EnemyUniqueCtrl
		{
			return null;
		}

		public T GetUniqueCtrl<T>() where T : EnemyUniqueCtrl
		{
			return null;
		}

		public float GetAtkFromUniqueCtrl()
		{
			return default(float);
		}

		public float GetDefFromUniqueCtrl()
		{
			return default(float);
		}

		public IEnumerator CoDropRewardDelay(float delay)
		{
			return null;
		}

		private void DropReward()
		{
		}

		private void IncrementItemRedNum(DropItemUI.Parameter item, int redNum, int redRarity)
		{
		}

		private void UpdateTotalDropData()
		{
		}

		public void RunInitialAction()
		{
		}

		public int GetUniqueAction(UniqueActionId type)
		{
			return default(int);
		}

		private EnemyActionSetElement GetElementalActionSet()
		{
			return null;
		}

		private void SetExpandedActionSet()
		{
		}

		private void LoadExpandedActionSet(ref List<int> skills)
		{
		}

		private void PickupActionFromActionSet(EnemyActionSetElement actionset, ref List<int> skills)
		{
		}

		protected override void PreChangeState(CharacterState characterState)
		{
		}

		protected override void PostChangeState(CharacterState characterState)
		{
		}

		public override bool IsTimeStopBuffAbnormalStatusDragonTimer()
		{
			return default(bool);
		}

		public void OnReceiveActionPartsNotifyEvent(ActionPartsNotifyEvent recvEvent)
		{
		}

		protected override void ActivateGrantedBuff(CollisionHitAttribute attr)
		{
		}

		public bool CanTargetFromPlayerAI(PlayerCharacter chara)
		{
			return default(bool);
		}
	}
}
