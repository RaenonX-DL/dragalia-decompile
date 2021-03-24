/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RaidBoostPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public RaidBoostCell boostCell;
		public RaidBoostCell rareBoostCell;
		public EventAbilityCell eventCharaBoostCell;
		public CommonIcon eventCharaIcon;
		[Header]
		[SerializeField]
		public GameObject boostBlock;
		public GameObject rareBoostBlock;
		public GameObject eventCharaBoostBlock;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text eventCharaBoostText;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text bottomText;
		public const string prefabPath = "Prefabs/OutGame/EventQuest/RaidBoostPopup";
		private int eventId;
		public List<RaidBoostModel.CellData> boostList;
		public List<RaidBoostModel.CellData> rareBoostList;
		private List<AbilityDataElement> eventBoostList;
	
		// Nested types
		public static class RaidBoostModel
		{
			// Nested types
			public class CellData
			{
				// Fields
				private EventPassiveElement elem;
				private int progress;
	
				// Properties
				public int id { get; }
				public EventPassiveType passiveType { get; }
				public int partyPowerValue { get; }
				public int value { get; }
				public int maxVal { get; }
				public bool isRare { get; }
				public string itemName { get; }
				public string itemDetail { get; }
				public string abilityImage { get; }
				public string processTextTemplate { get; }
	
				// Constructors
				public CellData(int masterId, int progress);
				public CellData(EventPassiveElement elem, int progress);
	
				// Methods
				public MatchingRoomPlayerData.RaidBoostSyncData GetSyncData();
				public Material GetIconMat(IconLoader.Size size = IconLoader.Size.M);
			}
	
			// Methods
			private static List<CellData> GetRaidBoostListByRarity(int eventId, bool isRare, AtgenEventPassiveUpList[] specificList = null);
			private static List<AbilityDataElement> GetEventCharaBoostListData(int eventId);
			public static int GetDroppedEventId();
			public static List<CellData> GetDroppedRaidBoost();
			public static bool IsAnyRaidBoostDropped();
			public static List<CellData> GetDroppedRareRaidBoost();
			public static List<CellData> GetRaidBoostList(int eventId);
			public static List<CellData> GetRareRaidBoostList(int eventId);
			public static List<AbilityDataElement> GetEventCharaBoostList(int eventId);
			public static string GetEventCharaName(int eventId);
		}
	
		// Constructors
		public RaidBoostPopup();
	
		// Methods
		public static RaidBoostPopup Create(int eventId);
		public static RaidBoostPopup Create(int eventId, List<RaidBoostModel.CellData> boostList, List<RaidBoostModel.CellData> rareBoostList);
		public static RaidBoostPopup Create(int eventId, List<RaidBoostModel.CellData> boostList, List<RaidBoostModel.CellData> rareBoostList, List<AbilityDataElement> eventBoostList);
		protected override void Start();
	}
}
