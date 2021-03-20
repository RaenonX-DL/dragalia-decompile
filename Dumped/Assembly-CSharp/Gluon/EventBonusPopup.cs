/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventBonusPopup : CommonPopup
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Party/Party/EventBonusPopup";
		public GameObject charaBonusBase;
		public EventBonusUIChara charaBonus;
		public GameObject otherBonusBase;
		public EventBonusUIOther otherBonus;
		[Header]
		[SerializeField]
		public RaidBoostCell boostCell;
		public RaidBoostCell rareBoostCell;
		[Header]
		[SerializeField]
		public GameObject boostBlock;
		public GameObject rareBoostBlock;
	
		// Nested types
		public class EventBonusCharaInfo
		{
			// Fields
			public int charaMasterId;
			public Rarity charaRarity;
			public List<EventBonusAbilityInfo> abilityList;
	
			// Constructors
			public EventBonusCharaInfo();
			public EventBonusCharaInfo(int charaMasterId, Rarity charaRarity, List<EventBonusAbilityInfo> abilityList);
		}
	
		public class EventBonusAbilityInfo
		{
			// Fields
			public int equipMasterId;
			public AbilityConst.UnitType equipGiftType;
			public UnitDetailModel.DetailDataBase.SkillAbilityInfo abilityInfo;
	
			// Constructors
			public EventBonusAbilityInfo();
			public EventBonusAbilityInfo(int equipMasterId, AbilityConst.UnitType equipGiftType, UnitDetailModel.DetailDataBase.SkillAbilityInfo abilityInfo);
		}
	
		// Constructors
		public EventBonusPopup();
	
		// Methods
		public static EventBonusPopup Create();
		public void InitSetting(List<EventBonusCharaInfo> abilityInfoList, int questId = -1);
		private GameObject CreateInstance(GameObject obj, Transform parent);
		private void SetText(GameObject obj, string titleStr);
	}
}
