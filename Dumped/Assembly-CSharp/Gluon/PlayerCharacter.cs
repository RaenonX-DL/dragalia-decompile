/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Bullet;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerCharacter : CharacterBase
	{
		// Fields
		private int _mode;
		[CompilerGenerated]
		private GunMode _gunMode_k__BackingField;
		[CompilerGenerated]
		private OnModeChangedEvent _onModeChanged_k__BackingField;
		[CompilerGenerated]
		private ModeChangeType _modeChangeType_k__BackingField;
		[CompilerGenerated]
		private int[] _modeChangeActionId_k__BackingField;
		[CompilerGenerated]
		private UniqueComboData[] _uniqueCombo_k__BackingField;
		private const float skillMoveAndRotateSpeedCoef = 60f;
		public SkillInput skillMoveInput;
		public SkillInput skillRotateInput;
		[CompilerGenerated]
		private SkillPossessionFlag _chainSkillPossession_k__BackingField;
		[CompilerGenerated]
		private SkillChainCtrl _skillChainCtrl_k__BackingField;
		[CompilerGenerated]
		private int[] _skillGaugeBarCount_k__BackingField;
		[CompilerGenerated]
		private float[] _skillGaugeBarBaseValue_k__BackingField;
		private int _currentPortal;
		[CompilerGenerated]
		private PlayerCharacter _targetPlayer_k__BackingField;
		[CompilerGenerated]
		private TargetEffectCtrl _targetEffectCtrl_k__BackingField;
		[CompilerGenerated]
		private PlayerChargeController _chargeCtrl_k__BackingField;
		[CompilerGenerated]
		private InGameDef.ChargeType _chargeType_k__BackingField;
		[CompilerGenerated]
		private float _chargeMoveSpeedFactor_k__BackingField;
		[CompilerGenerated]
		private InGameDef.ChargeType _defaultChargeType_k__BackingField;
		[CompilerGenerated]
		private bool _isChargeMove_k__BackingField;
		[CompilerGenerated]
		private float _prevChargeTime_k__BackingField;
		[CompilerGenerated]
		private float _currChargeTime_k__BackingField;
		[CompilerGenerated]
		private bool _isCancelTransform_k__BackingField;
		[CompilerGenerated]
		private FollowerAIBase _followerAI_k__BackingField;
		private int restCountForFollwer;
		private bool[] enableActions;
		private HashSet<CauseAbnormalStatusData> causeAbsDatas;
		[CompilerGenerated]
		private AbnormalStatusType _causeAbsType_k__BackingField;
		[CompilerGenerated]
		private AbnormalStatusType _damagedAbsType_k__BackingField;
		public Vector3 moveTargetPosForOfficialAutoPlayMode;
		public AvoidAbility avoidAbility;
		protected ShareWeaponId shareWeapon1;
		protected ShareWeaponId shareWeapon2;
		protected ShareWeaponId defaultShareWeapon1;
		protected ShareWeaponId defaultShareWeapon2;
		[CompilerGenerated]
		private List<int> _keepActionIdForShowWeapon_k__BackingField;
		[CompilerGenerated]
		private List<int> _keepActionIdForHideWeapon_k__BackingField;
		[CompilerGenerated]
		private int _hitCountOnActionStart_k__BackingField;
		[CompilerGenerated]
		private bool _isHornBoost_k__BackingField;
		[CompilerGenerated]
		private DynamicAnimationClipOverrider _dynamicAnimationClipOverrider_k__BackingField;
		public List<int> AdditionalInputMinTapNumList;
		private GuardCounter guardCounter;
		[CompilerGenerated]
		private PlayerGuardReactionInChargeController _guardReactionInChargeController_k__BackingField;
		private bool isFirstUpdateCheckForSupportChara;
		public Dictionary<string, Dictionary<int, float>> killerRateDependsOnHitCount;
		private List<StockBulletObject> stockBullets;
		private bool _isExitFromDeadState;
	
		// Properties
		public int mode { get; private set; }
		public GunMode gunMode { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public OnModeChangedEvent onModeChanged { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ModeChangeType modeChangeType { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int[] modeChangeActionId { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public UniqueComboData[] uniqueCombo { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public SkillPossessionFlag chainSkillPossession { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public SkillChainCtrl skillChainCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int[] skillGaugeBarCount { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float[] skillGaugeBarBaseValue { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int currentPortal { get; set; }
		public PlayerCharacter targetPlayer { [CompilerGenerated] get; [CompilerGenerated] set; }
		public TargetEffectCtrl targetEffectCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public PlayerChargeController chargeCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public InGameDef.ChargeType chargeType { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float chargeMoveSpeedFactor { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public InGameDef.ChargeType defaultChargeType { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool isChargeMove { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float prevChargeTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float currChargeTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isCancelTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public virtual FollowerAIBase followerAI { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int RestCountForFollwer { get; set; }
		public AbnormalStatusType causeAbsType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public AbnormalStatusType damagedAbsType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<int> keepActionIdForShowWeapon { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<int> keepActionIdForHideWeapon { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int hitCountOnActionStart { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isHornBoost { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DynamicAnimationClipOverrider dynamicAnimationClipOverrider { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public PlayerGuardReactionInChargeController guardReactionInChargeController { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum ModeChangeType
		{
			None = 0,
			Skill = 1,
			Button = 2,
			UniqueTrans = 3,
			BuffStack = 4,
			Ability = 5
		}
	
		public class OnModeChangedEvent : UnityEvent<int, int>
		{
			// Constructors
			public OnModeChangedEvent();
		}
	
		public class SkillInput
		{
			// Fields
			public bool enable;
			public float speed;
	
			// Constructors
			public SkillInput();
	
			// Methods
			public void Reset();
		}
	
		[Flags]
		public enum SkillPossessionFlag
		{
			None = 0,
			Skill1 = 1,
			Skill2 = 2,
			WeaponSkill = 4
		}
	
		public class CauseAbnormalStatusData
		{
			// Fields
			public int actionId;
			public int productId;
	
			// Constructors
			public CauseAbnormalStatusData();
		}
	
		public struct AvoidAbility
		{
			// Fields
			public int actionId;
			public int level;
		}
	
		protected struct ShareWeaponId
		{
			// Fields
			public int mainId;
			public int decoId;
		}
	
		private class GuardCounter
		{
			// Fields
			public bool isWait;
			public bool isExec;
			public bool isSA;
			public bool isAvoid;
			public float[] damageCutRate;
			public int counterBAReactionMaxBreakLevel;
			public int counterAttachInvincibleLevel;
			public int actionId;
	
			// Constructors
			public GuardCounter();
	
			// Methods
			public void ResetDamageCutRate();
		}
	
		public enum BurstAttackInputType
		{
			Normal = 0,
			HoldDown = 1
		}
	
		// Constructors
		public PlayerCharacter();
	
		// Methods
		protected void Initialize();
		public override void FastUpdate();
		private void UpdateTargetPlayer();
		public override void InitState(bool isContinue = false, float hpRatio = 1f);
		public void SetEnabledAction(AbilityTargetAction actionType, bool enable);
		public bool GetEnabledAction(AbilityTargetAction actionType);
		public void SetMode(int skillIndex);
		public bool SetModeChangeForButton(int nextMode);
		private bool IsEnableModeChangeForButton();
		public void SetModeChangeForUniqueTrans(int nextMode);
		public virtual void SetModeChangeForStackBuff(int stackNum);
		public int GetEp(int idx);
		public int GetEp();
		public bool IsEpFull(int idx);
		public bool IsEnoughEp(int actionId);
		public bool IsAvailableEp(int idx);
		public float GetEpRate(int idx);
		public int GetMaxEp(int idx);
		public virtual int GetConsumeEp(int idx);
		public void SetEp(int value, int index, bool immediate = false);
		public int GetEpIndex(int mode);
		public void RecoveryEp(int value);
		public void RecoveryEp(int value, int idx);
		public bool IsShareSkill(int skillIndex);
		public int GetShareCharaId(int actionId);
		public ElementalType GetShareCharaElement(int skillIndex);
		public WeaponType GetShareWeaponType(int actionId);
		public int GetSourceCharacterShareSkillIndex(int skillIndex, int skillId);
		public int GetShareSkillIndex(int actionId);
		public virtual int GetEnhancedSkillIndex(int skillId);
		public int GetSkillIndex(int skillId);
		public bool IsSkill(int skillId, int skillIndex);
		public bool IsSkill1ForSkillId(int skillId);
		public bool IsSkill2ForSkillId(int skillId);
		public bool IsSkill3ForSkillId(int skillId);
		public bool IsSkill4ForSkillId(int skillId);
		public bool IsSkillFAForSkillId(int skillId);
		public int GetSkillLevel(int skillId);
		public virtual int GetBurstAttackLevel();
		public override void SetupSkillMoveInput(MoveInputData data);
		public override void ResetSkillMoveInput();
		public override void SetupSkillRotateInput(RotateInputData data);
		public override void ResetSkillRotateInput();
		public override void AddStockBullet(StockBulletObject bullet);
		public override void RemoveStockBullet(StockBulletObject bullet);
		public override void RemoveStockBulletAll();
		public override void RestartStockBullet();
		public void HideStockBullet();
		public override List<StockBulletObject> GetStockBullets();
		public bool FireFormationBullet(FormationBulletData.FireTrigger trigger);
		public int GetCanCarryOtherEnemyCharaIndex();
		public void Carry(int idx);
		public bool IsEnableThrow();
		public bool TryBurstAttack();
		public bool TryBurstAttackCommon();
		public bool TryInBurstAttackGuardCounter();
		public override bool IsTimeStop();
		public override bool IsTimeStopInput();
		public override bool IsTimeStopBuffAbnormalStatusDragonTimer();
		public void PauseChargeMarker(bool isPause);
		public override bool IsInputCharge();
		public override bool IsInputMove();
		public bool IsShiftCombo(int actionId);
		private bool TargetActionInNextActions(int baseActionId, int targetActionId);
		public void RunComboShift(UniqueComboData.ShiftConditionType type);
		public void ResetComboShift(UniqueComboData.ShiftConditionType type);
		public void ResetComboShiftFromBuff();
		public bool IsEnableSkill();
		public bool IsEnableTargetSkillAction(int skillIndex);
		public bool IsModeChangeSkill(int skillIndex);
		public bool IsModeChange();
		public virtual void ChangeMode(int skillIndex);
		public virtual void ChangeModeForButton();
		protected virtual void SetGunMode();
		public virtual bool IsMatchGunMode(GunMode gunMode);
		public virtual bool IsModeSkill(int skillIndex, int actionId);
		public virtual bool IsModeSkillForSkillId(int skillIndex, int skillId);
		public virtual void PlayModeEffect();
		public void ResetMode();
		public void SetToMode(int nextMode, bool withAction, bool withEffect);
		public bool HasModeChangeSkill();
		public virtual bool IsFinalAttack(int skillIndex);
		public virtual int GetComboLevel();
		public bool AddAdditionalInputCount();
		public override void StartupChargeMarker();
		public virtual int GetMaxChargeLv();
		public virtual int GetChargeStartActionId();
		public virtual int GetChargeLoopActionId();
		public virtual int GetChargeCancelActionId();
		public virtual int GetChargeMarkerActionId();
		public int GetPlayerChargeMarkerActionId();
		public override void FinishChargeMarker(bool isAttack, bool isGuard);
		public string GetChargeRunAnimationStateName();
		public string GetBurstAttackAnimationStateName();
		public string GetChargeLoopAnimationStateName();
		private string GetAnimationStateNameSuffix();
		private string CheckExistEnhancedBurstAttackStateName(string defaultStateName, int actionId);
		public override void UpdateChargeMarker();
		public float ChargeMarkerForwardOffset();
		private float GetChargeMarkerMinDistance();
		private float GetChargeMarkerMaxDistance();
		public CharacterBase GetTargetOrNearestEnemy();
		public CharacterBase GetNearestEnemy(float range = -1f);
		public override void ForceCompleteChargeMarker();
		public override bool IsUniqueTransformMode();
		public bool IsEnableTransformState();
		private bool IsEnableTransformCondition();
		public bool IsEnableTransform();
		public override void CancelTransform();
		public virtual void RunDragonTransform();
		public void RunUniqueTransform();
		public override void ReleaseUniqueTransform(bool isCancel);
		public void SetIsPauseUtpConsume(bool isPause);
		public void ChangeFollower();
		public void ResetChain();
		public void SetHitCountOnActionStart();
		public void AddKillerRateDependsOnHitCount(string hitLabel, string strDatas);
		public float GetKillerRateDependsOnHitCount(string hitLabel, int hitCount);
		protected void OnBuildDamage(int damage, CollisionHitAttribute hitAttr, CharacterDamageIntermediate outIntermediate);
		protected void OnApplyDamage(CharacterDamageIntermediate intermediate);
		public override void DrainHp(CollisionHitAttribute attr);
		public override void ExecSelfDamage(CollisionHitAttribute attr);
		public override void ApplySubstitudeDamage(int damage, bool fromSync = false);
		public void ExecHpConsumption(out float additionalDamage);
		protected override void ProcedureDamage(CollisionHitAttribute hitAttr, int damage, float pureElementRate, bool isCritical, bool isTolerance, bool isKiller, bool isLethal, bool isPenetrateShield, HitProduction hitProduction, string additionalAttackEffect);
		protected override void ProcedureDamageToDragon(CollisionHitAttribute hitAttr, int damage, float dragonTimerDamage, float pureElementRate, bool isTolerance, bool isPenetrateShield, HitProduction hitProduction);
		protected override void ProcedureZeroDamage(CollisionHitAttribute hitAttr, float pureElementRate, HitProduction hitProduction, bool buffApplied);
		public virtual void RecoverySpRatio(float ratio, int index, bool isHumanOnly, bool isDragonOnly);
		public float GetAdditionalRecoverySpRate(CharacterBase character, int actionId);
		private float GetAdditionalRecoverySpRate(EnemyCharacter enemy, AbilityDataElement ade, int actionId, int ownerUnit);
		private void CutDpUtp(CollisionHitAttribute hitAttr, int damage, float dragonTimerDamage = 0f);
		public virtual void AddLoadListDerivedAction(List<int> actions);
		public void LoadEnhancedSkillActionForAbility(List<int> actions);
		private void LoadEnhancedSkillActionForAbility(List<int> actions, AbilityDataElement ade, int skillIndex = -1);
		private void AddLoadActions(List<int> actions, int enhancedId, int enhancedIndex);
		protected override float GetAbnormalStatusResistRate(int type);
		public void CallbackAbnormalStatus(CollisionHitAttribute attr, AbnormalStatusType type);
		public void CallbackResistAbnormalStatus(CollisionHitAttribute attr, AbnormalStatusType type);
		public void DamagedAbnormalStatus(CollisionHitAttribute attr, AbnormalStatusType type);
		public void CallbackCauseDebuff(CharacterBuffType type, int actionId, int productId);
		public void ExecAbilityForTakeDamageReaction();
		public void PauseAbilityCoolTime(bool isPause, AbilityCondition condition);
		public void PauseAbilityCooolTimeForReactionTimeAbilityConditions(bool isPause);
		public void ReturnToOriginalMode();
		public void ReserveReturnToOriginalMode(int skillIndex, int actionId, CommonObjectStatus target);
		public void ReserveSkill(int skillIndex, int actionId, CommonObjectStatus target);
		protected void SetupEventPassiveData(HeroParam heroParam, bool isEquippedDragon, bool isOtherPlayer);
		protected void AttachShareHumanWeapon(int weaponId, ref ShareWeaponId shareWeapon, int attachHandType);
		public void CheckKeepShowWeapon(int actionId, bool ignoreChangeVisibility = false);
		public void CheckKeepHideWeapon(int actionId, int skillId);
		public bool NeedsKeepHideWeapon(int actionId, int skillId);
		public void ShowWeaponForce();
		public virtual void RecoverySpOnHit(CollisionHitAttribute attr, float recoverySPrate, float additionalRate);
		public virtual void RecoveryDpOnHit(CollisionHitAttribute attr, CharacterBase damagedChara);
		public virtual void RecoveryEpOnHit(CollisionHitAttribute attr);
		public virtual void RecoveryCPOnHit(CollisionHitAttribute attr, int hitCount = 1);
		public virtual void ActiveGaugeOnHit(CollisionHitAttribute attr);
		public virtual void RecoveryDpByPercentage(CollisionHitAttribute attr);
		public void BurstAttack();
		public void SetChargeType(PlayerActionElement elem);
		public bool IsBurstAttackInputTypeHoldDown(bool isAttacking);
		public virtual void RecoveryUtpOnHit(CollisionHitAttribute attr);
		public virtual void RecoveryUtp(int point);
		public bool IsGuardCounterWait();
		public bool IsGuardCounterSuperArmor();
		public void StartGuardCounterWait(SendSignalData sendSignalData);
		public int CounterBAReactionMaxBreakLevel();
		public int CounterAttachInvincibleLevel();
		public void StopGuardCounterWait();
		public float GetDamageCutRateOnGuardCounterWait(int invincibleBreakLv);
		public bool IsEnableGuardCounter();
		public void TryGuardCounter(CharacterBase attacker);
		public void StopGuardCounter();
		public bool IsGuardCounterAvoid();
		protected bool HasChainSkill1And2();
		public virtual bool HasSpGauge();
		public virtual bool IsSpShare();
		public virtual bool IsSpGaugeSkill(int skillIndex);
		public void StartSkillChainTimer(int skillIndex);
		public void ResetSkillChainTimer();
		public void PauseSkillChainTimer(bool isPause);
		public virtual int IsEnableSkillChain(int skillIndex, int useSkillIndex);
		public virtual bool SetChainSkill(int skillIndex, int chainSkillId);
		public virtual bool ResetChainSkill(int skillIndex, CharacterSkillData.SkillChainResetReason reason);
		public void ResetSkillChain(CharacterSkillData.SkillChainResetReason reason);
		public bool IsOverChargeSkill(int skillIndex);
		public bool IsOverChargeSkill(int skillIndex, int actionId);
		public virtual int GetOverChargeSp(int skillIndex, int phase);
		public void OnRecieveCharacterStateExSync(CharacterStateExtraSync recvData);
		public void OnPreDisconnectOwner();
		public void OnPostDisconnectOwner();
		public override void OnCharacterSpecialState(CharacterSpecialState state);
		public bool CanBlastUp();
		public void StartAlloutAssault(bool isStateEffect = true);
		public void EndAlloutAssault();
		public static bool IsPauseState(CharacterStates state);
		public void OnEnterState_ForZombieProblem(CharacterStateBase state);
		public void OnExitFromDeadState_ForZombieProblem();
		protected override DamageReaction CheckDamageReaction(CollisionHitAttribute attr, int damage);
	}
}
