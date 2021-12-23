using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Bullet;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using _Gluon.Scripts.Common;

namespace Gluon
{
	public class PlayerCharacter : CharacterBase
	{
		public enum ModeChangeType
		{
			None,
			Skill,
			Button,
			UniqueTrans,
			BuffStack,
			Ability
		}

		public class OnModeChangedEvent : UnityEvent<int, int>
		{
		}

		public class SkillInput
		{
			public bool enable;

			public float speed;

			public void Reset()
			{
			}
		}

		[Flags]
		public enum SkillPossessionFlag
		{
			None = 0x0,
			Skill1 = 0x1,
			Skill2 = 0x2,
			WeaponSkill = 0x4
		}

		public class CauseAbnormalStatusData
		{
			public int actionId;

			public int productId;
		}

		public struct AvoidAbility
		{
			public int actionId;

			public int level;
		}

		protected struct ShareWeaponId
		{
			public int mainId;

			public int decoId;
		}

		private class GuardCounter
		{
			public bool isPreWait;

			public bool isWait;

			public bool isExec;

			public bool isSA;

			public bool isAvoid;

			public bool enableInInvincible;

			public float[] damageCutRate;

			public int counterBAReactionMaxBreakLevel;

			public int counterAttachInvincibleLevel;

			public int actionId;

			public bool isExecReserved;

			public int execCount;

			public bool noCounterAction;

			public void ResetDamageCutRate()
			{
			}
		}

		public enum BurstAttackInputType
		{
			Normal,
			HoldDown
		}

		private int _mode;

		private const float skillMoveAndRotateSpeedCoef = 60f;

		public SkillInput skillMoveInput;

		public SkillInput skillRotateInput;

		private int _currentPortal;

		private int restCountForFollwer;

		private bool[] enableActions;

		private HashSet<CauseAbnormalStatusData> causeAbsDatas;

		public Vector3 moveTargetPosForOfficialAutoPlayMode;

		public AvoidAbility avoidAbility;

		protected ShareWeaponId shareWeapon1;

		protected ShareWeaponId shareWeapon2;

		protected ShareWeaponId defaultShareWeapon1;

		protected ShareWeaponId defaultShareWeapon2;

		protected ShareWeaponId[] shareWeaponsForDmode;

		protected ShareWeaponId[] defaultShareWeaponsForDmode;

		public List<int> AdditionalInputMinTapNumList;

		private GuardCounter guardCounter;

		private bool isFirstUpdateCheckForSupportChara;

		public Dictionary<string, Dictionary<int, float>> killerRateDependsOnHitCount;

		private Dictionary<int, int> skillIndexDictForDmode;

		private List<StockBulletObject> stockBullets;

		private FloatAccumulator[] _autoSpChargeAccumulators;

		private bool _isExitFromDeadState;

