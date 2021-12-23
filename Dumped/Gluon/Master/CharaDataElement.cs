using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CharaDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _SecondName;

		[SerializeField]
		private int _EmblemId;

		[SerializeField]
		private Gluon.WeaponType _WeaponType;

		[SerializeField]
		private int _Rarity;

		[SerializeField]
		private int _MaxLimitBreakCount;

		[SerializeField]
		private Gluon.ElementalType _ElementalType;

		[SerializeField]
		private UnitType _CharaType;

		[SerializeField]
		private int _BaseId;

		[SerializeField]
		private int _VariationId;

		[SerializeField]
		private int _MinHp3;

		[SerializeField]
		private int _MinHp4;

		[SerializeField]
		private int _MinHp5;

		[SerializeField]
		private int _MaxHp;

		[SerializeField]
		private int _AddMaxHp1;

		[SerializeField]
		private int _PlusHp0;

		[SerializeField]
		private int _PlusHp1;

		[SerializeField]
		private int _PlusHp2;

		[SerializeField]
		private int _PlusHp3;

		[SerializeField]
		private int _PlusHp4;

		[SerializeField]
		private int _PlusHp5;

		[SerializeField]
		private int _McFullBonusHp5;

		[SerializeField]
		private int _MinAtk3;

		[SerializeField]
		private int _MinAtk4;

		[SerializeField]
		private int _MinAtk5;

		[SerializeField]
		private int _MaxAtk;

		[SerializeField]
		private int _AddMaxAtk1;

		[SerializeField]
		private int _PlusAtk0;

		[SerializeField]
		private int _PlusAtk1;

		[SerializeField]
		private int _PlusAtk2;

		[SerializeField]
		private int _PlusAtk3;

		[SerializeField]
		private int _PlusAtk4;

		[SerializeField]
		private int _PlusAtk5;

		[SerializeField]
		private int _McFullBonusAtk5;

		[SerializeField]
		private int _MinDef;

		[SerializeField]
		private float _DefCoef;

		[SerializeField]
		private int _ModeChangeType;

		[SerializeField]
		private int _ModeId1;

		[SerializeField]
		private int _ModeId2;

		[SerializeField]
		private int _ModeId3;

		[SerializeField]
		private int _ModeId4;

		[SerializeField]
		private int _KeepModeOnRevive;

		[SerializeField]
		private int _OriginCombo;

		[SerializeField]
		private int _Mode1Combo;

		[SerializeField]
		private int _Mode2Combo;

		[SerializeField]
		private float _SearchRange;

		[SerializeField]
		private float _SearchAngle;

		[SerializeField]
		private WeaponAttackRangeType _AttackRangeType;

		[SerializeField]
		private int _BurstAttack;

		[SerializeField]
		private int _DashAttack;

		[SerializeField]
		private int _Avoid;

		[SerializeField]
		private int _AvoidOnCombo;

		[SerializeField]
		private int _BackAvoidOnCombo;

		[SerializeField]
		private int _Appear;

		[SerializeField]
		private int _Revive;

		[SerializeField]
		private int _Disappear;

		[SerializeField]
		private int _Win;

		[SerializeField]
		private string _EffNameCriticalHit;

		[SerializeField]
		private int _Skill1;

		[SerializeField]
		private int _Skill2;

		[SerializeField]
		private float _SkillChainValidTime;

		[SerializeField]
		private int _SkillChainSpbarCount;

		[SerializeField]
		private int _SupportSkillNum;

		[SerializeField]
		private int _Abilities11;

		[SerializeField]
		private int _Abilities12;

		[SerializeField]
		private int _Abilities13;

		[SerializeField]
		private int _Abilities14;

		[SerializeField]
		private int _Abilities21;

		[SerializeField]
		private int _Abilities22;

		[SerializeField]
		private int _Abilities23;

		[SerializeField]
		private int _Abilities24;

		[SerializeField]
		private int _Abilities31;

		[SerializeField]
		private int _Abilities32;

		[SerializeField]
		private int _Abilities33;

		[SerializeField]
		private int _Abilities34;

		[SerializeField]
		private int _ExAbilityData1;

		[SerializeField]
		private int _ExAbilityData2;

		[SerializeField]
		private int _ExAbilityData3;

		[SerializeField]
		private int _ExAbilityData4;

		[SerializeField]
		private int _ExAbilityData5;

		[SerializeField]
		private int _ExAbility2Data1;

		[SerializeField]
		private int _ExAbility2Data2;

		[SerializeField]
		private int _ExAbility2Data3;

		[SerializeField]
		private int _ExAbility2Data4;

		[SerializeField]
		private int _ExAbility2Data5;

		[SerializeField]
		private int _ChargeType;

		[SerializeField]
		private int _MaxChargeLv;

		[SerializeField]
		private int _OnChangeBADuringCharge;

		[SerializeField]
		private int _HoldEditSkillCost;

		[SerializeField]
		private int _EditSkillId;

		[SerializeField]
		private int _EditSkillLevelNum;

		[SerializeField]
		private int _EditSkillCost;

		[SerializeField]
		private int _EditSkillRelationId;

		[SerializeField]
		private GiftType _EditReleaseEntityType1;

		[SerializeField]
		private int _EditReleaseEntityId1;

		[SerializeField]
		private int _EditReleaseEntityQuantity1;

		[SerializeField]
		private int _IsUnuseDmodeEditSkill;

		[SerializeField]
		private string _ManaCircleName;

		[SerializeField]
		private int _CharaLimitBreak;

		[SerializeField]
		private int _PieceElementGroupId;

		[SerializeField]
		private int _PieceMaterialElementId;

		[SerializeField]
		private GiftType _AwakeNeedEntityType4;

		[SerializeField]
		private int _AwakeNeedEntityId4;

		[SerializeField]
		private int _AwakeNeedEntityQuantity4;

		[SerializeField]
		private GiftType _AwakeNeedEntityType5;

		[SerializeField]
		private int _AwakeNeedEntityId5;

		[SerializeField]
		private int _AwakeNeedEntityQuantity5;

		[SerializeField]
		private string _CvInfo;

		[SerializeField]
		private string _CvInfoEn;

		[SerializeField]
		private string _ProfileText;

		[SerializeField]
		private string _ReleaseStartDate;

		[SerializeField]
		private int _IsViewSummonScene;

		[SerializeField]
		private int _MotionType;

		[SerializeField]
		private int _PersonMotionType;

		[SerializeField]
		private int _IsDetailimage;

		[SerializeField]
		private int _VoiceType;

		[SerializeField]
		private int _SeasonVoiceId;

		[SerializeField]
		private int _SpecialOndamageVoice;

		[SerializeField]
		private float _BaseScale;

		[SerializeField]
		private int _UniqueWeaponId;

		[SerializeField]
		private int _UniqueWeaponSkinId;

		[SerializeField]
		private int _AttachWeaponHandType;

		[SerializeField]
		private Gluon.CharaFaceEyeMotion _WinFaceEyeMotion;

		[SerializeField]
		private Gluon.CharaFaceMouthMotion _WinFaceMouthMotion;

		[SerializeField]
		private int _UniqueDragonId;

		[SerializeField]
		private int _IsConvertDragonSkillLevel;

		[SerializeField]
		private int _IsEnhanceChara;

		[SerializeField]
		private int _IsPlayable;

		[SerializeField]
		private int _DefaultAbility1Level;

		[SerializeField]
		private int _DefaultAbility2Level;

		[SerializeField]
		private int _DefaultAbility3Level;

		[SerializeField]
		private int _DefaultBurstAttackLevel;

		[SerializeField]
		private int _DefaultIsUnlockEditSkill;

		[SerializeField]
		private int _UniqueGrowMaterialId1;

		[SerializeField]
		private int _UniqueGrowMaterialId2;

		[SerializeField]
		private int _MaxFriendshipPoint;

		[SerializeField]
		private string _GrowMaterialOnlyStartDate;

		[SerializeField]
		private string _GrowMaterialOnlyEndDate;

		[SerializeField]
		private int _GrowMaterialId;

		[SerializeField]
		private GiftType _McFullReleaseEntityType1;

		[SerializeField]
		private int _McFullReleaseEntityId1;

		[SerializeField]
		private int _McFullReleaseEntityQuantity1;

		[SerializeField]
		private GiftType _McFullReleaseEntityType2;

		[SerializeField]
		private int _McFullReleaseEntityId2;

		[SerializeField]
		private int _McFullReleaseEntityQuantity2;

		[SerializeField]
		private int _BaseAuraMaxLimitLevel;

		[SerializeField]
		private int _FootprintsType;

		public int Id => default(int);

		public string Name => null;

		public string SecondName => null;

		public int EmblemId => default(int);

		public Gluon.WeaponType WeaponType => default(Gluon.WeaponType);

		public int Rarity => default(int);

		public int MaxLimitBreakCount => default(int);

		public Gluon.ElementalType ElementalType => default(Gluon.ElementalType);

		public UnitType CharaType => default(UnitType);

		public int BaseId => default(int);

		public int VariationId => default(int);

		public int MinHp3 => default(int);

		public int MinHp4 => default(int);

		public int MinHp5 => default(int);

		public int MaxHp => default(int);

		public int AddMaxHp1 => default(int);

		public int PlusHp0 => default(int);

		public int PlusHp1 => default(int);

		public int PlusHp2 => default(int);

		public int PlusHp3 => default(int);

		public int PlusHp4 => default(int);

		public int PlusHp5 => default(int);

		public int McFullBonusHp5 => default(int);

		public int MinAtk3 => default(int);

		public int MinAtk4 => default(int);

		public int MinAtk5 => default(int);

		public int MaxAtk => default(int);

		public int AddMaxAtk1 => default(int);

		public int PlusAtk0 => default(int);

		public int PlusAtk1 => default(int);

		public int PlusAtk2 => default(int);

		public int PlusAtk3 => default(int);

		public int PlusAtk4 => default(int);

		public int PlusAtk5 => default(int);

		public int McFullBonusAtk5 => default(int);

		public int MinDef => default(int);

		public float DefCoef => default(float);

		public int ModeChangeType => default(int);

		public int ModeId1 => default(int);

		public int ModeId2 => default(int);

		public int ModeId3 => default(int);

		public int ModeId4 => default(int);

		public int KeepModeOnRevive => default(int);

		public int OriginCombo => default(int);

		public int Mode1Combo => default(int);

		public int Mode2Combo => default(int);

		public float SearchRange => default(float);

		public float SearchAngle => default(float);

		public WeaponAttackRangeType AttackRangeType => default(WeaponAttackRangeType);

		public int BurstAttack => default(int);

		public int DashAttack => default(int);

		public int Avoid => default(int);

		public int AvoidOnCombo => default(int);

		public int BackAvoidOnCombo => default(int);

		public int Appear => default(int);

		public int Revive => default(int);

		public int Disappear => default(int);

		public int Win => default(int);

		public string EffNameCriticalHit => null;

		public int Skill1 => default(int);

		public int Skill2 => default(int);

		public float SkillChainValidTime => default(float);

		public int SkillChainSpbarCount => default(int);

		public int SupportSkillNum => default(int);

		public int Abilities11 => default(int);

		public int Abilities12 => default(int);

		public int Abilities13 => default(int);

		public int Abilities14 => default(int);

		public int Abilities21 => default(int);

		public int Abilities22 => default(int);

		public int Abilities23 => default(int);

		public int Abilities24 => default(int);

		public int Abilities31 => default(int);

		public int Abilities32 => default(int);

		public int Abilities33 => default(int);

		public int Abilities34 => default(int);

		public int ExAbilityData1 => default(int);

		public int ExAbilityData2 => default(int);

		public int ExAbilityData3 => default(int);

		public int ExAbilityData4 => default(int);

		public int ExAbilityData5 => default(int);

		public int ExAbility2Data1 => default(int);

		public int ExAbility2Data2 => default(int);

		public int ExAbility2Data3 => default(int);

		public int ExAbility2Data4 => default(int);

		public int ExAbility2Data5 => default(int);

		public int ChargeType => default(int);

		public int MaxChargeLv => default(int);

		public int OnChangeBADuringCharge => default(int);

		public int HoldEditSkillCost => default(int);

		public int EditSkillId => default(int);

		public int EditSkillLevelNum => default(int);

		public int EditSkillCost => default(int);

		public int EditSkillRelationId => default(int);

		public GiftType EditReleaseEntityType1 => default(GiftType);

		public int EditReleaseEntityId1 => default(int);

		public int EditReleaseEntityQuantity1 => default(int);

		public int IsUnuseDmodeEditSkill => default(int);

		public string ManaCircleName => null;

		public int CharaLimitBreak => default(int);

		public int PieceElementGroupId => default(int);

		public int PieceMaterialElementId => default(int);

		public GiftType AwakeNeedEntityType4 => default(GiftType);

		public int AwakeNeedEntityId4 => default(int);

		public int AwakeNeedEntityQuantity4 => default(int);

		public GiftType AwakeNeedEntityType5 => default(GiftType);

		public int AwakeNeedEntityId5 => default(int);

		public int AwakeNeedEntityQuantity5 => default(int);

		public string CvInfo => null;

		public string CvInfoEn => null;

		public string ProfileText => null;

		public string ReleaseStartDate => null;

		public int IsViewSummonScene => default(int);

		public int MotionType => default(int);

		public int PersonMotionType => default(int);

		public int IsDetailimage => default(int);

		public int VoiceType => default(int);

		public int SeasonVoiceId => default(int);

		public int SpecialOndamageVoice => default(int);

		public float BaseScale => default(float);

		public int UniqueWeaponId => default(int);

		public int UniqueWeaponSkinId => default(int);

		public int AttachWeaponHandType => default(int);

		public Gluon.CharaFaceEyeMotion WinFaceEyeMotion => default(Gluon.CharaFaceEyeMotion);

		public Gluon.CharaFaceMouthMotion WinFaceMouthMotion => default(Gluon.CharaFaceMouthMotion);

		public int UniqueDragonId => default(int);

		public int IsConvertDragonSkillLevel => default(int);

		public int IsEnhanceChara => default(int);

		public int IsPlayable => default(int);

		public int DefaultAbility1Level => default(int);

		public int DefaultAbility2Level => default(int);

		public int DefaultAbility3Level => default(int);

		public int DefaultBurstAttackLevel => default(int);

		public int DefaultIsUnlockEditSkill => default(int);

		public int UniqueGrowMaterialId1 => default(int);

		public int UniqueGrowMaterialId2 => default(int);

		public int MaxFriendshipPoint => default(int);

		public string GrowMaterialOnlyStartDate => null;

		public string GrowMaterialOnlyEndDate => null;

		public int GrowMaterialId => default(int);

		public GiftType McFullReleaseEntityType1 => default(GiftType);

		public int McFullReleaseEntityId1 => default(int);

		public int McFullReleaseEntityQuantity1 => default(int);

		public GiftType McFullReleaseEntityType2 => default(GiftType);

		public int McFullReleaseEntityId2 => default(int);

		public int McFullReleaseEntityQuantity2 => default(int);

		public int BaseAuraMaxLimitLevel => default(int);

		public int FootprintsType => default(int);
	}
}
