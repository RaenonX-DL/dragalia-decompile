using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponBodyElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private int _WeaponSeriesId;

		[SerializeField]
		private int _WeaponSkinId;

		[SerializeField]
		private Gluon.WeaponType _WeaponType;

		[SerializeField]
		private int _Rarity;

		[SerializeField]
		private Gluon.ElementalType _ElementalType;

		[SerializeField]
		private int _WeaponSkinId2;

		[SerializeField]
		private int _MaxLimitOverCount;

		[SerializeField]
		private int _MaxEquipableCount;

		[SerializeField]
		private int _BaseHp;

		[SerializeField]
		private int _MaxHp1;

		[SerializeField]
		private int _MaxHp2;

		[SerializeField]
		private int _MaxHp3;

		[SerializeField]
		private int _BaseAtk;

		[SerializeField]
		private int _MaxAtk1;

		[SerializeField]
		private int _MaxAtk2;

		[SerializeField]
		private int _MaxAtk3;

		[SerializeField]
		private int _LimitOverCountPartyPower1;

		[SerializeField]
		private int _LimitOverCountPartyPower2;

		[SerializeField]
		private int _CrestSlotType1BaseCount;

		[SerializeField]
		private int _CrestSlotType1MaxCount;

		[SerializeField]
		private int _CrestSlotType2BaseCount;

		[SerializeField]
		private int _CrestSlotType2MaxCount;

		[SerializeField]
		private int _CrestSlotType3BaseCount;

		[SerializeField]
		private int _CrestSlotType3MaxCount;

		[SerializeField]
		private int _ChangeSkillId1;

		[SerializeField]
		private int _ChangeSkillId2;

		[SerializeField]
		private int _ChangeSkillId3;

		[SerializeField]
		private int _Abilities11;

		[SerializeField]
		private int _Abilities12;

		[SerializeField]
		private int _Abilities13;

		[SerializeField]
		private int _Abilities21;

		[SerializeField]
		private int _Abilities22;

		[SerializeField]
		private int _Abilities23;

		[SerializeField]
		private int _IsPlayable;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private string _CreateStartDate;

		[SerializeField]
		private int _NeedFortCraftLevel;

		[SerializeField]
		private int _NeedCreateWeaponBodyId1;

		[SerializeField]
		private int _NeedCreateWeaponBodyId2;

		[SerializeField]
		private int _NeedAllUnlockWeaponBodyId1;

		[SerializeField]
		private int _CreateCoin;

		[SerializeField]
		private GiftType _CreateEntityType1;

		[SerializeField]
		private int _CreateEntityId1;

		[SerializeField]
		private int _CreateEntityQuantity1;

		[SerializeField]
		private GiftType _CreateEntityType2;

		[SerializeField]
		private int _CreateEntityId2;

		[SerializeField]
		private int _CreateEntityQuantity2;

		[SerializeField]
		private GiftType _CreateEntityType3;

		[SerializeField]
		private int _CreateEntityId3;

		[SerializeField]
		private int _CreateEntityQuantity3;

		[SerializeField]
		private GiftType _CreateEntityType4;

		[SerializeField]
		private int _CreateEntityId4;

		[SerializeField]
		private int _CreateEntityQuantity4;

		[SerializeField]
		private GiftType _CreateEntityType5;

		[SerializeField]
		private int _CreateEntityId5;

		[SerializeField]
		private int _CreateEntityQuantity5;

		[SerializeField]
		private GiftType _DuplicateEntityType;

		[SerializeField]
		private int _DuplicateEntityId;

		[SerializeField]
		private int _DuplicateEntityQuantity;

		[SerializeField]
		private int _WeaponPassiveAbilityGroupId;

		[SerializeField]
		private int _WeaponBodyBuildupGroupId;

		[SerializeField]
		private int _MaxWeaponPassiveCharaCount;

		[SerializeField]
		private float _WeaponPassiveEffHp;

		[SerializeField]
		private float _WeaponPassiveEffAtk;

		[SerializeField]
		private int _RewardWeaponSkinId1;

		[SerializeField]
		private int _RewardWeaponSkinId2;

		[SerializeField]
		private int _RewardWeaponSkinId3;

		[SerializeField]
		private int _RewardWeaponSkinId4;

		[SerializeField]
		private int _RewardWeaponSkinId5;

		public int Id => default(int);

		public string Name => null;

		public int WeaponSeriesId => default(int);

		public int WeaponSkinId => default(int);

		public Gluon.WeaponType WeaponType => default(Gluon.WeaponType);

		public int Rarity => default(int);

		public Gluon.ElementalType ElementalType => default(Gluon.ElementalType);

		public int WeaponSkinId2 => default(int);

		public int MaxLimitOverCount => default(int);

		public int MaxEquipableCount => default(int);

		public int BaseHp => default(int);

		public int MaxHp1 => default(int);

		public int MaxHp2 => default(int);

		public int MaxHp3 => default(int);

		public int BaseAtk => default(int);

		public int MaxAtk1 => default(int);

		public int MaxAtk2 => default(int);

		public int MaxAtk3 => default(int);

		public int LimitOverCountPartyPower1 => default(int);

		public int LimitOverCountPartyPower2 => default(int);

		public int CrestSlotType1BaseCount => default(int);

		public int CrestSlotType1MaxCount => default(int);

		public int CrestSlotType2BaseCount => default(int);

		public int CrestSlotType2MaxCount => default(int);

		public int CrestSlotType3BaseCount => default(int);

		public int CrestSlotType3MaxCount => default(int);

		public int ChangeSkillId1 => default(int);

		public int ChangeSkillId2 => default(int);

		public int ChangeSkillId3 => default(int);

		public int Abilities11 => default(int);

		public int Abilities12 => default(int);

		public int Abilities13 => default(int);

		public int Abilities21 => default(int);

		public int Abilities22 => default(int);

		public int Abilities23 => default(int);

		public int IsPlayable => default(int);

		public string Text => null;

		public string CreateStartDate => null;

		public int NeedFortCraftLevel => default(int);

		public int NeedCreateWeaponBodyId1 => default(int);

		public int NeedCreateWeaponBodyId2 => default(int);

		public int NeedAllUnlockWeaponBodyId1 => default(int);

		public int CreateCoin => default(int);

		public GiftType CreateEntityType1 => default(GiftType);

		public int CreateEntityId1 => default(int);

		public int CreateEntityQuantity1 => default(int);

		public GiftType CreateEntityType2 => default(GiftType);

		public int CreateEntityId2 => default(int);

		public int CreateEntityQuantity2 => default(int);

		public GiftType CreateEntityType3 => default(GiftType);

		public int CreateEntityId3 => default(int);

		public int CreateEntityQuantity3 => default(int);

		public GiftType CreateEntityType4 => default(GiftType);

		public int CreateEntityId4 => default(int);

		public int CreateEntityQuantity4 => default(int);

		public GiftType CreateEntityType5 => default(GiftType);

		public int CreateEntityId5 => default(int);

		public int CreateEntityQuantity5 => default(int);

		public GiftType DuplicateEntityType => default(GiftType);

		public int DuplicateEntityId => default(int);

		public int DuplicateEntityQuantity => default(int);

		public int WeaponPassiveAbilityGroupId => default(int);

		public int WeaponBodyBuildupGroupId => default(int);

		public int MaxWeaponPassiveCharaCount => default(int);

		public float WeaponPassiveEffHp => default(float);

		public float WeaponPassiveEffAtk => default(float);

		public int RewardWeaponSkinId1 => default(int);

		public int RewardWeaponSkinId2 => default(int);

		public int RewardWeaponSkinId3 => default(int);

		public int RewardWeaponSkinId4 => default(int);

		public int RewardWeaponSkinId5 => default(int);
	}
}
