/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class CharaDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Name;
		[SerializeField]
		private string _SecondName;
		[SerializeField]
		private int _EmblemId;
		[SerializeField]
		private WeaponType _WeaponType;
		[SerializeField]
		private int _Rarity;
		[SerializeField]
		private int _MaxLimitBreakCount;
		[SerializeField]
		private ElementalType _ElementalType;
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
		private int _MotionType;
		[SerializeField]
		private int _PersonMotionType;
		[SerializeField]
		private int _IsDetailimage;
		[SerializeField]
		private int _VoiceType;
		[SerializeField]
		private float _BaseScale;
		[SerializeField]
		private int _UniqueWeaponId;
		[SerializeField]
		private int _UniqueWeaponSkinId;
		[SerializeField]
		private CharaFaceEyeMotion _WinFaceEyeMotion;
		[SerializeField]
		private CharaFaceMouthMotion _WinFaceMouthMotion;
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
		private int _FootprintsType;
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public string SecondName { get; }
		public int EmblemId { get; }
		public WeaponType WeaponType { get; }
		public int Rarity { get; }
		public int MaxLimitBreakCount { get; }
		public ElementalType ElementalType { get; }
		public UnitType CharaType { get; }
		public int BaseId { get; }
		public int VariationId { get; }
		public int MinHp3 { get; }
		public int MinHp4 { get; }
		public int MinHp5 { get; }
		public int MaxHp { get; }
		public int AddMaxHp1 { get; }
		public int PlusHp0 { get; }
		public int PlusHp1 { get; }
		public int PlusHp2 { get; }
		public int PlusHp3 { get; }
		public int PlusHp4 { get; }
		public int PlusHp5 { get; }
		public int McFullBonusHp5 { get; }
		public int MinAtk3 { get; }
		public int MinAtk4 { get; }
		public int MinAtk5 { get; }
		public int MaxAtk { get; }
		public int AddMaxAtk1 { get; }
		public int PlusAtk0 { get; }
		public int PlusAtk1 { get; }
		public int PlusAtk2 { get; }
		public int PlusAtk3 { get; }
		public int PlusAtk4 { get; }
		public int PlusAtk5 { get; }
		public int McFullBonusAtk5 { get; }
		public int MinDef { get; }
		public float DefCoef { get; }
		public int ModeChangeType { get; }
		public int ModeId1 { get; }
		public int ModeId2 { get; }
		public int ModeId3 { get; }
		public int ModeId4 { get; }
		public int KeepModeOnRevive { get; }
		public int OriginCombo { get; }
		public int Mode1Combo { get; }
		public int Mode2Combo { get; }
		public float SearchRange { get; }
		public float SearchAngle { get; }
		public WeaponAttackRangeType AttackRangeType { get; }
		public int BurstAttack { get; }
		public int DashAttack { get; }
		public int Avoid { get; }
		public int BackAvoidOnCombo { get; }
		public int Appear { get; }
		public int Revive { get; }
		public int Disappear { get; }
		public int Win { get; }
		public string EffNameCriticalHit { get; }
		public int Skill1 { get; }
		public int Skill2 { get; }
		public float SkillChainValidTime { get; }
		public int SkillChainSpbarCount { get; }
		public int Abilities11 { get; }
		public int Abilities12 { get; }
		public int Abilities13 { get; }
		public int Abilities14 { get; }
		public int Abilities21 { get; }
		public int Abilities22 { get; }
		public int Abilities23 { get; }
		public int Abilities24 { get; }
		public int Abilities31 { get; }
		public int Abilities32 { get; }
		public int Abilities33 { get; }
		public int Abilities34 { get; }
		public int ExAbilityData1 { get; }
		public int ExAbilityData2 { get; }
		public int ExAbilityData3 { get; }
		public int ExAbilityData4 { get; }
		public int ExAbilityData5 { get; }
		public int ExAbility2Data1 { get; }
		public int ExAbility2Data2 { get; }
		public int ExAbility2Data3 { get; }
		public int ExAbility2Data4 { get; }
		public int ExAbility2Data5 { get; }
		public int ChargeType { get; }
		public int MaxChargeLv { get; }
		public int HoldEditSkillCost { get; }
		public int EditSkillId { get; }
		public int EditSkillLevelNum { get; }
		public int EditSkillCost { get; }
		public int EditSkillRelationId { get; }
		public GiftType EditReleaseEntityType1 { get; }
		public int EditReleaseEntityId1 { get; }
		public int EditReleaseEntityQuantity1 { get; }
		public string ManaCircleName { get; }
		public int CharaLimitBreak { get; }
		public int PieceElementGroupId { get; }
		public int PieceMaterialElementId { get; }
		public GiftType AwakeNeedEntityType4 { get; }
		public int AwakeNeedEntityId4 { get; }
		public int AwakeNeedEntityQuantity4 { get; }
		public GiftType AwakeNeedEntityType5 { get; }
		public int AwakeNeedEntityId5 { get; }
		public int AwakeNeedEntityQuantity5 { get; }
		public string CvInfo { get; }
		public string CvInfoEn { get; }
		public string ProfileText { get; }
		public int MotionType { get; }
		public int PersonMotionType { get; }
		public int IsDetailimage { get; }
		public int VoiceType { get; }
		public float BaseScale { get; }
		public int UniqueWeaponId { get; }
		public int UniqueWeaponSkinId { get; }
		public CharaFaceEyeMotion WinFaceEyeMotion { get; }
		public CharaFaceMouthMotion WinFaceMouthMotion { get; }
		public int UniqueDragonId { get; }
		public int IsConvertDragonSkillLevel { get; }
		public int IsEnhanceChara { get; }
		public int IsPlayable { get; }
		public int DefaultAbility1Level { get; }
		public int DefaultAbility2Level { get; }
		public int DefaultAbility3Level { get; }
		public int DefaultBurstAttackLevel { get; }
		public int DefaultIsUnlockEditSkill { get; }
		public int MaxFriendshipPoint { get; }
		public string GrowMaterialOnlyStartDate { get; }
		public string GrowMaterialOnlyEndDate { get; }
		public int GrowMaterialId { get; }
		public GiftType McFullReleaseEntityType1 { get; }
		public int McFullReleaseEntityId1 { get; }
		public int McFullReleaseEntityQuantity1 { get; }
		public GiftType McFullReleaseEntityType2 { get; }
		public int McFullReleaseEntityId2 { get; }
		public int McFullReleaseEntityQuantity2 { get; }
		public int FootprintsType { get; }
	
		// Constructors
		public CharaDataElement();
	}
}
