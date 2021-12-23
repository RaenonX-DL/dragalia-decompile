using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ActionConditionElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private Gluon.AbnormalStatusType _Type;

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
		private Gluon.AbnormalStatusType _ConditionAbs;

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

		[SerializeField]
		private int _EnableSkillButtonAnimation;

		[SerializeField]
		private int _VesselBombCount;

		public int Id => default(int);

		public Gluon.AbnormalStatusType Type => default(Gluon.AbnormalStatusType);

		public string Text => null;

		public string TextEx => null;

		public int BlockExaustFlag => default(int);

		public int InternalFlag => default(int);

		public int UniqueIcon => default(int);

		public int BuffIconId => default(int);

		public int ResistBuffReset => default(int);

		public int ResistDebuffReset => default(int);

		public int UnifiedManagement => default(int);

		public int Overwrite => default(int);

		public int OverwriteIdenticalOwner => default(int);

		public int OverwriteGroupId => default(int);

		public int MaxDuplicatedCount => default(int);

		public int UsePowerUpEffect => default(int);

		public int NotUseStartEffect => default(int);

		public string StartEffectCommon => null;

		public string StartEffectAdd => null;

		public int LostOnDragon => default(int);

		public int KeepOnDragonShift => default(int);

		public int RestoreOnReborn => default(int);

		public int Rate => default(int);

		public int EfficacyType => default(int);

		public int RemoveConditionId => default(int);

		public int DebuffCategory => default(int);

		public int RemoveDebuffCategory => default(int);

		public float DurationSec => default(float);

		public int DurationNum => default(int);

		public float MinDurationSec => default(float);

		public int DurationTimeScale => default(int);

		public int IsAddDurationNum => default(int);

		public int MaxDurationNum => default(int);

		public float CoolDownTimeSec => default(float);

		public int RemoveAciton => default(int);

		public string DurationNumConsumedHeadText => null;

		public float SlipDamageIntervalSec => default(float);

		public int SlipDamageFixed => default(int);

		public float SlipDamageRatio => default(float);

		public int SlipDamageMax => default(int);

		public float SlipDamagePower => default(float);

		public int SlipDamageGroup => default(int);

		public float RateIncreaseByTime => default(float);

		public float RateIncreaseDuration => default(float);

		public float RegenePower => default(float);

		public float DebuffGrantRate => default(float);

		public int EventProbability => default(int);

		public float EventCoefficient => default(float);

		public float DamageCoefficient => default(float);

		public AbilityTargetAction TargetAction => default(AbilityTargetAction);

		public int TargetElemental => default(int);

		public Gluon.AbnormalStatusType ConditionAbs => default(Gluon.AbnormalStatusType);

		public int ConditionDebuff => default(int);

		public float RateHP => default(float);

		public float RateAttack => default(float);

		public float RateDefense => default(float);

		public float RateDefenseB => default(float);

		public float RateCritical => default(float);

		public float RateSkill => default(float);

		public float RateBurst => default(float);

		public float RateRecovery => default(float);

		public float RateRecoverySp => default(float);

		public int RateRecoverySpExceptTargetSkill => default(int);

		public float RateRecoveryDp => default(float);

		public float RateRecoveryUtp => default(float);

		public float RateAttackSpeed => default(float);

		public float RateChargeSpeed => default(float);

		public float RateBurstSpeed => default(float);

		public float MoveSpeedRate => default(float);

		public float MoveSpeedRateB => default(float);

		public float RatePoison => default(float);

		public float RateBurn => default(float);

		public float RateFreeze => default(float);

		public float RateParalysis => default(float);

		public float RateDarkness => default(float);

		public float RateSwoon => default(float);

		public float RateCurse => default(float);

		public float RateSlowMove => default(float);

		public float RateSleep => default(float);

		public float RateFrostbite => default(float);

		public float RateFlashheat => default(float);

		public float RateCrashWind => default(float);

		public float RateDarkAbs => default(float);

		public float RateDestroyFire => default(float);

		public float RatePoisonKiller => default(float);

		public float RateBurnKiller => default(float);

		public float RateFreezeKiller => default(float);

		public float RateParalysisKiller => default(float);

		public float RateDarknessKiller => default(float);

		public float RateSwoonKiller => default(float);

		public float RateCurseKiller => default(float);

		public float RateSlowMoveKiller => default(float);

		public float RateSleepKiller => default(float);

		public float RateFrostbiteKiller => default(float);

		public float RateFlashheatKiller => default(float);

		public float RateCrashWindKiller => default(float);

		public float RateDarkAbsKiller => default(float);

		public float RateDestroyFireKiller => default(float);

		public float RatePoisonAdd => default(float);

		public float RateBurnAdd => default(float);

		public float RateFreezeAdd => default(float);

		public float RateParalysisAdd => default(float);

		public float RateDarknessAdd => default(float);

		public float RateSwoonAdd => default(float);

		public float RateCurseAdd => default(float);

		public float RateSlowMoveAdd => default(float);

		public float RateSleepAdd => default(float);

		public float RateFrostbiteAdd => default(float);

		public float RateFlashheatAdd => default(float);

		public float RateCrashWindAdd => default(float);

		public float RateDarkAbsAdd => default(float);

		public float RateDestroyFireAdd => default(float);

		public float RateFire => default(float);

		public float RateWater => default(float);

		public float RateWind => default(float);

		public float RateLight => default(float);

		public float RateDark => default(float);

		public float EnhancedFire => default(float);

		public float EnhancedWater => default(float);

		public float EnhancedWind => default(float);

		public float EnhancedLight => default(float);

		public float EnhancedDark => default(float);

		public float EnhancedFire2 => default(float);

		public float EnhancedWater2 => default(float);

		public float EnhancedWind2 => default(float);

		public float EnhancedLight2 => default(float);

		public float EnhancedDark2 => default(float);

		public float EnhancedNoElement => default(float);

		public float EnhancedDisadvantagedElement => default(float);

		public float RateMagicCreature => default(float);

		public float RateNatural => default(float);

		public float RateDemiHuman => default(float);

		public float RateBeast => default(float);

		public float RateUndead => default(float);

		public float RateDeamon => default(float);

		public float RateHuman => default(float);

		public float RateDragon => default(float);

		public float RateDamageCut => default(float);

		public float RateDamageCut2 => default(float);

		public float RateDamageCutB => default(float);

		public float RateWeakInvalid => default(float);

		public int HealInvalid => default(int);

		public int TensionUpInvalid => default(int);

		public float ValidRegeneHP => default(float);

		public float ValidRegeneSP => default(float);

		public float ValidRegeneDP => default(float);

		public float ValidSlipHp => default(float);

		public int RequiredRecoverHp => default(int);

		public float RateGetHpRecovery => default(float);

		public float UniqueRegeneSp01 => default(float);

		public float AutoRegeneS1 => default(float);

		public float AutoRegeneSW => default(float);

		public float RateReraise => default(float);

		public float RateArmored => default(float);

		public float RateDamageShield => default(float);

		public float RateDamageShield2 => default(float);

		public float RateDamageShield3 => default(float);

		public float RateSacrificeShield => default(float);

		public int SacrificeShieldType => default(int);

		public int Malaise01 => default(int);

		public int Malaise02 => default(int);

		public int Malaise03 => default(int);

		public float RateNicked => default(float);

		public int CurseOfEmptiness => default(int);

		public int CurseOfEmptinessInvalid => default(int);

		public float TransSkill => default(float);

		public int GrantSkill => default(int);

		public int DisableAction => default(int);

		public int DisableActionFlags => default(int);

		public int DisableMove => default(int);

		public int InvincibleLv => default(int);

		public float AutoAvoid => default(float);

		public int ComboShift => default(int);

		public int EnhancedBurstAttack => default(int);

		public int EnhancedSkill1 => default(int);

		public int EnhancedSkill2 => default(int);

		public int EnhancedSkillWeapon => default(int);

		public float EnhancedCritical => default(float);

		public int Tension => default(int);

		public int Inspiration => default(int);

		public int Cartridge => default(int);

		public int ModeStack => default(int);

		public int StackData => default(int);

		public int StackNum => default(int);

		public int Sparking => default(int);

		public float RateHpDrain => default(float);

		public float HpDrainLimitRate => default(float);

		public float SelfDamageRate => default(float);

		public float HpConsumptionRate => default(float);

		public float HpConsumptionCoef => default(float);

		public int RemoveTrigger => default(int);

		public string DamageLink => null;

		public string AdditionAttack => null;

		public string AdditionAttackHitEffect => null;

		public ExtraBuffType ExtraBuffType => default(ExtraBuffType);

		public int EnhancedSky => default(int);

		public int InvalidBuffId => default(int);

		public int ModifyChargeLevel => default(int);

		public int Hiding => default(int);

		public int LevelUpId => default(int);

		public int LevelDownId => default(int);

		public int ExcludeFromBuffExtension => default(int);

		public int BuffExplosionId => default(int);

		public int EnableSkillButtonAnimation => default(int);

		public int VesselBombCount => default(int);
	}
}
