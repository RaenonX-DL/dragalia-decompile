using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class QuestPartySwitchModel
	{
		[Flags]
		public enum LimitedElementalFlags
		{
			Party1Character = 0x1,
			Party1Dragon = 0x2,
			Party2Character = 0x4,
			Party2Dragon = 0x8,
			Max = 0x10
		}

		public class UnFulfilledUnitData
		{
			public int partyNo;

			public int unitId;

			public ulong keyId;

			public int equipCharaId;

			public GiftType unitType;

			public UnFulfilledUnitData(int unitId, ulong keyId, int equipCharaId, GiftType unitType, int partyNo = 1)
			{
			}

			public UnFulfilledUnitData()
			{
			}
		}

		public bool isFullMember;

		public bool isUnFulfilledLimitedElemental;

		public List<UnFulfilledUnitData> unFulfilledCharacterDataList;

		public List<UnFulfilledUnitData> unFulfilledWeaponDataList;

		public List<UnFulfilledUnitData> unFulfilledDragonDataList;

		public List<UnFulfilledUnitData> unFulfilledAbilityCrestDataList;

		public List<UnFulfilledUnitData> unFulfilledTalismanDataList;

		public LimitedElementalFlags limitedElementalFlag;

		public ElementalType limitedElementalType1;

		public ElementalType limitedElementalType2;

		private PartySettingList[] party1;

		private PartySettingList[] party2;

		private Dictionary<int, Material> charaIconMaterialList;

		private Dictionary<int, Material> weaponIconMaterialList;

		private Dictionary<int, Material> dragonIconMaterialList;

		private Dictionary<int, Material> abilityCrestIconMaterialList;

		private Dictionary<int, Material> talismanIconMaterialList;

		private int questId;

		public bool CanStartPartySwitchQuest()
		{
			return default(bool);
		}

		public void SettingData(PartySettingList[] party1, PartySettingList[] party2)
		{
		}

		public void SettingData(int questId)
		{
		}

		private static bool IsFullMember(PartySettingList[] allPartyData)
		{
			return default(bool);
		}

		private LimitedElementalFlags CreateLimitedElementalFlag()
		{
			return default(LimitedElementalFlags);
		}

		private List<UnFulfilledUnitData> FilterUnFulfilledCharacter(PartySettingList[] allPartyData)
		{
			return null;
		}

		private List<UnFulfilledUnitData> FilterUnFulfilledWeapon(PartySettingList[] allPartyData)
		{
			return null;
		}

		private List<UnFulfilledUnitData> FilterUnFulfilledDragon(PartySettingList[] allPartyData)
		{
			return null;
		}

		private List<UnFulfilledUnitData> FilterUnFulfilledAbilityCrest(PartySettingList[] allPartyData)
		{
			return null;
		}

		private List<UnFulfilledUnitData> FilterUnFulfilledTalisman(PartySettingList[] allPartyData)
		{
			return null;
		}

		private List<int> GetPartyCharaIdList()
		{
			return null;
		}

		public void LoadMaterials()
		{
		}

		public void DestroyMaterials()
		{
		}

		public Material GetMaterial(GiftType type, int id)
		{
			return null;
		}

		public static bool IsPartySwitchQuest(int questId)
		{
			return default(bool);
		}

		private bool IsLimitedElementalTypeEnoughCharacter([In] ref PartySettingList[] party, ElementalType limitedElementalType)
		{
			return default(bool);
		}

		private bool IsLimitedElementalTypeEnoughDragon([In] ref PartySettingList[] party, ElementalType limitedElementalType)
		{
			return default(bool);
		}

		public static bool IsCurrentClearParty()
		{
			return default(bool);
		}
	}
}
