/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Dungeon.Gimmick;
using Gluon.Event;
using Gluon.GraphicParameter;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyCharacter : CharacterBase
	{
		// Fields
		[CompilerGenerated]
		private bool _generatedInPool_k__BackingField;
		[CompilerGenerated]
		private bool _activeFromPool_k__BackingField;
		[CompilerGenerated]
		private EnemyParamElement _ParamElm_k__BackingField;
		[CompilerGenerated]
		private EnemyDataElement _DataElm_k__BackingField;
		private EnemyActionSetElement _actionSetElm;
		[CompilerGenerated]
		private EnemyActionSetElement _ActionSetElmBoost_k__BackingField;
		private EnemyActionSetElement _actionSetElm_Fire;
		private EnemyActionSetElement _actionSetElm_Water;
		private EnemyActionSetElement _actionSetElm_Wind;
		private EnemyActionSetElement _actionSetElm_Light;
		private EnemyActionSetElement _actionSetElm_Dark;
		private bool _hasSwitchedElement;
		[CompilerGenerated]
		private EnemyCtrl _enemyCtrl_k__BackingField;
		private Action<CharacterBase> _searchEvent;
		private SphereCollider _searchCollider;
		private EnemyGuardMultiPlayService _guardMultiPlayService;
		[CompilerGenerated]
		private List<EntityData> _outsideEntityDatas_k__BackingField;
		[ReadOnly]
		[SerializeField]
		protected MaterialPropertyRenderer breakMaterialPropertyData;
		private const float BARRIER_DURATION = 30f;
		private const int BARRIER_HIT_TIMES = 25;
		private const int BARRIER_WANING_TIMES = 6;
		private const float BARRIER_INTERVAL_TIME = 8f;
		[CompilerGenerated]
		private float _barrierInterval_k__BackingField;
		[CompilerGenerated]
		private float _barrierHitCount_k__BackingField;
		private bool _isBarrierBroken;
		private const float BARRIER_BREAK_KNOCKBACK_RATE = 1.5f;
		private EnemyBarrierReaction _reactBarrier;
		[CompilerGenerated]
		private string _barrierEffName_k__BackingField;
		[CompilerGenerated]
		private string _barrierBrokenEffName_k__BackingField;
		private static CharacterSpecialState _tmpChangeBossState;
		private static BarrieredHit _tmpBarrieredHit;
		private bool _isBarrierMode;
		private BarrierState _barrierState;
		private bool _isBoost;
		private CtrlOverdrive _ctrlOverdrive;
		private bool _isBreakMode;
		[CompilerGenerated]
		private bool _IsBreakRecovery_k__BackingField;
		[CompilerGenerated]
		private Gluon.EnemyAbility _enemyAbility_k__BackingField;
		public const int PARTS_MAX = 4;
		[CompilerGenerated]
		private int _partsIdx_k__BackingField;
		protected EnemyCharacter[] _partsCharacters;
		[CompilerGenerated]
		private EnemyCharacter _BodyCharacter_k__BackingField;
		[CompilerGenerated]
		private int _partsDeadNum_k__BackingField;
		[CompilerGenerated]
		private EnemyCharacter _lastDeadParts_k__BackingField;
		[CompilerGenerated]
		private int _partsCrashedTimes_k__BackingField;
		[CompilerGenerated]
		private bool _isZombieParts_k__BackingField;
		public List<EnemyCharacter> _subCharacters;
		public EnemyCharacter _centerCharacter;
		public EnemyWeakCtrl _setentaiseiWeakCtrl;
		[CompilerGenerated]
		private CtrlMultiWeak _ctrlMultiWeak_k__BackingField;
		[CompilerGenerated]
		private readonly List<EnemyCharacter> _minions_k__BackingField;
		[CompilerGenerated]
		private int _isCallMinionTiming_k__BackingField;
		[CompilerGenerated]
		private int _callMinionNum_k__BackingField;
		[CompilerGenerated]
		private readonly List<CallMinionInfo> _callMinionInfo_k__BackingField;
		[CompilerGenerated]
		private EnemyCharacter _summonerCharacter_k__BackingField;
		public List<EnemyCharacter> _mirageCharacters;
		[CompilerGenerated]
		private EnemyCharacter _realCharacter_k__BackingField;
		[CompilerGenerated]
		private bool _isSquadChief_k__BackingField;
		[CompilerGenerated]
		private EnemyCharacter _myChief_k__BackingField;
		[CompilerGenerated]
		private float _dropDelayTime_k__BackingField;
		[CompilerGenerated]
		private CtrlForm2nd _ctrlForm2nd_k__BackingField;
		[CompilerGenerated]
		private EnemyCharacter _form2ndCharacter_k__BackingField;
		[CompilerGenerated]
		private bool _isShapeShifting_k__BackingField;
		[CompilerGenerated]
		private bool _hasShapeShifted_k__BackingField;
		[CompilerGenerated]
		private Action<CollisionHitAttribute, int> _damageEvent;
		[CompilerGenerated]
		private Action<EnemyCharacter> _deadEvent;
		[CompilerGenerated]
		private Action<EnemyCharacter> _leaveEvent;
		[CompilerGenerated]
		private Func<bool, bool> _fatalEvent;
		[CompilerGenerated]
		private Action<CharacterBase> _initStateEvent;
		[CompilerGenerated]
		private float _rareStayTime_k__BackingField;
		private bool _wasLeaveEff;
		private EnemyTalk _talk;
		private int[] _damageHateCounter;
		private CharacterBase _deadHitAttrOwner;
		private int _deadHitAttrSkillId;
		private bool playDeadHitEffect;
		[CompilerGenerated]
		private bool _isForcedDeadNoReaction_k__BackingField;
		private bool _isShowRareDefeat;
		[CompilerGenerated]
		private int _GeneratorId_k__BackingField;
		private const int CoinDropIconLimitNum = 20;
		private const int ManaDropIconLimitNum = 20;
		private DropItemUI.Parameter[] _dropItems;
		[CompilerGenerated]
		private Vector3 _dropPositionOffset_k__BackingField;
		public bool _hideDropItemIcon;
		public bool isIgnoreBossUI;
		[CompilerGenerated]
		private bool _isAiSpecialMode_k__BackingField;
		private bool _abnormalSwitch;
		private List<EnemyCtrl> _tmpEnemyCtrlList;
		[CompilerGenerated]
		private Dictionary<int, CharaFaceEyeMotion> _eyeFaceTypeDict_k__BackingField;
		[CompilerGenerated]
		private Dictionary<int, CharaFaceMouthMotion> _mouthFaceTypeDict_k__BackingField;
		public Action onEntryAction;
		public List<EnemyUniqueCtrl> _listUniqueCtrl;
		[CompilerGenerated]
		private CtrlBoundaryAction _ctrlBoundary_k__BackingField;
		[CompilerGenerated]
		private int _popCount_k__BackingField;
		[CompilerGenerated]
		private bool _useBodyScaleAura_k__BackingField;
		private IEnumerator coBreakMode;
		private IEnumerator coBarrierMode;
		[CompilerGenerated]
		private DefWarHouseUniqueCtrl _defWarHouseUniqueCtrl_k__BackingField;
		[CompilerGenerated]
		private SeitentaiseiUniqueCtrl _seitentaiseiUniqueCtrl_k__BackingField;
	
		// Properties
		public bool generatedInPool { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool activeFromPool { [CompilerGenerated] get; [CompilerGenerated] set; }
		public EnemyParamElement ParamElm { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public EnemyDataElement DataElm { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public EnemyActionSetElement ActionSetElm { get; }
		public EnemyActionSetElement ActionSetElmBoost { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hasSwitchedElement { get; set; }
		public EnemyCtrl enemyCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public SphereCollider searchCollider { get; }
		public override int IsHitCollisionOnCenter { get; }
		public EnemyGuardMultiPlayService GuardMultiPlayService { get; }
		public List<EntityData> outsideEntityDatas { [CompilerGenerated] get; [CompilerGenerated] set; }
		public override float defense { get; }
		public override CharacterBuff buffCtrl { get; }
		public override CharacterAbnormalStatus abnormalStatusForDamageCalc { get; }
		public override bool isDamageImmunity { get; set; }
		public float barrierInterval { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float barrierHitCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string barrierEffName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string barrierBrokenEffName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public override bool isBarrierMode { get; protected set; }
		public bool isBoost { get; set; }
		public CtrlOverdrive ctrlOverdrive { get; }
		public override bool isOverdriveMode { get; }
		public bool hasOverDrive { get; }
		public override bool isBreakMode { get; protected set; }
		public bool IsBreakRecovery { [CompilerGenerated] get; [CompilerGenerated] set; }
		public override bool isNoTarget { get; set; }
		public Gluon.EnemyAbility enemyAbility { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hasSlipHpDebuff { get; }
		public bool isExistParts { get; }
		public int partsCharaNum { get; }
		public int partsIdx { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public EnemyCharacter[] PartsCharacters { get; }
		public bool IsPartsCharacter { get; }
		public EnemyCharacter BodyCharacter { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int partsDeadNum { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public EnemyCharacter lastDeadParts { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int partsCrashedTimes { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isDeleteDeadParts { get; }
		public bool isZombieParts { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isPartsSelfDef { get; }
		public bool IsSub { get; }
		public bool IsSeitentaiseiWeak { get; }
		public EnemyCharacter GetSeitentaiseiWeak { get; }
		public CtrlMultiWeak ctrlMultiWeak { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<EnemyCharacter> minions { [CompilerGenerated] get; }
		public int isCallMinionTiming { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int callMinionNum { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<CallMinionInfo> callMinionInfo { [CompilerGenerated] get; }
		public EnemyCharacter summonerCharacter { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsMinion { get; }
		public List<EnemyCharacter> mirageCharacters { get; }
		public EnemyCharacter realCharacter { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsMirage { get; }
		public bool isSquadChief { [CompilerGenerated] get; [CompilerGenerated] set; }
		public EnemyCharacter myChief { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float dropDelayTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CtrlForm2nd ctrlForm2nd { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isForm2nd { get; }
		public EnemyCharacter form2ndCharacter { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isExistForm2nd { get; }
		public bool isShapeShifting { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool hasShapeShifted { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float rareStayTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterBase DeadHitAttrOwner { get; }
		public int DeadHitAttrSkillId { get; }
		public bool isForcedDeadNoReaction { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int GeneratorId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int EnemySerialId { get; }
		public Vector3 dropPositionOffset { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isAiSpecialMode { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<int, CharaFaceEyeMotion> eyeFaceTypeDict { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Dictionary<int, CharaFaceMouthMotion> mouthFaceTypeDict { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override WarpRoom.RoomGroup warpRoomGroupId { get; set; }
		public CtrlBoundaryAction ctrlBoundary { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override bool isActiveBoundaryAction { get; }
		public int popCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool useBodyScaleAura { [CompilerGenerated] get; [CompilerGenerated] set; }
		public override string IdleStateName { get; }
		public override string WalkStateName { get; }
		public bool isCountDownHP { get; }
		public override bool IsBoss { get; }
		public override bool IsRaidBoss { get; }
		public bool IsRare { get; }
		public override bool IsStronger { get; }
		public bool IsSyncEnemy { get; }
		public bool IsGameMaster { get; }
		public bool IsProtection { get; }
		public bool IsFriend { get; }
		public bool IsNetworkSynchronizedEnemy { get; }
		public bool isPlayerSide { get; }
		public bool isNoActionCharacter { get; }
		public DefWarHouseUniqueCtrl defWarHouseUniqueCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsDefWarHouse { get; }
		public SeitentaiseiUniqueCtrl seitentaiseiUniqueCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsSalvationBubble { get; }
		public bool IsShapeShiftedFireAgito { get; }
		public bool IsLegendWindAgitoBloodMoon { get; }
		public int actionId_Home { get; }
		public int actionId_Counter { get; }
		public int actionId_Barrier { get; }
		public int actionId_Rage { get; }
		public int actionId_Shift { get; }
		public int actionId_Getup { get; }
		public int actionId_UnusualDead { get; }
		public int actionId_UniqueDead { get; }
		public int actionId_Break { get; }
		public int actionId_UnusualBreak { get; }
		public int actionId_Dissolution { get; }
		public int actionId_Alternative { get; }
	
		// Events
		public event Action<CollisionHitAttribute, int> _damageEvent {
			add;
			remove;
		}
		public event Action<EnemyCharacter> _deadEvent {
			add;
			remove;
		}
		public event Action<EnemyCharacter> _leaveEvent {
			add;
			remove;
		}
		public event Func<bool, bool> _fatalEvent {
			add;
			remove;
		}
		public event Action<CharacterBase> _initStateEvent {
			add;
			remove;
		}
	
		// Nested types
		private enum BarrierState
		{
			BarrierState_OFF = 0,
			BarrierState_CARRIAGE = 1,
			BarrierState_ON = 2
		}
	
		public enum DamageHateType
		{
			Direct = 0,
			Indirect = 1,
			Term = 2
		}
	
		public class CallMinionInfo
		{
			// Fields
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
	
			// Constructors
			public CallMinionInfo();
	
			// Methods
			public void Reset();
			public void CopyTo(CallMinionInfo dest);
		}
	
		public enum UniqueActionId
		{
			HomeAction = 0,
			CounterAction = 1,
			BarrierAction = 2,
			RageAction = 3,
			ShiftAction = 4,
			GetupAction = 5,
			UnusualDead = 6,
			UniqueDeadAction = 7,
			BreakAction = 8,
			UnusualBreak = 9,
			DissolutionAction = 10,
			AlternativeAction = 11
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<EnemyCharacter> __9__167_0;
			public static Comparison<EnemyCtrl> __9__342_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _get_GetSeitentaiseiWeak_b__167_0(EnemyCharacter d);
			internal int _FindNextSubCharacter_b__342_0(EnemyCtrl a, EnemyCtrl b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass324_0
		{
			// Fields
			public CharacterGraphicController characterGraphicController;
			public List<Renderer> breakRenderList;
			public EnemyCharacter __4__this;
	
			// Constructors
			public __c__DisplayClass324_0();
	
			// Methods
			internal bool _InitializeRenderState_b__0(Renderer renderer);
			internal void _InitializeRenderState_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _CoTalkEntryTiming_d__339 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float duration;
			public EnemyCharacter __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoTalkEntryTiming_d__339(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoTalkEntryTiming2_d__340 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EnemyCharacter __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoTalkEntryTiming2_d__340(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoBreakMode_d__400 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EnemyCharacter __4__this;
			public float duration;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoBreakMode_d__400(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoBarrierMode_d__407 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool fromNetwork;
			public EnemyCharacter __4__this;
			public bool carriage;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoBarrierMode_d__407(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoDropRewardDelay_d__468 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public EnemyCharacter __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoDropRewardDelay_d__468(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EnemyCharacter();
		static EnemyCharacter();
	
		// Methods
		public void CreateOverdrive(float baseOD, float baseBreak);
		public EnemyCharacter GetPartsCharacters(int parts_idx);
		public EnemyCharacter GetPartsCharacters(string meshName);
		public bool IsExistWeakPoint(EnemyCharacter target);
		protected override void Awake();
		public override void FastUpdate();
		public override int GetSortingOrderOffset();
		public EnemyCtrl AddEnemyCtrlComponent();
		public static EnemyCharacter Create(int paramId, CharacterManager charaManager = null);
		public static EnemyCharacter CreateFromEnemyData(int dataId, int level = 1, CharacterManager charaManager = null);
		public static void InitializeEnemyCharacterByDataId(int dataId, EnemyCharacter character);
		public void Initialize(int paramId);
		protected void InitializeByDataId(int dataId);
		protected void LoadActionContainerElements(InGameDef.CharacterType characterType, string groupName);
		private void LoadUniqueEffectSe();
		public override void InitializeRenderState(Renderer[] setRenderers = null, Func<Renderer, bool> entryRendererFunc = null, Action setInitializeRenderStateFunc = null);
		protected override void SetupCharacterState();
		public void CreateUI();
		private EnemyCharacter CreateParts(int idx, int paramId, EnemyCharacter parentChara);
		private void SetEffectMeshRendererForPartsCharacter(EnemyCharacter parts, GameObject go);
		protected void InitializeParts(int idx, int paramId);
		private void SetPartsLayer();
		public static string GetPartsMeshName(int partsIndex);
		public static string GetBreakPartsMeshName(int partsIndex);
		public void SetVisiblePartsMesh(int partsIndex, bool visible);
		public void AllPartsCharacterRevive();
		private void OnDeadParts();
		private static int GetPartsObjectParam(EnemyParamElement paramElement, int partsIndex);
		private static EnemyParamElement GetPartsObjectParamElement(EnemyParamElement paramElement, int partsIndex);
		public override void OnEntry();
		[IteratorStateMachine]
		public IEnumerator CoTalkEntryTiming(float duration);
		[IteratorStateMachine]
		public IEnumerator CoTalkEntryTiming2();
		public override void Revive(bool production = true, bool hasInvincibleTime = true, bool isReborn = false, float respawnInvincibleSec = 0f, float hpRatio = 1f);
		public EnemyCtrl FindNextSubCharacter(int id);
		private void UpdateRareStay();
		public override void AddInvincible(InvincibleControl.Type type, int level, float sec, int uid = 0);
		public override void RemoveInvincible(InvincibleControl.Type type, int uid = 0);
		public override Vector3 EffectScale();
		public override Vector3 AuraScale(bool isDynamicScale = false);
		public override Vector4 EmotionIconParam();
		public override float ShadowSize();
		protected void SetStatus();
		public bool IsRunningExtraAction();
		public bool IsRunningForcedAnnihilationAction();
		public override void PlayIdleMotion();
		public override void InitState(bool isContinue = false, float hpRatio = 1f);
		public void InitDamageHateCounter();
		private void UpdateDamageHateCounter(CharacterBase owner);
		public int GetDamageHateCounter(DamageHateType type);
		public override CharacterBase GetCurrentChara();
		protected override MaterialPropertyData GetMaterialPropertyBlockFromName(string partsName);
		public override void SetMaterialPropertyBlock();
		private void ShowBossGaugeUI();
		public void ShowBossPartGaugeUI(bool isChangeBoss);
		public void PlayUIOnProtectionDamage(CollisionHitAttribute hitAttr, int damage);
		public override TribeType GetTribe();
		protected override bool IsResistBlast();
		protected override bool IsHitFlash();
		protected override bool IsTurnToDamageDir(DamageReaction reaction);
		public override void Damaged(float motionTimeScale = 1f);
		public override void BuildDamage(int damage, CollisionHitAttribute hitAttr, Vector3 hitPos, CharacterDamageIntermediate outIntermediate);
		public override void ApplyDamage(CharacterDamageIntermediate intermediate);
		private bool ApplyReduceHp(int damage, int skillId, CharacterBase damageOwner, bool isQuestSkill = false);
		public override void ApplySlipDamage(CharacterBase attacker, int damage, bool isFollower, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int uniqueBuffIcon, Dictionary<CharacterBase, int> froms = null);
		public void ApplyDebuffExtraDamage(CharacterBase attacker, int damage, int actionConditionId, float extraElementRate = 0f);
		public override void DrainHp(CollisionHitAttribute attr);
		public bool SetSmash(bool excludeAddedIdx);
		private void DeadDamage();
		public override bool OnCollided(CollisionHitAttribute hitAttr, HitProduction hitProduction = HitProduction.All, int followerAvoid = 0);
		public override void OnDamaged(AttackHit attackHit, CollisionHitAttribute hitAttr, CharacterBase from);
		public override void Dead(bool isPlayMotion = true, bool isRestoreMotion = false, CollisionHitAttribute hitAttr = null);
		protected override void OnDead(bool isPlayMotion, bool isRestoreMotion, CollisionHitAttribute hitAttr);
		public override void SuddenDeath();
		public override void ForcedDead(bool isRegistLastDead = true, bool isShowRareDefeat = true, bool isInvolveBossDead = false);
		public void Leave();
		public override void PlayDeadAction();
		public void LeaveWeakPoint();
		public override void AddAction(int actionId, int skillId = 0, CommonObjectStatus target = null, Action<ActionBase> argActionEndCallback = null, bool viaAttackState = false);
		private int CalcDamageToOverdirve(int damage, CollisionHitAttribute hitAttr);
		public override void StartBreak();
		[IteratorStateMachine]
		public IEnumerator CoBreakMode(float duration);
		public override void BreakFinish();
		public override void CutoffBreak();
		public override bool RunningBarrier(CollisionHitAttribute data);
		public bool CountBarrierHit(bool isAdditionAttack);
		public void StartBarrier(bool carriage, bool fromNetwork = false);
		[IteratorStateMachine]
		private IEnumerator CoBarrierMode(bool carriage, bool fromNetwork);
		private void UpdateBarrier();
		public void CutoffBarrier();
		private void FinishBarrier();
		private void SendBarrier();
		private void SendBarrieredHit(int characterId, int actionId, Vector3 hitPos, bool isFromAdditionalAttack);
		private void PlayBarrierBrokenEffect();
		protected override DamageReaction CheckDamageReaction(CollisionHitAttribute attr, int damage);
		protected override bool IsDamageReaction(CollisionHitAttribute attr, int damage);
		protected override int CheckOverwhelm(int attack);
		protected override int CheckParameterDisparity();
		public override void ResetSuperArmorLevel();
		public void SetAction(int acitonId, CharacterStates state_, bool firstAction = false, CommonObjectStatus target = null, bool ignoreSync = false, int boundaryDataId = 0);
		public override int GetParalysisActionId();
		public override bool IsCounterAction(Vector3 attackDir, CollisionHitAttribute data);
		public void RunCounterAction(CharacterBase targetChara);
		public void SetSearchDiscoverEvent(Action<CharacterBase> searchResponse, float searchRange);
		private void OnTriggerEnter(Collider other);
		public void ReactionSearch();
		protected override void SetupExternalMove(CollisionHitAttribute attr, Vector3 collisionPos);
		protected override void SetupSuperArmorBreakMove(CollisionHitAttribute attr, Vector3 collisionPos);
		protected override void PlayHitEffect(CharacterBase owner, Vector3 hitPos, Quaternion rot, bool isCritical, bool isKiller, bool isTolerance, bool isTorpedo, string additionalAttackEffect = "");
		protected override void PlayHitFontEffect(CharacterBase owner, string fontEffectName, Vector3 hitPos);
		protected override void PlayDamageSE(CharacterBase owner, int actionId, Vector3 hitPos, bool isCritical, bool isLethal);
		protected override float GetAbnormalStatusProbability(CollisionHitAttribute attr, int type, float probability);
		public override void ResistUpAbnormalStatus(int type);
		public bool IsPerfectResistAbnormalStatus(int type);
		public bool HasAbnormalStatusReferToBody(AbnormalStatusType type, bool noneIsInvalid = false);
		protected override ApplyAbnormalStatusResult SetAbnormalStatus(CollisionHitAttribute attr, int conditionId, int damage, DamageReaction reaction);
		public void DropDp(CharacterBase attacker, float prevHpRate, int additionRecoveryDp);
		public void DropDp(CharacterBase attacker, int dp);
		public void DropDp(List<CharacterBase> attackers, float prevHpRate);
		protected override bool DropDp(float prevHpRate, CharacterBase triggerChara, float coef);
		private void DropDp(int dp, bool isTransformed, CharacterBase triggerChara, float coef, int limitNum = -1);
		private void DropDpHpRate(int dp, float prevHpRate, bool isTransformed, CharacterBase triggerChara, float coef);
		public override void PlayDefaultMoveAnimationForEventRecevier();
		private void SetupFaceTypeDict();
		public override void SetFaceType(FaceType type);
		public override void SetModelType(ModelType type);
		public override void SetColorState(CharacterColor.State state, bool forwardToParts = true);
		public override void ClearColor();
		public override void FinishColorState(CharacterColor.State state, bool forwardToParts = true);
		public override void SetCharaColor();
		protected override void DamageHitFlash();
		public override bool IsAttackHitSender(AttackHit attackHit);
		public override void OnCharacterSpecialState(CharacterSpecialState state);
		public void OnBarrieredHit(BarrieredHit barrieredHit);
		public static int GetQuesetDifficulty();
		public static Tuple<int, EnemyActionHitAttributeElement> GetHitAttributeForDifficulty(string label);
		public static string GetElementalSkillName(CharacterBase owner, EnemyActionElement action);
		public override void StopStatusEffect();
		public override void RestoreStatusEffect();
		public override void IgnoreCollide(CharacterBase target, bool isIgnore = true);
		public void SetupForm2nd(EnemyCharacter orignal);
		public void ShiftIntoForm2nd();
		public void TakeOverStatus(EnemyCharacter src, bool restoreEff = true);
		protected override void CheckStopAbnormalEventAction();
		public T AddUniqueCtrl<T>()
			where T : EnemyUniqueCtrl;
		public T GetUniqueCtrl<T>()
			where T : EnemyUniqueCtrl;
		public float GetAtkFromUniqueCtrl();
		public float GetDefFromUniqueCtrl();
		[IteratorStateMachine]
		public IEnumerator CoDropRewardDelay(float delay);
		private void DropReward();
		private void IncrementItemRedNum(DropItemUI.Parameter item, int redNum, int redRarity);
		private void UpdateTotalDropData();
		public int GetUniqueAction(UniqueActionId type);
		private EnemyActionSetElement GetElementalActionSet();
		private void SetExpandedActionSet();
		private void LoadExpandedActionSet(ref List<int> skills);
		private void PickupActionFromActionSet(EnemyActionSetElement actionset, ref List<int> skills);
		public override void ChangeState(CharacterState characterState);
		public override bool IsTimeStopBuffAbnormalStatusDragonTimer();
		public void OnReceiveActionPartsNotifyEvent(ActionPartsNotifyEvent recvEvent);
		protected override void ActivateGrantedBuff(CollisionHitAttribute attr);
		[CompilerGenerated]
		private void _Initialize_b__320_0(CharacterAnimationEvent animEvent);
		[CompilerGenerated]
		private void _InitializeByDataId_b__321_0(CharacterAnimationEvent animEvent);
		[CompilerGenerated]
		private void _ActivateGrantedBuff_b__544_0(CollisionHitAttribute attr_, int actionConditionId);
	}
}
