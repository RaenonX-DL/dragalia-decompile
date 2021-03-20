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
	public class WeaponBodyElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Name;
		[SerializeField]
		private int _WeaponSeriesId;
		[SerializeField]
		private int _WeaponSkinId;
		[SerializeField]
		private WeaponType _WeaponType;
		[SerializeField]
		private int _Rarity;
		[SerializeField]
		private ElementalType _ElementalType;
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
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public int WeaponSeriesId { get; }
		public int WeaponSkinId { get; }
		public WeaponType WeaponType { get; }
		public int Rarity { get; }
		public ElementalType ElementalType { get; }
		public int WeaponSkinId2 { get; }
		public int MaxLimitOverCount { get; }
		public int MaxEquipableCount { get; }
		public int BaseHp { get; }
		public int MaxHp1 { get; }
		public int MaxHp2 { get; }
		public int MaxHp3 { get; }
		public int BaseAtk { get; }
		public int MaxAtk1 { get; }
		public int MaxAtk2 { get; }
		public int MaxAtk3 { get; }
		public int LimitOverCountPartyPower1 { get; }
		public int LimitOverCountPartyPower2 { get; }
		public int CrestSlotType1BaseCount { get; }
		public int CrestSlotType1MaxCount { get; }
		public int CrestSlotType2BaseCount { get; }
		public int CrestSlotType2MaxCount { get; }
		public int ChangeSkillId1 { get; }
		public int ChangeSkillId2 { get; }
		public int ChangeSkillId3 { get; }
		public int Abilities11 { get; }
		public int Abilities12 { get; }
		public int Abilities13 { get; }
		public int Abilities21 { get; }
		public int Abilities22 { get; }
		public int Abilities23 { get; }
		public int IsPlayable { get; }
		public string Text { get; }
		public string CreateStartDate { get; }
		public int NeedFortCraftLevel { get; }
		public int NeedCreateWeaponBodyId1 { get; }
		public int NeedCreateWeaponBodyId2 { get; }
		public int NeedAllUnlockWeaponBodyId1 { get; }
		public int CreateCoin { get; }
		public GiftType CreateEntityType1 { get; }
		public int CreateEntityId1 { get; }
		public int CreateEntityQuantity1 { get; }
		public GiftType CreateEntityType2 { get; }
		public int CreateEntityId2 { get; }
		public int CreateEntityQuantity2 { get; }
		public GiftType CreateEntityType3 { get; }
		public int CreateEntityId3 { get; }
		public int CreateEntityQuantity3 { get; }
		public GiftType CreateEntityType4 { get; }
		public int CreateEntityId4 { get; }
		public int CreateEntityQuantity4 { get; }
		public GiftType CreateEntityType5 { get; }
		public int CreateEntityId5 { get; }
		public int CreateEntityQuantity5 { get; }
		public GiftType DuplicateEntityType { get; }
		public int DuplicateEntityId { get; }
		public int DuplicateEntityQuantity { get; }
		public int WeaponPassiveAbilityGroupId { get; }
		public int WeaponBodyBuildupGroupId { get; }
		public int MaxWeaponPassiveCharaCount { get; }
		public float WeaponPassiveEffHp { get; }
		public float WeaponPassiveEffAtk { get; }
		public int RewardWeaponSkinId1 { get; }
		public int RewardWeaponSkinId2 { get; }
		public int RewardWeaponSkinId3 { get; }
		public int RewardWeaponSkinId4 { get; }
		public int RewardWeaponSkinId5 { get; }
	
		// Constructors
		public WeaponBodyElement();
	}
}
