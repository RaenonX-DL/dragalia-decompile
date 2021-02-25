/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestPartySwitchModel
	{
		// Fields
		public bool isFullMember;
		public bool isUnFulfilledLimitedElemental;
		public List<UnFulfilledUnitData> unFulfilledCharacterDataList;
		public List<UnFulfilledUnitData> unFulfilledWeaponDataList;
		public List<UnFulfilledUnitData> unFulfilledDragonDataList;
		public List<UnFulfilledUnitData> unFulfilledAbilityCrestDataList;
		public LimitedElementalFlags limitedElementalFlag;
		public ElementalType limitedElementalType1;
		public ElementalType limitedElementalType2;
		private PartySettingList[] party1;
		private PartySettingList[] party2;
		private Dictionary<int, Material> charaIconMaterialList;
		private Dictionary<int, Material> weaponIconMaterialList;
		private Dictionary<int, Material> dragonIconMaterialList;
		private Dictionary<int, Material> abilityCrestIconMaterialList;
		private int questId;
	
		// Nested types
		[Flags]
		public enum LimitedElementalFlags
		{
			Party1Character = 1,
			Party1Dragon = 2,
			Party2Character = 4,
			Party2Dragon = 8,
			Max = 16
		}
	
		public class UnFulfilledUnitData
		{
			// Fields
			public int partyNo;
			public int unitId;
			public int equipCharaId;
			public GiftType unitType;
	
			// Constructors
			public UnFulfilledUnitData(int unitId, int equipCharaId, GiftType unitType, int partyNo = 1);
			public UnFulfilledUnitData();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<UnFulfilledUnitData, int> __9__19_0;
			public static Func<UnFulfilledUnitData, int> __9__19_1;
			public static Func<UnFulfilledUnitData, int> __9__19_2;
			public static Func<UnFulfilledUnitData, int> __9__19_3;
			public static Func<UnFulfilledUnitData, int> __9__19_4;
			public static Func<UnFulfilledUnitData, int> __9__19_5;
			public static Func<UnFulfilledUnitData, int> __9__19_6;
			public static Func<UnFulfilledUnitData, int> __9__19_7;
			public static Func<KeyValuePair<int, int>, bool> __9__23_0;
			public static Func<KeyValuePair<int, int>, bool> __9__24_0;
			public static Func<KeyValuePair<ulong, int>, bool> __9__25_0;
			public static Func<KeyValuePair<ulong, int>, ulong> __9__25_1;
			public static Func<KeyValuePair<int, int>, bool> __9__26_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SettingData_b__19_0(UnFulfilledUnitData data);
			internal int _SettingData_b__19_1(UnFulfilledUnitData data);
			internal int _SettingData_b__19_2(UnFulfilledUnitData data);
			internal int _SettingData_b__19_3(UnFulfilledUnitData data);
			internal int _SettingData_b__19_4(UnFulfilledUnitData data);
			internal int _SettingData_b__19_5(UnFulfilledUnitData data);
			internal int _SettingData_b__19_6(UnFulfilledUnitData data);
			internal int _SettingData_b__19_7(UnFulfilledUnitData data);
			internal bool _FilterUnFulfilledCharacter_b__23_0(KeyValuePair<int, int> charaCount);
			internal bool _FilterUnFulfilledWeapon_b__24_0(KeyValuePair<int, int> weaponCount);
			internal bool _FilterUnFulfilledDragon_b__25_0(KeyValuePair<ulong, int> dragonCount);
			internal ulong _FilterUnFulfilledDragon_b__25_1(KeyValuePair<ulong, int> dragonCountData);
			internal bool _FilterUnFulfilledAbilityCrest_b__26_0(KeyValuePair<int, int> abilityCrestCount);
		}
	
		// Constructors
		public QuestPartySwitchModel();
	
		// Methods
		public bool CanStartPartySwitchQuest();
		public void SettingData(PartySettingList[] party1, PartySettingList[] party2);
		public void SettingData(int questId);
		private static bool IsFullMember(PartySettingList[] allPartyData);
		private LimitedElementalFlags CreateLimitedElementalFlag();
		private List<UnFulfilledUnitData> FilterUnFulfilledCharacter(PartySettingList[] allPartyData);
		private List<UnFulfilledUnitData> FilterUnFulfilledWeapon(PartySettingList[] allPartyData);
		private List<UnFulfilledUnitData> FilterUnFulfilledDragon(PartySettingList[] allPartyData);
		private List<UnFulfilledUnitData> FilterUnFulfilledAbilityCrest(PartySettingList[] allPartyData);
		private List<int> GetPartyCharaIdList();
		public void LoadMaterials();
		public void DestroyMaterials();
		public Material GetMaterial(GiftType type, int id);
		public static bool IsPartySwitchQuest(int questId);
		private bool IsLimitedElementalTypeEnoughCharacter([IsReadOnly] in PartySettingList[] party, ElementalType limitedElementalType);
		private bool IsLimitedElementalTypeEnoughDragon([IsReadOnly] in PartySettingList[] party, ElementalType limitedElementalType);
		public static bool IsCurrentClearParty();
	}
}
