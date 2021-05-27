/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HumanCharacter : PlayerCharacter
	{
		// Fields
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
		[CompilerGenerated]
		private CharacterData _charaData_k__BackingField;
		[CompilerGenerated]
		private PlayerData _playerData_k__BackingField;
		[CompilerGenerated]
		private WeaponData _weaponData_k__BackingField;
		[CompilerGenerated]
		private DragonData _dragonData_k__BackingField;
		[CompilerGenerated]
		private AmuletData[] _amuletData_k__BackingField;
		private RuntimeAnimatorController shareChara1Controller;
		private RuntimeAnimatorController shareChara2Controller;
		[CompilerGenerated]
		private int _weaponSkinId_k__BackingField;
		[CompilerGenerated]
		private DragonCharacter _servant_k__BackingField;
		[CompilerGenerated]
		private TransformType _transformType_k__BackingField;
		[CompilerGenerated]
		private TransformGaugeType _transformGaugeType_k__BackingField;
		private int maxChargeLevel;
		[CompilerGenerated]
		private List<AbilityDataElement> _unionBonusAbilityList_k__BackingField;
		[CompilerGenerated]
		private Dictionary<int, int> _hitCountDictForHitOccurrenceAbility_k__BackingField;
		private static readonly string[][] hitSETable;
		private Dictionary<int, ItemSkillData> brItemSkillDict;
		private const int brItemSkillTypeCountMax = 3;
		private const int brItemSkillCountPerTypeMax = 2;
	
		// Properties
		public AbilityMultiPlayService AbilityMultiPlayService { get; }
		public override SkillPointMultiPlayService SkillPointMultiPlayService { get; }
		public override EnergyPointMultiPlayService EnergyPointMultiPlayService { get; }
		public UtpMultiPlayService UtpMultiPlayService { get; }
		public override AbilityGaugeMultiPlayService AbilityGaugeMultiPlayService { get; }
		public CharacterData charaData { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public PlayerData playerData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public WeaponData weaponData { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public DragonData dragonData { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public AmuletData[] amuletData { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int weaponSkinId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DragonCharacter servant { [CompilerGenerated] get; [CompilerGenerated] set; }
		public TransformType transformType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public TransformGaugeType transformGaugeType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<AbilityDataElement> unionBonusAbilityList { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<int, int> hitCountDictForHitOccurrenceAbility { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override string DebugName { get; }
		public override string effNameCriticalHit { get; }
	
		// Nested types
		public enum TransformType
		{
			Dragon = 0,
			Enhance = 1,
			Servant = 2
		}
	
		public enum TransformGaugeType
		{
			Normal = 0,
			Enhance = 1
		}
	
		public enum SpecialOnDamageVoiceType
		{
			DuringSkill = 1
		}
	
		private class ItemSkillData
		{
			// Fields
			public BattleRoyalDungeonItem type;
			public int skillIndex;
			public int count;
	
			// Constructors
			public ItemSkillData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0
		{
			// Fields
			public HumanCharacter __4__this;
			public int dragonId;
	
			// Constructors
			public __c__DisplayClass74_0();
	
			// Methods
			internal void _Initialize_b__0(CharacterAnimationEvent animEvent);
			internal void _Initialize_b__1(InGameTime.GameSpeed gameSpeedRate);
		}
	
		// Constructors
		public HumanCharacter();
		static HumanCharacter();
	
		// Methods
		public static HumanCharacter Create(HeroParam param, HeroParamExData paramEx, GameObject parent, int layer, bool isNeedShadow, bool isOtherPlayer, bool isSupporter, int actorIndex, int partySwitchIndex, CharacterManager charaManager = null);
		public void Initialize(int characterId, int level, int dragonId, bool isNeedShadow, int actorIndex, int partySwitchIndex);
		public void InitializeOtherAnimatorController();
		private RuntimeAnimatorController LoadShareCharacterAnimatorController(int skillIndex);
		private RuntimeAnimatorController LoadShareCharacterAnimatorController(string path, int baseId = -1, int variationId = -1);
		public void ReplaceAnimatorControllerOnShareSkill(int skillIndex);
		public void ResetAnimatorController();
		public override void FastUpdate();
		public override void LateUpdate();
		public override bool OnCollided(CollisionHitAttribute hitAttr, HitProduction hitProduction = HitProduction.All, int followerAvoid = 0);
		public override void BuildDamage(int damage, CollisionHitAttribute hitAttr, Vector3 hitPos, CharacterDamageIntermediate outIntermediate);
		public override void ApplyDamage(CharacterDamageIntermediate intermediate);
		protected override void SetupExternalMove(CollisionHitAttribute attr, Vector3 collisionPos);
		protected override bool IsTurnToDamageDir(DamageReaction reaction);
		protected override bool IsResistBlast();
		public override bool EnableReduceFreezeTime(CollisionHitAttribute attr);
		public override bool IsKatAndOriginalHandType();
		public override WeaponType GetWeaponType();
		public WeaponAttackRangeType GetAttackRangeType(bool onlyUseWeaponType);
		public bool IsLongRangeWeaponType(bool onlyUseWeaponType);
		public override WeaponTypeElement GetWeaponTypeElement();
		public override ElementalType GetWeaponElement();
		public override ElementalType GetDragonElement();
		public override TribeType GetTribe();
		public override bool IsCombo(int actionId);
		public override int GetComboAttackId(int idx, bool ex);
		private int GetDefaultComboId(int idx, bool ex);
		public override int GetMaxCombo();
		public override int GetDashAttackActionId();
		public override int[] GetAllAvoidActions(InGameDef.Direction dir);
		public override int GetAvoidActionId(InGameDef.Direction dir);
		protected override float AvoidDirectionCoef(InGameDef.Direction dirType, int actionId);
		private int GetActualEnhancedLeveledBurstAttackActionId();
		public override int GetBurstAttackActionId();
		private int GetOriginalActionChargeBaseId();
		private int GetActionChargeBaseIdForAnyEnhancedBurstAttack(int enhancedBurstAttackId, InGameDef.BurstActionOffset step, out bool hasStepFlag);
		public static bool IsEnhancedBurstAttackOffsetFlagEnabledForStep(int enhancedBurstAttackId, InGameDef.BurstActionOffset step);
		private int GetActualActionChargeSteppedIdForEnhancedBurstAttack(InGameDef.BurstActionOffset step);
		public int GetActualActionChargeSteppedIdForEnhancedBurstAttack(int enhancedBurstAttackId, InGameDef.BurstActionOffset step);
		public int GetChargeStartActionId();
		public int GetChargeLoopActionId();
		public int GetChargeCancelActionId();
		public int GetChargeMarkerActionId();
		public int GetChargeLoopBreakActionId();
		public override int GetGuardActionId();
		public override int GetGuardCancelAttackId();
		public override int GetDamagedActionId();
		public override int GetParalysisActionId();
		public override int GetDragonTransformActionId();
		public int GetDisappearActionId();
		public int GetReviveActionId();
		public int GetWinActionId();
		public float GetBurstCameraFollowSpeed();
		protected override void ResetAttachSignal(int actionId, int skillId);
		public override bool IsDashAttack(int actionId);
		public override bool IsBurstAttack(int actionId);
		public override void UpdateChargeMarker();
		public float ChargeMarkerForwardOffset();
		public override void CreateChargeBullet(string effectName);
		public override void DeleteChargeBullet();
		public override float GetSuperArmorTimeOnCharge();
		public void SetMaxChargeLevel(int level);
		public int GetMaxChargeLv();
		public override void PlayFallMotion();
		public override void PlayLandingMotion();
		public override void Dead(bool isPlayMotion = true, bool isRestoreMotion = false, CollisionHitAttribute hitAttr = null);
		protected override float GetAbnormalStatusProbability(CollisionHitAttribute attr, int type, float probablity);
		public override float GetSearchRange();
		public float GetSearchAngle();
		public override string GetAttackCueName(int comboIndex);
		public override string GetDashAttackCueName();
		public string GetBurstAttackCueName(int actionId);
		public override string GetDamageCueName();
		public override string GetBlastCueName();
		public void StopSkillVoice();
		public override string GetSkillCueName(int idx);
		private void SetupCharaData(HeroParam param);
		private void SetupPlayerData(HeroParam param, bool isSupporter);
		private void SetupWeaponData(HeroParam heroParam);
		private void SetupShareWeaponData();
		private void SetupAmuletData(HeroParam heroParam);
		private void SetupDragonData(HeroParam heroParam);
		public void DelaySetupDragonData(HeroParam heroParam);
		private void SetupAbilityParam();
		public override void SetupAbilityCommonData();
		public void ActivateQuestStartAbility();
		private void InvalidDragonAbility();
		private void SetupModeChangeActionId();
		private void SetupUniqueCombo();
		private UniqueComboData CreateUniqueComboData(int dataId);
		private void CreateSkillChainCtrl();
		private void SetupMultipleSpGauge();
		private void SetupUniqueTransformData();
		public void SetupCharacter(HeroParam heroParam, HeroParamExData heroParamEx, bool isOtherPlayer, bool isSupporter);
		public void TakeOverStatus(DragonCharacter dragon);
		private bool IsRestoreEffectOnTakeOverStatus();
		public override void CancelTransform();
		public void LoadAction(bool isOtherPlayer);
		private void LoadActionForWeaponType(WeaponType weaponType, bool isOtherPlayer, bool isShareSkill);
		private void LoadShareSkill(int skillIndex, bool isOtherPlayer);
		public override void AddLoadListDerivedAction(List<int> actions);
		private void AddLoadListDerivedComboAction(List<int> actions, UniqueComboData comboData);
		private void AddLoadListModeChangeAction(List<int> actions);
		private void AddLoadListDerivedSkillAction(List<int> actions, CharaModeDataElement mde);
		private void AddLoadListDerivedBurstAction(List<int> actions, CharaModeDataElement mde);
		private void AddLoadListDerivedDashAttackAction(List<int> actions, CharaModeDataElement mde);
		public void AddLoadEnhancedBurstAttackSetByFlag(List<int> actions, int burstId);
		public void AddLoadListDerivedBurstActionSet(List<int> actions, int burstId);
		public override int GetComboLevel();
		public override int GetBurstAttackLevel();
		public override int GetSkillNum();
		public override CharacterSkillData GetSkillData(int index);
		public override SkillDataElement GetSkillDataElement(int index);
		public override SkillDataElement GetTransSkillDataElement(int index, int phase);
		public override SkillDataElement GetNextTransSkillDataElement(int index);
		public override int IsEnableSkillChain(int index, int useSkillIndex);
		public override bool SetChainSkill(int index, int chainSkillId);
		public override bool ResetChainSkill(int skillIndex, CharacterSkillData.SkillChainResetReason reason);
		public override AbilityDataElement GetAbilityDataElement(int index);
		public override AbilityDataElement GetAmuletAbilityDataElement(int crestSlotNo, int abilitySlotNo);
		public override AbilityDataElement GetDragonAbilityDataElement(int idx);
		public override AbilityDataElement GetWeaponAbilityDataElement(int index);
		public List<AbilityDataElement> GetWeaponPassiveAbilities();
		public override AbilityDataElement GetSkillAbilityDataElement(int index);
		public override AbilityDataElement GetExAbility2DataElement(int index);
		public override AbilityDataElement GetEventAbilityDataElement(int index);
		public AbilityCrestElement GetAmuletDataElement(int crestSlotNo);
		public DragonDataElement GetDragonDataElement();
		public WeaponBodyElement GetWeaponDataElement();
		public override PlayerActionElement GetParentNextActionDataElement(int actionId);
		public bool IsCallingServant();
		public bool IsTransformType(TransformType type);
		public bool HasEnhanceGaugeOfDragonTransform();
		public bool HasEnhanceGaugeOfUniqueTransform();
		public bool HasEnhanceGaugeOfServant();
		public bool IsMatchAbilityCondition(WeaponType weaponType);
		public bool IsMatchAbilityCondition(int targetUnitType, int ownerUnitType, ElementalType elementalType);
		public bool IsMatchExAbilityCondition(int targetUnitType, ElementalType elementalType);
		private float GetChargeMarkerMinDistance();
		private float GetChargeMarkerMaxDistance();
		public override bool IsTurnToTarget(int id);
		protected override void PlayHitSE(int actionId, Vector3 hitPos, bool isCritical, bool isLethal, CharacterBase damagedChara);
		protected override void PlayHitCameraShake(CameraController.ShakeType shakeType);
		public override void CallbackHitAction(CollisionHitAttribute attr);
		public override void RecoverySpOnHit(CollisionHitAttribute attr, float recoverySPrate, float addtionalRate);
		public override void RecoveryDpOnHit(CollisionHitAttribute attr, CharacterBase damagedChara);
		public override void RecoveryEpOnHit(CollisionHitAttribute attr);
		public override void RecoveryCPOnHit(CollisionHitAttribute attr, int hitCount);
		public override void ActiveGaugeOnHit(CollisionHitAttribute attr);
		public override void RecoveryUtpOnHit(CollisionHitAttribute attr);
		public override void RecoveryUtp(int point);
		public override void SetEnhancedBurstAttackId(int actionId, int modifyChargeLevel);
		public override void ResetEnhancedBurstAttackId();
		public override int GetEnhancedBurstAttackId();
		public override int GetActualEnhancedBurstAttackId();
		public override void SetEnhancedAbilityBurstAttackId(int actionId);
		private int ConvertEnhancedIndexForShareSkill(int enhancedIndex, int skillId);
		public override void SetEnhancedSkillId(int enhancedIndex, int enhancedId, int skillId, int depth);
		public override int GetEnhancedSkillId(int skillIndex, int depth = 0);
		public override int GetEnhancedSkillIndex(int skillId);
		public override void SetupEnhancedSkill(int enhancedIndex, int enhancedId, int skillId);
		public override void ResetEnhancedSkill(CharacterBuffType buffType, int conditionId);
		public override void ResetEnhancedSkill(int skillIndex);
		private void SetRequireSp(int sp, int skillIndex);
		public override void CheckTransSkill(CollisionHitAttribute attr);
		private void CheckTransSkill(CollisionHitAttribute attr, int idx);
		public override void TransformSkillForSkillId(int skillId);
		private void TransformSkill(int idx);
		public override void ResetTransSkill(int skillId);
		public override void DisableTrans(int skillIndex);
		public override bool IsPauseTransBuff(int skillId);
		public override void PauseTransBuff(int skillIndex, bool pause);
		public override void ChangeMode(int skillIndex);
		public override void ChangeModeForButton();
		protected override void SetGunMode();
		public override bool IsMatchGunMode(GunMode gunMode);
		public bool HasGunMode(GunMode gunMode);
		public override bool IsModeSkill(int skillIndex, int actionId);
		private bool IsModeSkill(int skillIndex, int actionId, int modeId);
		public override bool IsModeSkillForSkillId(int skillIndex, int skillId);
		private bool IsModeSkillForSkillId(int skillIndex, int skillId, int modeId);
		public override void PlayModeEffect();
		private int GetModeId(int specificMode = -1);
		public override int GetConsumeEp(int idx);
		public override void PlayDashEffect();
		public override bool IsMatchAttachWeaponHandType(AttachWeaponHandType type);
		public override void SwitchHumanWeaponSkinAsMainWeapon(int weaponSkinId, bool isDeco, int skillIndex);
		protected void SwitchHumanWeaponSkinForShareWeapon(ref ShareWeaponId shareWeaponId, ShareWeaponId defaultShareWeaponId, int weaponSkinId, int skillIndex, bool isDeco);
		public void SetVisibleShareWeapon(bool isVisible, int skillIndex, bool onlyForMain = false, bool onlyForDeco = false);
		public void ReplaceShareWeapon(bool isVisible, int skillIndex);
		public void ChangeAttachShareWeapon(HandID handId, int skillIndex);
		public override void SetFaceType(FaceType type, bool force = false);
		public override string GetFacePath();
		public override int GetFaceID();
		private void SetupCharacterEffect();
		public override void RefreshDashSpeedRatio();
		public override CharacterBase GetDragonChara();
		public void AddHitCountForHitOccurrenceAbility(int abilityId);
		public int GetItemSkillCount(int skillIndex);
		public bool IsItemSkill(int skillIndex);
		public List<BattleRoyalDungeonItem> GetItemSkills();
		private void CopySkillData(int from, int to, bool withSpMax);
		public bool CanAddBRItemSkill(int skillId);
		public void AddBRItemSkill(int skillId);
		public void RemoveBRItemSkill(int skillId);
		public bool CanUseSkillButton(int skillIndex);
		public void LoadActionForBR();
	}
}
