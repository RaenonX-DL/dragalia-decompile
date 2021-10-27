/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class ActionConditionElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private AbnormalStatusType _Type;
		[SerializeField]
		private string _Text;
		[SerializeField]
		private string _TextEx;
		[SerializeField]
		private int _BlockExaustFlag;
		[SerializeField]
		private int _InternalFlag;
		[SerializeField]
		private int _UniqueIcon;
		[SerializeField]
		private int _BuffIconId;
		[SerializeField]
		private int _ResistBuffReset;
		[SerializeField]
		private int _ResistDebuffReset;
		[SerializeField]
		private int _UnifiedManagement;
		[SerializeField]
		private int _Overwrite;
		[SerializeField]
		private int _OverwriteIdenticalOwner;
		[SerializeField]
		private int _OverwriteGroupId;
		[SerializeField]
		private int _MaxDuplicatedCount;
		[SerializeField]
		private int _UsePowerUpEffect;
		[SerializeField]
		private int _NotUseStartEffect;
		[SerializeField]
		private string _StartEffectCommon;
		[SerializeField]
		private string _StartEffectAdd;
		[SerializeField]
		private int _LostOnDragon;
		[SerializeField]
		private int _KeepOnDragonShift;
		[SerializeField]
		private int _RestoreOnReborn;
		[SerializeField]
		private int _Rate;
		[SerializeField]
		private int _EfficacyType;
		[SerializeField]
		private int _RemoveConditionId;
		[SerializeField]
		private int _DebuffCategory;
		[SerializeField]
		private int _RemoveDebuffCategory;
		[SerializeField]
		private float _DurationSec;
		[SerializeField]
		private int _DurationNum;
		[SerializeField]
		private float _MinDurationSec;
		[SerializeField]
		private int _DurationTimeScale;
		[SerializeField]
		private int _IsAddDurationNum;
		[SerializeField]
		private int _MaxDurationNum;
		[SerializeField]
		private float _CoolDownTimeSec;
		[SerializeField]
		private int _RemoveAciton;
		[SerializeField]
		private string _DurationNumConsumedHeadText;
		[SerializeField]
		private float _SlipDamageIntervalSec;
		[SerializeField]
		private int _SlipDamageFixed;
		[SerializeField]
		private float _SlipDamageRatio;
		[SerializeField]
		private int _SlipDamageMax;
		[SerializeField]
		private float _SlipDamagePower;
		[SerializeField]
		private int _SlipDamageGroup;
		[SerializeField]
		private float _RateIncreaseByTime;
		[SerializeField]
		private float _RateIncreaseDuration;
		[SerializeField]
		private float _RegenePower;
		[SerializeField]
		private float _DebuffGrantRate;
		[SerializeField]
		private int _EventProbability;
		[SerializeField]
		private float _EventCoefficient;
		[SerializeField]
		private float _DamageCoefficient;
		[SerializeField]
		private AbilityTargetAction _TargetAction;
		[SerializeField]
		private int _TargetElemental;
		[SerializeField]
		private AbnormalStatusType _ConditionAbs;
		[SerializeField]
		private int _ConditionDebuff;
		[SerializeField]
		private float _RateHP;
		[SerializeField]
		private float _RateAttack;
		[SerializeField]
		private float _RateDefense;
		[SerializeField]
		private float _RateDefenseB;
		[SerializeField]
		private float _RateCritical;
		[SerializeField]
		private float _RateSkill;
		[SerializeField]
		private float _RateBurst;
		[SerializeField]
		private float _RateRecovery;
		[SerializeField]
		private float _RateRecoverySp;
		[SerializeField]
		private int _RateRecoverySpExceptTargetSkill;
		[SerializeField]
		private float _RateRecoveryDp;
		[SerializeField]
		private float _RateRecoveryUtp;
		[SerializeField]
		private float _RateAttackSpeed;
		[SerializeField]
		private float _RateChargeSpeed;
		[SerializeField]
		private float _RateBurstSpeed;
		[SerializeField]
		private float _MoveSpeedRate;
		[SerializeField]
		private float _MoveSpeedRateB;
		[SerializeField]
		private float _RatePoison;
		[SerializeField]
		private float _RateBurn;
		[SerializeField]
		private float _RateFreeze;
		[SerializeField]
		private float _RateParalysis;
		[SerializeField]
		private float _RateDarkness;
		[SerializeField]
		private float _RateSwoon;
		[SerializeField]
		private float _RateCurse;
		[SerializeField]
		private float _RateSlowMove;
		[SerializeField]
		private float _RateSleep;
		[SerializeField]
		private float _RateFrostbite;
		[SerializeField]
		private float _RateFlashheat;
		[SerializeField]
		private float _RateCrashWind;
		[SerializeField]
		private float _RateDarkAbs;
		[SerializeField]
		private float _RateDestroyFire;
		[SerializeField]
		private float _RatePoisonKiller;
		[SerializeField]
		private float _RateBurnKiller;
		[SerializeField]
		private float _RateFreezeKiller;
		[SerializeField]
		private float _RateParalysisKiller;
		[SerializeField]
		private float _RateDarknessKiller;
		[SerializeField]
		private float _RateSwoonKiller;
		[SerializeField]
		private float _RateCurseKiller;
		[SerializeField]
		private float _RateSlowMoveKiller;
		[SerializeField]
		private float _RateSleepKiller;
		[SerializeField]
		private float _RateFrostbiteKiller;
		[SerializeField]
		private float _RateFlashheatKiller;
		[SerializeField]
		private float _RateCrashWindKiller;
		[SerializeField]
		private float _RateDarkAbsKiller;
		[SerializeField]
		private float _RateDestroyFireKiller;
		[SerializeField]
		private float _RatePoisonAdd;
		[SerializeField]
		private float _RateBurnAdd;
		[SerializeField]
		private float _RateFreezeAdd;
		[SerializeField]
		private float _RateParalysisAdd;
		[SerializeField]
		private float _RateDarknessAdd;
		[SerializeField]
		private float _RateSwoonAdd;
		[SerializeField]
		private float _RateCurseAdd;
		[SerializeField]
		private float _RateSlowMoveAdd;
		[SerializeField]
		private float _RateSleepAdd;
		[SerializeField]
		private float _RateFrostbiteAdd;
		[SerializeField]
		private float _RateFlashheatAdd;
		[SerializeField]
		private float _RateCrashWindAdd;
		[SerializeField]
		private float _RateDarkAbsAdd;
		[SerializeField]
		private float _RateDestroyFireAdd;
		[SerializeField]
		private float _RateFire;
		[SerializeField]
		private float _RateWater;
		[SerializeField]
		private float _RateWind;
		[SerializeField]
		private float _RateLight;
		[SerializeField]
		private float _RateDark;
		[SerializeField]
		private float _EnhancedFire;
		[SerializeField]
		private float _EnhancedWater;
		[SerializeField]
		private float _EnhancedWind;
		[SerializeField]
		private float _EnhancedLight;
		[SerializeField]
		private float _EnhancedDark;
		[SerializeField]
		private float _EnhancedFire2;
		[SerializeField]
		private float _EnhancedWater2;
		[SerializeField]
		private float _EnhancedWind2;
		[SerializeField]
		private float _EnhancedLight2;
		[SerializeField]
		private float _EnhancedDark2;
		[SerializeField]
		private float _EnhancedNoElement;
		[SerializeField]
		private float _EnhancedDisadvantagedElement;
		[SerializeField]
		private float _RateMagicCreature;
		[SerializeField]
		private float _RateNatural;
		[SerializeField]
		private float _RateDemiHuman;
		[SerializeField]
		private float _RateBeast;
		[SerializeField]
		private float _RateUndead;
		[SerializeField]
		private float _RateDeamon;
		[SerializeField]
		private float _RateHuman;
		[SerializeField]
		private float _RateDragon;
		[SerializeField]
		private float _RateDamageCut;
		[SerializeField]
		private float _RateDamageCut2;
		[SerializeField]
		private float _RateDamageCutB;
		[SerializeField]
		private float _RateWeakInvalid;
		[SerializeField]
		private int _HealInvalid;
		[SerializeField]
		private int _TensionUpInvalid;
		[SerializeField]
		private float _ValidRegeneHP;
		[SerializeField]
		private float _ValidRegeneSP;
		[SerializeField]
		private float _ValidRegeneDP;
		[SerializeField]
		private float _ValidSlipHp;
		[SerializeField]
		private int _RequiredRecoverHp;
		[SerializeField]
		private float _RateGetHpRecovery;
		[SerializeField]
		private float _UniqueRegeneSp01;
		[SerializeField]
		private float _AutoRegeneS1;
		[SerializeField]
		private float _AutoRegeneSW;
		[SerializeField]
		private float _RateReraise;
		[SerializeField]
		private float _RateArmored;
		[SerializeField]
		private float _RateDamageShield;
		[SerializeField]
		private float _RateDamageShield2;
		[SerializeField]
		private float _RateDamageShield3;
		[SerializeField]
		private float _RateSacrificeShield;
		[SerializeField]
		private int _SacrificeShieldType;
		[SerializeField]
		private int _Malaise01;
		[SerializeField]
		private int _Malaise02;
		[SerializeField]
		private int _Malaise03;
		[SerializeField]
		private float _RateNicked;
		[SerializeField]
		private int _CurseOfEmptiness;
		[SerializeField]
		private int _CurseOfEmptinessInvalid;
		[SerializeField]
		private float _TransSkill;
		[SerializeField]
		private int _GrantSkill;
		[SerializeField]
		private int _DisableAction;
		[SerializeField]
		private int _DisableActionFlags;
		[SerializeField]
		private int _DisableMove;
		[SerializeField]
		private int _InvincibleLv;
		[SerializeField]
		private float _AutoAvoid;
		[SerializeField]
		private int _ComboShift;
		[SerializeField]
		private int _EnhancedBurstAttack;
		[SerializeField]
		private int _EnhancedSkill1;
		[SerializeField]
		private int _EnhancedSkill2;
		[SerializeField]
		private int _EnhancedSkillWeapon;
		[SerializeField]
		private float _EnhancedCritical;
		[SerializeField]
		private int _Tension;
		[SerializeField]
		private int _Inspiration;
		[SerializeField]
		private int _Cartridge;
		[SerializeField]
		private int _ModeStack;
		[SerializeField]
		private int _StackData;
		[SerializeField]
		private int _StackNum;
		[SerializeField]
		private int _Sparking;
		[SerializeField]
		private float _RateHpDrain;
		[SerializeField]
		private float _HpDrainLimitRate;
		[SerializeField]
		private float _SelfDamageRate;
		[SerializeField]
		private float _HpConsumptionRate;
		[SerializeField]
		private float _HpConsumptionCoef;
		[SerializeField]
		private int _RemoveTrigger;
		[SerializeField]
		private string _DamageLink;
		[SerializeField]
		private string _AdditionAttack;
		[SerializeField]
		private string _AdditionAttackHitEffect;
		[SerializeField]
		private ExtraBuffType _ExtraBuffType;
		[SerializeField]
		private int _EnhancedSky;
		[SerializeField]
		private int _InvalidBuffId;
		[SerializeField]
		private int _ModifyChargeLevel;
		[SerializeField]
		private int _Hiding;
		[SerializeField]
		private int _LevelUpId;
		[SerializeField]
		private int _LevelDownId;
		[SerializeField]
		private int _ExcludeFromBuffExtension;
		[SerializeField]
		private int _BuffExplosionId;
	
		// Properties
		public int Id { get; }
		public AbnormalStatusType Type { get; }
		public string Text { get; }
		public string TextEx { get; }
		public int BlockExaustFlag { get; }
		public int InternalFlag { get; }
		public int UniqueIcon { get; }
		public int BuffIconId { get; }
		public int ResistBuffReset { get; }
		public int ResistDebuffReset { get; }
		public int UnifiedManagement { get; }
		public int Overwrite { get; }
		public int OverwriteIdenticalOwner { get; }
		public int OverwriteGroupId { get; }
		public int MaxDuplicatedCount { get; }
		public int UsePowerUpEffect { get; }
		public int NotUseStartEffect { get; }
		public string StartEffectCommon { get; }
		public string StartEffectAdd { get; }
		public int LostOnDragon { get; }
		public int KeepOnDragonShift { get; }
		public int RestoreOnReborn { get; }
		public int Rate { get; }
		public int EfficacyType { get; }
		public int RemoveConditionId { get; }
		public int DebuffCategory { get; }
		public int RemoveDebuffCategory { get; }
		public float DurationSec { get; }
		public int DurationNum { get; }
		public float MinDurationSec { get; }
		public int DurationTimeScale { get; }
		public int IsAddDurationNum { get; }
		public int MaxDurationNum { get; }
		public float CoolDownTimeSec { get; }
		public int RemoveAciton { get; }
		public string DurationNumConsumedHeadText { get; }
		public float SlipDamageIntervalSec { get; }
		public int SlipDamageFixed { get; }
		public float SlipDamageRatio { get; }
		public int SlipDamageMax { get; }
		public float SlipDamagePower { get; }
		public int SlipDamageGroup { get; }
		public float RateIncreaseByTime { get; }
		public float RateIncreaseDuration { get; }
		public float RegenePower { get; }
		public float DebuffGrantRate { get; }
		public int EventProbability { get; }
		public float EventCoefficient { get; }
		public float DamageCoefficient { get; }
		public AbilityTargetAction TargetAction { get; }
		public int TargetElemental { get; }
		public AbnormalStatusType ConditionAbs { get; }
		public int ConditionDebuff { get; }
		public float RateHP { get; }
		public float RateAttack { get; }
		public float RateDefense { get; }
		public float RateDefenseB { get; }
		public float RateCritical { get; }
		public float RateSkill { get; }
		public float RateBurst { get; }
		public float RateRecovery { get; }
		public float RateRecoverySp { get; }
		public int RateRecoverySpExceptTargetSkill { get; }
		public float RateRecoveryDp { get; }
		public float RateRecoveryUtp { get; }
		public float RateAttackSpeed { get; }
		public float RateChargeSpeed { get; }
		public float RateBurstSpeed { get; }
		public float MoveSpeedRate { get; }
		public float MoveSpeedRateB { get; }
		public float RatePoison { get; }
		public float RateBurn { get; }
		public float RateFreeze { get; }
		public float RateParalysis { get; }
		public float RateDarkness { get; }
		public float RateSwoon { get; }
		public float RateCurse { get; }
		public float RateSlowMove { get; }
		public float RateSleep { get; }
		public float RateFrostbite { get; }
		public float RateFlashheat { get; }
		public float RateCrashWind { get; }
		public float RateDarkAbs { get; }
		public float RateDestroyFire { get; }
		public float RatePoisonKiller { get; }
		public float RateBurnKiller { get; }
		public float RateFreezeKiller { get; }
		public float RateParalysisKiller { get; }
		public float RateDarknessKiller { get; }
		public float RateSwoonKiller { get; }
		public float RateCurseKiller { get; }
		public float RateSlowMoveKiller { get; }
		public float RateSleepKiller { get; }
		public float RateFrostbiteKiller { get; }
		public float RateFlashheatKiller { get; }
		public float RateCrashWindKiller { get; }
		public float RateDarkAbsKiller { get; }
		public float RateDestroyFireKiller { get; }
		public float RatePoisonAdd { get; }
		public float RateBurnAdd { get; }
		public float RateFreezeAdd { get; }
		public float RateParalysisAdd { get; }
		public float RateDarknessAdd { get; }
		public float RateSwoonAdd { get; }
		public float RateCurseAdd { get; }
		public float RateSlowMoveAdd { get; }
		public float RateSleepAdd { get; }
		public float RateFrostbiteAdd { get; }
		public float RateFlashheatAdd { get; }
		public float RateCrashWindAdd { get; }
		public float RateDarkAbsAdd { get; }
		public float RateDestroyFireAdd { get; }
		public float RateFire { get; }
		public float RateWater { get; }
		public float RateWind { get; }
		public float RateLight { get; }
		public float RateDark { get; }
		public float EnhancedFire { get; }
		public float EnhancedWater { get; }
		public float EnhancedWind { get; }
		public float EnhancedLight { get; }
		public float EnhancedDark { get; }
		public float EnhancedFire2 { get; }
		public float EnhancedWater2 { get; }
		public float EnhancedWind2 { get; }
		public float EnhancedLight2 { get; }
		public float EnhancedDark2 { get; }
		public float EnhancedNoElement { get; }
		public float EnhancedDisadvantagedElement { get; }
		public float RateMagicCreature { get; }
		public float RateNatural { get; }
		public float RateDemiHuman { get; }
		public float RateBeast { get; }
		public float RateUndead { get; }
		public float RateDeamon { get; }
		public float RateHuman { get; }
		public float RateDragon { get; }
		public float RateDamageCut { get; }
		public float RateDamageCut2 { get; }
		public float RateDamageCutB { get; }
		public float RateWeakInvalid { get; }
		public int HealInvalid { get; }
		public int TensionUpInvalid { get; }
		public float ValidRegeneHP { get; }
		public float ValidRegeneSP { get; }
		public float ValidRegeneDP { get; }
		public float ValidSlipHp { get; }
		public int RequiredRecoverHp { get; }
		public float RateGetHpRecovery { get; }
		public float UniqueRegeneSp01 { get; }
		public float AutoRegeneS1 { get; }
		public float AutoRegeneSW { get; }
		public float RateReraise { get; }
		public float RateArmored { get; }
		public float RateDamageShield { get; }
		public float RateDamageShield2 { get; }
		public float RateDamageShield3 { get; }
		public float RateSacrificeShield { get; }
		public int SacrificeShieldType { get; }
		public int Malaise01 { get; }
		public int Malaise02 { get; }
		public int Malaise03 { get; }
		public float RateNicked { get; }
		public int CurseOfEmptiness { get; }
		public int CurseOfEmptinessInvalid { get; }
		public float TransSkill { get; }
		public int GrantSkill { get; }
		public int DisableAction { get; }
		public int DisableActionFlags { get; }
		public int DisableMove { get; }
		public int InvincibleLv { get; }
		public float AutoAvoid { get; }
		public int ComboShift { get; }
		public int EnhancedBurstAttack { get; }
		public int EnhancedSkill1 { get; }
		public int EnhancedSkill2 { get; }
		public int EnhancedSkillWeapon { get; }
		public float EnhancedCritical { get; }
		public int Tension { get; }
		public int Inspiration { get; }
		public int Cartridge { get; }
		public int ModeStack { get; }
		public int StackData { get; }
		public int StackNum { get; }
		public int Sparking { get; }
		public float RateHpDrain { get; }
		public float HpDrainLimitRate { get; }
		public float SelfDamageRate { get; }
		public float HpConsumptionRate { get; }
		public float HpConsumptionCoef { get; }
		public int RemoveTrigger { get; }
		public string DamageLink { get; }
		public string AdditionAttack { get; }
		public string AdditionAttackHitEffect { get; }
		public ExtraBuffType ExtraBuffType { get; }
		public int EnhancedSky { get; }
		public int InvalidBuffId { get; }
		public int ModifyChargeLevel { get; }
		public int Hiding { get; }
		public int LevelUpId { get; }
		public int LevelDownId { get; }
		public int ExcludeFromBuffExtension { get; }
		public int BuffExplosionId { get; }
	
		// Constructors
		public ActionConditionElement();
	}
}
