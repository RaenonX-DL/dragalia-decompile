using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class HumanCharacter : PlayerCharacter
	{
		public enum TransformType
		{
			Dragon,
			Enhance,
			Servant
		}

		public enum TransformGaugeType
		{
			Normal,
			Enhance
		}

		public enum SpecialOnDamageVoiceType
		{
			DuringSkill = 1
		}

		public enum ChangeBACancelTypes
		{
			None,
			CancelCharge,
			CancelChargeAndAttack
		}

		private class ItemSkillData
		{
			public BattleRoyalDungeonItem type;

			public int skillIndex;

			public int count;
		}

		private string voicePrefix;

		private string[] attackCueNames;

		private string[] skillCueNames;

		private string[] commonSkillVoiceNames;

		private string[] dashAttackCueNames;

		private string[] damageCueNames;

		private string[] blastCueNames;

		private AbilityMultiPlayService _abilityMultiPlayService;

		private SkillPointMultiPlayService _skillPointMultiPlayService;

		private EnergyPointMultiPlayService _energyPointMultiPlayService;

		private UtpMultiPlayService _utpMultiPlayService;

		private RuntimeAnimatorController shareChara1Controller;

		private RuntimeAnimatorController shareChara2Controller;

		private int maxChargeLevel;

		private static readonly string[][] hitSETable;

		private Dictionary<int, ItemSkillData> brItemSkillDict;

		private const int brItemSkillTypeCountMax = 3;

		private const int brItemSkillCountPerTypeMax = 2;

		public AbilityMultiPlayService AbilityMultiPlayService => null;

		public override SkillPointMultiPlayService SkillPointMultiPlayService => null;

		public override EnergyPointMultiPlayService EnergyPointMultiPlayService => null;

		public UtpMultiPlayService UtpMultiPlayService => null;

		public override AbilityGaugeMultiPlayService AbilityGaugeMultiPlayService => null;

		public CharacterData charaData
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

		public PlayerData playerData
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

		public WeaponData weaponData
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

		public DragonData dragonData
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

		public AmuletData[] amuletData
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

		public int weaponSkinId
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

		public DragonCharacter servant
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

		public TransformType transformType
		{
			[CompilerGenerated]
			get
			{
				return default(TransformType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TransformGaugeType transformGaugeType
		{
			[CompilerGenerated]
			get
			{
				return default(TransformGaugeType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<AbilityDataElement> unionBonusAbilityList
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

		public Dictionary<int, int> hitCountDictForHitOccurrenceAbility
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

		public override string DebugName => null;

		public override string effNameCriticalHit => null;

		public static HumanCharacter Create(HeroParam param, HeroParamExData paramEx, GameObject parent, int layer, bool isNeedShadow, bool isOtherPlayer, bool isSupporter, int actorIndex, int partySwitchIndex, [Optional] CharacterManager charaManager)
		{
			return null;
		}

		public void Initialize(int characterId, int level, int dragonId, bool isNeedShadow, int actorIndex, int partySwitchIndex)
		{
		}

		public void InitializeOtherAnimatorController()
		{
		}

		private RuntimeAnimatorController LoadShareCharacterAnimatorController(int skillIndex)
		{
			return null;
		}

		private RuntimeAnimatorController LoadShareCharacterAnimatorController(string path, int baseId = -1, int variationId = -1)
		{
			return null;
		}

		public void ReplaceAnimatorControllerOnShareSkill(int skillIndex)
		{
		}

		public void ResetAnimatorController()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void LateUpdate()
		{
		}

		public override bool OnCollided(CollisionHitAttribute hitAttr, HitProduction hitProduction = HitProduction.All, int followerAvoid = 0)
		{
			return default(bool);
		}

		public override void BuildDamage(int damage, CollisionHitAttribute hitAttr, Vector3 hitPos, CharacterDamageIntermediate outIntermediate)
		{
		}

		public override void ApplyDamage(CharacterDamageIntermediate intermediate)
		{
		}

		protected override void SetupExternalMove(CollisionHitAttribute attr, Vector3 collisionPos)
		{
		}

		protected override bool IsTurnToDamageDir(DamageReaction reaction)
		{
			return default(bool);
		}

		protected override bool IsResistBlast()
		{
			return default(bool);
		}

		public override bool EnableReduceFreezeTime(CollisionHitAttribute attr)
		{
			return default(bool);
		}

		public override bool IsKatAndOriginalHandType()
		{
			return default(bool);
		}

		public override WeaponType GetWeaponType()
		{
			return default(WeaponType);
		}

		public WeaponAttackRangeType GetAttackRangeType(bool onlyUseWeaponType)
		{
			return default(WeaponAttackRangeType);
		}

		public bool IsLongRangeWeaponType(bool onlyUseWeaponType)
		{
			return default(bool);
		}

		public override WeaponTypeElement GetWeaponTypeElement()
		{
			return null;
		}

		public override ElementalType GetWeaponElement()
		{
			return default(ElementalType);
		}

		public override ElementalType GetDragonElement()
		{
			return default(ElementalType);
		}

		public override TribeType GetTribe()
		{
			return default(TribeType);
		}

		public override bool IsCombo(int actionId)
		{
			return default(bool);
		}

		public override int GetComboAttackId(int idx, bool ex)
		{
			return default(int);
		}

		private int GetDefaultComboId(int idx, bool ex)
		{
			return default(int);
		}

		public override int GetMaxCombo()
		{
			return default(int);
		}

		public override int GetDashAttackActionId()
		{
			return default(int);
		}

		public override int GetDashOnAvoidActionId(bool forAI)
		{
			return default(int);
		}

		public override int[] GetAllAvoidActions(InGameDef.Direction dir)
		{
			return null;
		}

		public override int GetAvoidActionId(InGameDef.Direction dir)
		{
			return default(int);
		}

		protected override float AvoidDirectionCoef(InGameDef.Direction dirType, int actionId)
		{
			return default(float);
		}

		private int GetActualEnhancedLeveledBurstAttackActionId()
		{
			return default(int);
		}

		public override int GetBurstAttackActionId()
		{
			return default(int);
		}

		private int GetOriginalActionChargeBaseId()
		{
			return default(int);
		}

		private int GetActionChargeBaseIdForAnyEnhancedBurstAttack(int enhancedBurstAttackId, InGameDef.BurstActionOffset step, out bool hasStepFlag)
		{
			return default(int);
		}

		public static bool IsEnhancedBurstAttackOffsetFlagEnabledForStep(int enhancedBurstAttackId, InGameDef.BurstActionOffset step)
		{
			return default(bool);
		}

		private int GetActualActionChargeSteppedIdForEnhancedBurstAttack(InGameDef.BurstActionOffset step)
		{
			return default(int);
		}

		public int GetActualActionChargeSteppedIdForEnhancedBurstAttack(int enhancedBurstAttackId, InGameDef.BurstActionOffset step)
		{
			return default(int);
		}

		public override int GetChargeStartActionId()
		{
			return default(int);
		}

		public override int GetChargeLoopActionId()
		{
			return default(int);
		}

		public override int GetChargeCancelActionId()
		{
			return default(int);
		}

		public override int GetChargeMarkerActionId()
		{
			return default(int);
		}

		public int GetChargeLoopBreakActionId()
		{
			return default(int);
		}

		public override int GetGuardActionId()
		{
			return default(int);
		}

		public override int GetGuardCancelAttackId()
		{
			return default(int);
		}

		public override int GetDamagedActionId()
		{
			return default(int);
		}

		public override int GetParalysisActionId()
		{
			return default(int);
		}

		public override int GetDragonTransformActionId()
		{
			return default(int);
		}

		public int GetDisappearActionId()
		{
			return default(int);
		}

		public int GetReviveActionId()
		{
			return default(int);
		}

		public int GetWinActionId()
		{
			return default(int);
		}

		public float GetBurstCameraFollowSpeed()
		{
			return default(float);
		}

		protected override void ResetAttachSignal(int actionId, int skillId)
		{
		}

		public override bool IsDashAttack(int actionId)
		{
			return default(bool);
		}

		public override void CreateChargeBullet(string effectName)
		{
		}

		public override void DeleteChargeBullet()
		{
		}

		public override float GetSuperArmorTimeOnCharge()
		{
			return default(float);
		}

		public void SetMaxChargeLevel(int level)
		{
		}

		public override int GetMaxChargeLv()
		{
			return default(int);
		}

		public override void PlayFallMotion()
		{
		}

		public override void PlayLandingMotion()
		{
		}

		public override void Dead(bool isPlayMotion = true, bool isRestoreMotion = false, [Optional] CollisionHitAttribute hitAttr)
		{
		}

		protected override AbnormalStatusProbabilityResult GetAbnormalStatusProbability(CollisionHitAttribute attr, int type, float probablity)
		{
			return default(AbnormalStatusProbabilityResult);
		}

		public override float GetSearchRange()
		{
			return default(float);
		}

		public float GetSearchAngle()
		{
			return default(float);
		}

		public override string GetAttackCueName(int comboIndex)
		{
			return null;
		}

		public override string GetDashAttackCueName()
		{
			return null;
		}

		public string GetBurstAttackCueName(int actionId)
		{
			return null;
		}

		public override string GetDamageCueName()
		{
			return null;
		}

		public override string GetBlastCueName()
		{
			return null;
		}

		public void StopSkillVoice()
		{
		}

		public override string GetSkillCueName(int idx)
		{
			return null;
		}

		private void SetupCharaData(HeroParam param)
		{
		}

		private void SetupPlayerData(HeroParam param, bool isSupporter)
		{
		}

		private void SetupWeaponData(HeroParam heroParam)
		{
		}

		private void SetupShareWeaponData()
		{
		}

		private void SetupAmuletData(HeroParam heroParam)
		{
		}

		private void SetupDragonData(HeroParam heroParam)
		{
		}

		public void DelaySetupDragonData(HeroParam heroParam)
		{
		}

		private void SetupAbilityParam()
		{
		}

		public override void SetupAbilityCommonData()
		{
		}

		public void ActivateQuestStartAbility()
		{
		}

		private void InvalidDragonAbility()
		{
		}

		private void SetupModeChangeActionId()
		{
		}

		private void SetupUniqueCombo()
		{
		}

		private UniqueComboData CreateUniqueComboData(int dataId)
		{
			return null;
		}

		private void CreateSkillChainCtrl()
		{
		}

		private void SetupMultipleSpGauge()
		{
		}

		public override bool HasSpGauge()
		{
			return default(bool);
		}

		public override bool IsSpShare()
		{
			return default(bool);
		}

		public override bool IsSpGaugeSkill(int skillIndex)
		{
			return default(bool);
		}

		private void SetupUniqueTransformData()
		{
		}

		public void SetupCharacter(HeroParam heroParam, HeroParamExData heroParamEx, bool isOtherPlayer, bool isSupporter)
		{
		}

		public void TakeOverStatus(DragonCharacter dragon)
		{
		}

		private bool IsRestoreEffectOnTakeOverStatus()
		{
			return default(bool);
		}

		public override void CancelTransform()
		{
		}

		public void LoadAction(bool isOtherPlayer)
		{
		}

		private void LoadActionForWeaponType(WeaponType weaponType, bool isOtherPlayer, bool isShareSkill)
		{
		}

		private void LoadShareSkill(int skillIndex, bool isOtherPlayer)
		{
		}

		public override void AddLoadListDerivedAction(List<int> actions)
		{
		}

		private void AddLoadListDerivedComboAction(List<int> actions, UniqueComboData comboData)
		{
		}

		private void AddLoadListModeChangeAction(List<int> actions)
		{
		}

		private void AddLoadListDerivedSkillAction(List<int> actions, CharaModeDataElement mde)
		{
		}

		private void AddLoadListDerivedBurstAction(List<int> actions, CharaModeDataElement mde)
		{
		}

		private void AddLoadListDerivedDashAttackAction(List<int> actions, CharaModeDataElement mde)
		{
		}

		public void AddLoadEnhancedBurstAttackSetByFlag(List<int> actions, int burstId)
		{
		}

		public void AddLoadListDerivedBurstActionSet(List<int> actions, int burstId)
		{
		}

		public override int GetComboLevel()
		{
			return default(int);
		}

		public override int GetBurstAttackLevel()
		{
			return default(int);
		}

		public override int GetSkillNum()
		{
			return default(int);
		}

		public override CharacterSkillData GetSkillData(int index)
		{
			return null;
		}

		public override SkillDataElement GetSkillDataElement(int index)
		{
			return null;
		}

		public override SkillDataElement GetTransSkillDataElement(int index, int phase)
		{
			return null;
		}

		public override SkillDataElement GetNextTransSkillDataElement(int index)
		{
			return null;
		}

		public override int IsEnableSkillChain(int index, int useSkillIndex)
		{
			return default(int);
		}

		public override bool SetChainSkill(int index, int chainSkillId)
		{
			return default(bool);
		}

		public override bool ResetChainSkill(int skillIndex, CharacterSkillData.SkillChainResetReason reason)
		{
			return default(bool);
		}

		public override AbilityDataElement GetAbilityDataElement(int index)
		{
			return null;
		}

		public override AbilityDataElement GetAmuletAbilityDataElement(int crestSlotNo, int abilitySlotNo)
		{
			return null;
		}

		public override AbilityDataElement GetDragonAbilityDataElement(int idx)
		{
			return null;
		}

		public override AbilityDataElement GetWeaponAbilityDataElement(int index)
		{
			return null;
		}

		public List<AbilityDataElement> GetWeaponPassiveAbilities()
		{
			return null;
		}

		public override AbilityDataElement GetSkillAbilityDataElement(int index)
		{
			return null;
		}

		public override AbilityDataElement GetExAbility2DataElement(int index)
		{
			return null;
		}

		public override AbilityDataElement GetEventAbilityDataElement(int index)
		{
			return null;
		}

		public AbilityCrestElement GetAmuletDataElement(int crestSlotNo)
		{
			return null;
		}

		public DragonDataElement GetDragonDataElement()
		{
			return null;
		}

		public WeaponBodyElement GetWeaponDataElement()
		{
			return null;
		}

		public override PlayerActionElement GetParentNextActionDataElement(int actionId)
		{
			return null;
		}

		public bool IsCallingServant()
		{
			return default(bool);
		}

		public bool IsTransformType(TransformType type)
		{
			return default(bool);
		}

		public bool HasEnhanceGaugeOfDragonTransform()
		{
			return default(bool);
		}

		public bool HasEnhanceGaugeOfUniqueTransform()
		{
			return default(bool);
		}

		public bool HasEnhanceGaugeOfServant()
		{
			return default(bool);
		}

		public bool IsMatchAbilityCondition(WeaponType weaponType)
		{
			return default(bool);
		}

		public bool IsMatchAbilityCondition(int targetUnitType, int ownerUnitType, ElementalType elementalType)
		{
			return default(bool);
		}

		public bool IsMatchExAbilityCondition(int targetUnitType, ElementalType elementalType)
		{
			return default(bool);
		}

		public override bool IsTurnToTarget(int id)
		{
			return default(bool);
		}

		protected override void PlayHitSE(int actionId, Vector3 hitPos, bool isCritical, bool isLethal, CharacterBase damagedChara)
		{
		}

		protected override void PlayHitCameraShake(CameraController.ShakeType shakeType)
		{
		}

		public override void CallbackHitAction(CollisionHitAttribute attr)
		{
		}

		public override void RecoverySpOnHit(CollisionHitAttribute attr, float recoverySPrate, float addtionalRate)
		{
		}

		public override void RecoveryDpOnHit(CollisionHitAttribute attr, CharacterBase damagedChara)
		{
		}

		public override void RecoveryEpOnHit(CollisionHitAttribute attr)
		{
		}

		public override void RecoveryCPOnHit(CollisionHitAttribute attr, int hitCount)
		{
		}

		public override void ActiveGaugeOnHit(CollisionHitAttribute attr)
		{
		}

		public override void RecoveryUtpOnHit(CollisionHitAttribute attr)
		{
		}

		public override void RecoveryUtp(int point)
		{
		}

		public override void SetEnhancedBurstAttackId(int actionId, int modifyChargeLevel)
		{
		}

		public override void ResetEnhancedBurstAttackId()
		{
		}

		public override int GetEnhancedBurstAttackId()
		{
			return default(int);
		}

		public override int GetActualEnhancedBurstAttackId()
		{
			return default(int);
		}

		public override void SetEnhancedAbilityBurstAttackId(int actionId)
		{
		}

		private int ConvertEnhancedIndexForShareSkill(int enhancedIndex, int skillId)
		{
			return default(int);
		}

		public override void SetEnhancedSkillId(int enhancedIndex, int enhancedId, int skillId, int depth)
		{
		}

		public override int GetEnhancedSkillId(int skillIndex, int depth = 0)
		{
			return default(int);
		}

		public override int GetEnhancedSkillIndex(int skillId)
		{
			return default(int);
		}

		public override void SetupEnhancedSkill(int enhancedIndex, int enhancedId, int skillId)
		{
		}

		public override void ResetEnhancedSkill(CharacterBuffType buffType, int conditionId)
		{
		}

		public override void ResetEnhancedSkill(int skillIndex)
		{
		}

		private void SetRequireSp(int sp, int skillIndex)
		{
		}

		public override void CheckTransSkill(CollisionHitAttribute attr)
		{
		}

		private void CheckTransSkill(CollisionHitAttribute attr, int idx)
		{
		}

		public override void TransformSkillForSkillId(int skillId)
		{
		}

		private void TransformSkill(int idx)
		{
		}

		public override void ResetTransSkill(int skillId)
		{
		}

		public override void DisableTrans(int skillIndex)
		{
		}

		public override bool IsPauseTransBuff(int skillId)
		{
			return default(bool);
		}

		public override void PauseTransBuff(int skillIndex, bool pause)
		{
		}

		public override void ChangeMode(int skillIndex)
		{
		}

		public override void ChangeModeForButton()
		{
		}

		protected override void SetGunMode()
		{
		}

		public override bool IsMatchGunMode(GunMode gunMode)
		{
			return default(bool);
		}

		public bool HasGunMode(GunMode gunMode)
		{
			return default(bool);
		}

		public override bool IsModeSkill(int skillIndex, int actionId)
		{
			return default(bool);
		}

		private bool IsModeSkill(int skillIndex, int actionId, int modeId)
		{
			return default(bool);
		}

		public override bool IsModeSkillForSkillId(int skillIndex, int skillId)
		{
			return default(bool);
		}

		private bool IsModeSkillForSkillId(int skillIndex, int skillId, int modeId)
		{
			return default(bool);
		}

		public void ActivateModeEffect()
		{
		}

		public override void PlayModeEffect()
		{
		}

		private int GetModeId(int specificMode = -1)
		{
			return default(int);
		}

		public override int GetConsumeEp(int idx)
		{
			return default(int);
		}

		public override void PlayDashEffect()
		{
		}

		public override bool IsMatchAttachWeaponHandType(AttachWeaponHandType type)
		{
			return default(bool);
		}

		public override void SwitchHumanWeaponSkinAsMainWeapon(int weaponSkinId, bool isDeco, int skillIndex)
		{
		}

		protected void SwitchHumanWeaponSkinForShareWeapon(ref ShareWeaponId shareWeaponId, ShareWeaponId defaultShareWeaponId, int weaponSkinId, int skillIndex, bool isDeco)
		{
		}

		public void SetVisibleShareWeapon(bool isVisible, int skillIndex, bool onlyForMain = false, bool onlyForDeco = false)
		{
		}

		public void ReplaceShareWeapon(bool isVisible, int skillIndex)
		{
		}

		public void ChangeAttachShareWeapon(HandID handId, int skillIndex)
		{
		}

		public override void SetFaceType(FaceType type, bool force = false)
		{
		}

		public override string GetFacePath()
		{
			return null;
		}

		public override int GetFaceID()
		{
			return default(int);
		}

		private void SetupCharacterEffect()
		{
		}

		public override void RefreshDashSpeedRatio()
		{
		}

		public override int GetBaseAuraMaxLimitLevel(int defaultBaseMaxLimitLevel)
		{
			return default(int);
		}

		public override CharacterBase GetDragonChara()
		{
			return null;
		}

		public void AddHitCountForHitOccurrenceAbility(int abilityId)
		{
		}

		public ChangeBACancelTypes GetChangeBACancelType()
		{
			return default(ChangeBACancelTypes);
		}

		public int GetItemSkillCount(int skillIndex)
		{
			return default(int);
		}

		public bool IsItemSkill(int skillIndex)
		{
			return default(bool);
		}

		public List<BattleRoyalDungeonItem> GetItemSkills()
		{
			return null;
		}

		private void CopySkillData(int from, int to, bool withSpMax)
		{
		}

		public bool CanAddBRItemSkill(int skillId)
		{
			return default(bool);
		}

		public void AddBRItemSkill(int skillId)
		{
		}

		public void RemoveBRItemSkill(int skillId)
		{
		}

		public bool CanUseSkillButton(int skillIndex)
		{
			return default(bool);
		}

		public void LoadActionForBR()
		{
		}
	}
}