		public int mode
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public GunMode gunMode
		{
			[CompilerGenerated]
			get
			{
				return default(GunMode);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public OnModeChangedEvent onModeChanged
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

		public ModeChangeType modeChangeType
		{
			[CompilerGenerated]
			get
			{
				return default(ModeChangeType);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int[] modeChangeActionId
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

		public UniqueComboData[] uniqueCombo
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

		public SkillPossessionFlag chainSkillPossession
		{
			[CompilerGenerated]
			get
			{
				return default(SkillPossessionFlag);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public SkillChainCtrl skillChainCtrl
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

		public int[] skillGaugeBarCount
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

		public float[] skillGaugeBarBaseValue
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

		public int currentPortal
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public PlayerCharacter targetPlayer
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

		public TargetEffectCtrl targetEffectCtrl
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

		public PlayerChargeController chargeCtrl
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

		public InGameDef.ChargeType chargeType
		{
			[CompilerGenerated]
			get
			{
				return default(InGameDef.ChargeType);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public float chargeMoveSpeedFactor
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

		public InGameDef.ChargeType defaultChargeType
		{
			[CompilerGenerated]
			get
			{
				return default(InGameDef.ChargeType);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isChargeMove
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

		public float prevChargeTime
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

		public float currChargeTime
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

		public bool isCancelTransform
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

		public virtual FollowerAIBase followerAI
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

		public int RestCountForFollwer
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public AbnormalStatusType causeAbsType
		{
			[CompilerGenerated]
			get
			{
				return default(AbnormalStatusType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AbnormalStatusType damagedAbsType
		{
			[CompilerGenerated]
			get
			{
				return default(AbnormalStatusType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<int> keepActionIdForShowWeapon
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

		public List<int> keepActionIdForHideWeapon
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

		public int hitCountOnActionStart
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

		public bool isHornBoost
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

		public DynamicAnimationClipOverrider dynamicAnimationClipOverrider
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

		public PlayerGuardReactionInChargeController guardReactionInChargeController
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

		protected void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdateTargetPlayer()
		{
		}

		public override void InitState(bool isContinue = false, float hpRatio = 1f)
		{
		}

		public override void InitUniqueGimmick(bool isContinue)
		{
		}

		public void SetEnabledAction(AbilityTargetAction actionType, bool enable)
		{
		}

		public bool GetEnabledAction(AbilityTargetAction actionType)
		{
			return default(bool);
		}

		public void SetMode(int skillIndex)
		{
		}

		public bool SetModeChangeForButton(int nextMode)
		{
			return default(bool);
		}

		public void SetModeForWalking(int value)
		{
		}

		private bool IsEnableModeChangeForButton()
		{
			return default(bool);
		}

		public void SetModeChangeForUniqueTrans(int nextMode)
		{
		}

		public virtual void SetModeChangeForStackBuff(int stackNum)
		{
		}

		public int GetEp(int idx)
		{
			return default(int);
		}

		public int GetEp()
		{
			return default(int);
		}

		public bool IsEpFull(int idx)
		{
			return default(bool);
		}

		public bool IsEnoughEp(int actionId)
		{
			return default(bool);
		}

		public bool IsAvailableEp(int idx)
		{
			return default(bool);
		}

		public float GetEpRate(int idx)
		{
			return default(float);
		}

		public int GetMaxEp(int idx)
		{
			return default(int);
		}

		public virtual int GetConsumeEp(int idx)
		{
			return default(int);
		}

		public void SetEp(int value, int index, bool immediate = false)
		{
		}

		public int GetEpIndex(int mode)
		{
			return default(int);
		}

		public void RecoveryEp(int value)
		{
		}

		public void RecoveryEp(int value, int idx)
		{
		}

		public bool IsShareSkill(int skillIndex)
		{
			return default(bool);
		}

		public int GetShareCharaId(int actionId)
		{
			return default(int);
		}

		public ElementalType GetShareCharaElement(int skillIndex)
		{
			return default(ElementalType);
		}

		public WeaponType GetShareWeaponType(int actionId)
		{
			return default(WeaponType);
		}

		public int GetSourceCharacterShareSkillIndex(int skillIndex, int skillId)
		{
			return default(int);
		}

		public int GetShareSkillIndex(int actionId)
		{
			return default(int);
		}

		public virtual int GetEnhancedSkillIndex(int skillId)
		{
			return default(int);
		}

		public int GetSkillIndex(int skillId)
		{
			return default(int);
		}

		public bool IsSkill(int skillId, int skillIndex)
		{
			return default(bool);
		}

		public bool IsSkill1ForSkillId(int skillId)
		{
			return default(bool);
		}

		public bool IsSkill2ForSkillId(int skillId)
		{
			return default(bool);
		}

		public bool IsSkill3ForSkillId(int skillId)
		{
			return default(bool);
		}

		public bool IsSkill4ForSkillId(int skillId)
		{
			return default(bool);
		}

		public bool IsSkillFAForSkillId(int skillId)
		{
			return default(bool);
		}

		public int GetSkillLevel(int skillId)
		{
			return default(int);
		}

		public override bool IsBurstAttack(int actionId, bool isIncludeDragonBurst = true)
		{
			return default(bool);
		}

		public virtual int GetBurstAttackLevel()
		{
			return default(int);
		}

		public override void SetupSkillMoveInput(MoveInputData data)
		{
		}

		public override void ResetSkillMoveInput()
		{
		}

		public override void SetupSkillRotateInput(RotateInputData data)
		{
		}

		public override void ResetSkillRotateInput()
		{
		}

		public override void AddStockBullet(StockBulletObject bullet)
		{
		}

		public override void RemoveStockBullet(StockBulletObject bullet)
		{
		}

		public override void RemoveStockBulletAll()
		{
		}

		public override void RestartStockBullet(bool refreshBulletState = true)
		{
		}

		public void HideStockBullet()
		{
		}

		public override List<StockBulletObject> GetStockBullets()
		{
			return null;
		}

		public bool FireFormationBullet(FormationBulletData.FireTrigger trigger)
		{
			return default(bool);
		}

		public int GetCanCarryOtherEnemyCharaIndex()
		{
			return default(int);
		}

		public void Carry(int idx)
		{
		}

		public bool IsEnableThrow()
		{
			return default(bool);
		}

		public bool TryBurstAttack()
		{
			return default(bool);
		}

		public bool TryBurstAttackCommon()
		{
			return default(bool);
		}

		public bool TryInBurstAttackGuardCounter()
		{
			return default(bool);
		}

		public override bool IsTimeStop()
		{
			return default(bool);
		}

		public override bool IsTimeStopInput()
		{
			return default(bool);
		}

		public override bool IsTimeStopBuffAbnormalStatusDragonTimer()
		{
			return default(bool);
		}

		public void PauseChargeMarker(bool isPause)
		{
		}

		public override bool IsInputCharge()
		{
			return default(bool);
		}

		public override bool IsInputMove()
		{
			return default(bool);
		}

		public bool IsShiftCombo(int actionId)
		{
			return default(bool);
		}

		private bool TargetActionInNextActions(int baseActionId, int targetActionId)
		{
			return default(bool);
		}

		public void RunComboShift(UniqueComboData.ShiftConditionType type)
		{
		}

		public void ResetComboShift(UniqueComboData.ShiftConditionType type)
		{
		}

		public void ResetComboShiftFromBuff()
		{
		}

		public bool IsEnableSkill()
		{
			return default(bool);
		}

		public bool IsEnableTargetSkillAction(int skillIndex)
		{
			return default(bool);
		}

		public bool IsModeChangeSkill(int skillIndex)
		{
			return default(bool);
		}

		public bool IsModeChange()
		{
			return default(bool);
		}

		public virtual void ChangeMode(int skillIndex)
		{
		}

		public virtual void ChangeModeForButton()
		{
		}

		protected virtual void SetGunMode()
		{
		}

		public virtual bool IsMatchGunMode(GunMode gunMode)
		{
			return default(bool);
		}

		public virtual bool IsModeSkill(int skillIndex, int actionId)
		{
			return default(bool);
		}

		public virtual bool IsModeSkillForSkillId(int skillIndex, int skillId)
		{
			return default(bool);
		}

		public virtual void PlayModeEffect()
		{
		}

		public void ResetMode()
		{
		}

		public void SetToMode(int nextMode, bool withAction, bool withEffect)
		{
		}

		public bool HasModeChangeSkill()
		{
			return default(bool);
		}

		public virtual bool IsFinalAttack(int skillIndex)
		{
			return default(bool);
		}

		public virtual int GetComboLevel()
		{
			return default(int);
		}

		public bool AddAdditionalInputCount()
		{
			return default(bool);
		}

		public override void StartupChargeMarker()
		{
		}

		public virtual int GetMaxChargeLv()
		{
			return default(int);
		}

		public virtual int GetChargeStartActionId()
		{
			return default(int);
		}

		public virtual int GetChargeLoopActionId()
		{
			return default(int);
		}

		public virtual int GetChargeCancelActionId()
		{
			return default(int);
		}

		public virtual int GetChargeMarkerActionId()
		{
			return default(int);
		}

		public int GetPlayerChargeMarkerActionId()
		{
			return default(int);
		}

		public override void FinishChargeMarker(bool isAttack, bool isGuard)
		{
		}

		public string GetChargeRunAnimationStateName()
		{
			return null;
		}

		public string GetBurstAttackAnimationStateName()
		{
			return null;
		}

		public string GetChargeLoopAnimationStateName()
		{
			return null;
		}

		private string GetAnimationStateNameSuffix()
		{
			return null;
		}

		private string CheckExistEnhancedBurstAttackStateName(string defaultStateName, int actionId)
		{
			return null;
		}

		public override void UpdateChargeMarker()
		{
		}

		public float ChargeMarkerForwardOffset()
		{
			return default(float);
		}

		private float GetChargeMarkerMinDistance()
		{
			return default(float);
		}

		private float GetChargeMarkerMaxDistance()
		{
			return default(float);
		}

		public CharacterBase GetTargetOrNearestEnemy()
		{
			return null;
		}

		public CharacterBase GetNearestEnemy(float range = -1f)
		{
			return null;
		}

		public override void ForceCompleteChargeMarker()
		{
		}

		public void AddDragonAbility()
		{
		}

		public override bool IsUniqueTransformMode()
		{
			return default(bool);
		}

		public bool IsEnableTransformState()
		{
			return default(bool);
		}

		private bool IsEnableTransformCondition()
		{
			return default(bool);
		}

		public bool IsEnableTransform()
		{
			return default(bool);
		}

		public override void CancelTransform()
		{
		}

		public virtual void RunDragonTransform()
		{
		}

		public void RunUniqueTransform()
		{
		}

		public override void ReleaseUniqueTransform(bool isCancel)
		{
		}

		public void SetIsPauseUtpConsume(bool isPause)
		{
		}

		public void ChangeFollower()
		{
		}

		public void ResetChain()
		{
		}

		public void SetHitCountOnActionStart()
		{
		}

		public void AddKillerRateDependsOnHitCount(string hitLabel, string strDatas)
		{
		}

		public float GetKillerRateDependsOnHitCount(string hitLabel, int hitCount)
		{
			return default(float);
		}

		protected void OnBuildDamage(int damage, CollisionHitAttribute hitAttr, CharacterDamageIntermediate outIntermediate)
		{
		}

		protected void OnApplyDamage(CharacterDamageIntermediate intermediate)
		{
		}

		public override void DrainHp(CollisionHitAttribute attr)
		{
		}

		public override void ExecSelfDamage(CollisionHitAttribute attr)
		{
		}

		public override void ApplySubstitudeDamage(int damage, bool fromSync = false)
		{
		}

		public void ExecHpConsumption(out float additionalDamage)
		{
		}

		protected override void ProcedureDamage(CollisionHitAttribute hitAttr, int damage, float pureElementRate, bool isCritical, bool isTolerance, bool isKiller, bool isLethal, bool isPenetrateShield, HitProduction hitProduction, string additionalAttackEffect)
		{
		}

		protected override void ProcedureDamageToDragon(CollisionHitAttribute hitAttr, int damage, float dragonTimerDamage, float pureElementRate, bool isTolerance, bool isPenetrateShield, HitProduction hitProduction)
		{
		}

		protected override void ProcedureZeroDamage(CollisionHitAttribute hitAttr, float pureElementRate, HitProduction hitProduction, bool buffApplied)
		{
		}

		public virtual void RecoverySpRatio(float ratio, int index, bool isHumanOnly, bool isDragonOnly)
		{
		}

		public float GetAdditionalRecoverySpRate(CharacterBase character, int actionId)
		{
			return default(float);
		}

		private float GetAdditionalRecoverySpRate(EnemyCharacter enemy, AbilityDataElement ade, int actionId, int ownerUnit, int ownerTalismanId = 0)
		{
			return default(float);
		}

		private void CutDpUtp(CollisionHitAttribute hitAttr, int damage, float dragonTimerDamage = 0f)
		{
		}

		public virtual void AddLoadListDerivedAction(List<int> actions)
		{
		}

		public void LoadEnhancedSkillActionForAbility(List<int> actions)
		{
		}

		private void LoadEnhancedSkillActionForAbility(List<int> actions, AbilityDataElement ade, int skillIndex = -1)
		{
		}

		private void AddLoadActions(List<int> actions, int enhancedId, int enhancedIndex)
		{
		}

		protected override float GetAbnormalStatusResistRate(int type)
		{
			return default(float);
		}

		public void CallbackAbnormalStatus(CollisionHitAttribute attr, AbnormalStatusType type)
		{
		}

		public void CallbackResistAbnormalStatus(CollisionHitAttribute attr, AbnormalStatusType type)
		{
		}

		public void DamagedAbnormalStatus(CollisionHitAttribute attr, AbnormalStatusType type)
		{
		}

		public void CallbackCauseDebuff(CharacterBuffType type, int actionId, int productId, CharacterBase owner)
		{
		}

		public void ExecAbilityForTakeDamageReaction()
		{
		}

		public void PauseAbilityCoolTime(bool isPause, AbilityCondition condition)
		{
		}

		public void PauseAbilityCooolTimeForReactionTimeAbilityConditions(bool isPause)
		{
		}

		private void CheckConditionallyAbilityForAbnormalStatusTimeElapsed()
		{
		}

		public void ActivateAbilityOnAbnormalStatusReceived(AbnormalStatusType absType)
		{
		}

		public void ActivateAbilityOnAbnormalStatusReleaced(AbnormalStatusType absType)
		{
		}

		public void ReturnToOriginalMode()
		{
		}

		public void ReserveReturnToOriginalMode(int skillIndex, int actionId, CommonObjectStatus target)
		{
		}

		public void ReserveSkill(int skillIndex, int actionId, CommonObjectStatus target)
		{
		}

		protected void SetupEventPassiveData(HeroParam heroParam, bool isEquippedDragon, bool isOtherPlayer)
		{
		}

		protected void AttachShareHumanWeapon(int weaponId, ref ShareWeaponId shareWeapon, int attachHandType)
		{
		}

		public void CheckKeepShowWeapon(int actionId, bool ignoreChangeVisibility = false)
		{
		}

		public void CheckKeepHideWeapon(int actionId, int skillIndex)
		{
		}

		public bool NeedsKeepHideWeapon(int actionId, int skillIndex)
		{
			return default(bool);
		}

		public void ShowWeaponForce()
		{
		}

		public virtual void RecoverySpOnHit(CollisionHitAttribute attr, float recoverySPrate, float additionalRate)
		{
		}

		public virtual void RecoveryDpOnHit(CollisionHitAttribute attr, CharacterBase damagedChara)
		{
		}

		public virtual void RecoveryEpOnHit(CollisionHitAttribute attr)
		{
		}

		public virtual void RecoveryCPOnHit(CollisionHitAttribute attr, int hitCount = 1)
		{
		}

		public virtual void ActiveGaugeOnHit(CollisionHitAttribute attr)
		{
		}

		public virtual void RecoveryDpByPercentage(CollisionHitAttribute attr)
		{
		}

		public void BurstAttack()
		{
		}

		public void SetChargeType(PlayerActionElement elem)
		{
		}

		public bool IsBurstAttackInputTypeHoldDown(bool isAttacking)
		{
			return default(bool);
		}

		public virtual void RecoveryUtpOnHit(CollisionHitAttribute attr)
		{
		}

		public virtual void RecoveryUtp(int point)
		{
		}

		public bool IsGuardCounterWait()
		{
			return default(bool);
		}

		public bool IsGuardCounterDuringInvincible()
		{
			return default(bool);
		}

		public bool IsGuardCounterSuperArmor()
		{
			return default(bool);
		}

		public void StartGuardCounterPreWait()
		{
		}

		public void StartGuardCounterWait(SendSignalData sendSignalData)
		{
		}

		public int CounterBAReactionMaxBreakLevel()
		{
			return default(int);
		}

		public int CounterAttachInvincibleLevel()
		{
			return default(int);
		}

		public void StopGuardCounterWait()
		{
		}

		public float GetDamageCutRateOnGuardCounterWait(int invincibleBreakLv)
		{
			return default(float);
		}

		public bool IsEnableGuardCounter()
		{
			return default(bool);
		}

		public void TryGuardCounter(CharacterBase attacker)
		{
		}

		public void TryGuardCounter()
		{
		}

		public void StopGuardCounter()
		{
		}

		public bool IsGuardCounterAvoid()
		{
			return default(bool);
		}

		protected bool HasChainSkill1And2()
		{
			return default(bool);
		}

		public virtual bool HasSpGauge()
		{
			return default(bool);
		}

		public virtual bool IsSpShare()
		{
			return default(bool);
		}

		public virtual bool IsSpGaugeSkill(int skillIndex)
		{
			return default(bool);
		}

		public void StartSkillChainTimer(int skillIndex)
		{
		}

		public void ResetSkillChainTimer()
		{
		}

		public void PauseSkillChainTimer(bool isPause)
		{
		}

		public virtual int IsEnableSkillChain(int skillIndex, int useSkillIndex)
		{
			return default(int);
		}

		public virtual bool SetChainSkill(int skillIndex, int chainSkillId)
		{
			return default(bool);
		}

		public virtual bool ResetChainSkill(int skillIndex, CharacterSkillData.SkillChainResetReason reason)
		{
			return default(bool);
		}

		public void ResetSkillChain(CharacterSkillData.SkillChainResetReason reason)
		{
		}

		public bool IsOverChargeSkill(int skillIndex)
		{
			return default(bool);
		}

		public bool IsOverChargeSkill(int skillIndex, int actionId)
		{
			return default(bool);
		}

		public virtual int GetOverChargeSp(int skillIndex, int phase)
		{
			return default(int);
		}

		public void OnRecieveCharacterStateExSync(CharacterStateExtraSync recvData)
		{
		}

		public void OnPreDisconnectOwner()
		{
		}

		public void OnPostDisconnectOwner()
		{
		}

		public override void OnCharacterSpecialState(CharacterSpecialState state)
		{
		}

		public bool CanBlastUp()
		{
			return default(bool);
		}

		public void StartAlloutAssault(bool isStateEffect = true)
		{
		}

		public void EndAlloutAssault()
		{
		}

		public static bool IsPauseState(CharacterStates state)
		{
			return default(bool);
		}

		public void UpdateSpForDmode()
		{
		}

		public void ChangeEquipWeaponAbility(DmodeDungeonItem prevWeapon, bool checkConditionNow = true)
		{
		}

		public void ChangeEquipCrestAbility(List<DmodeDungeonItem> prevCrests, bool checkConditionNow = true)
		{
		}

		public void SetSkillIndexForDmode(int actionProductId, int skillIndex)
		{
		}

		public int GetSkillIndexByActionProductIdForDmode(int actionProductId)
		{
			return default(int);
		}

		public void OnEnterState_ForZombieProblem(CharacterStateBase state)
		{
		}

		public void OnExitFromDeadState_ForZombieProblem()
		{
		}

		protected override DamageReaction CheckDamageReaction(CollisionHitAttribute attr, int damage)
		{
			return default(DamageReaction);
		}
	}
}
