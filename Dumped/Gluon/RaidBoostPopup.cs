using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RaidBoostPopup : PopupBase
	{
		public static class RaidBoostModel
		{
			public class CellData
			{
				private EventPassiveElement elem;

				private int progress;

				public int id => default(int);

				public EventPassiveType passiveType => default(EventPassiveType);

				public int partyPowerValue => default(int);

				public int value => default(int);

				public int maxVal => default(int);

				public bool isRare => default(bool);

				public string itemName => null;

				public string itemDetail => null;

				public string abilityImage => null;

				public string processTextTemplate => null;

				public MatchingRoomPlayerData.RaidBoostSyncData GetSyncData()
				{
					return default(MatchingRoomPlayerData.RaidBoostSyncData);
				}

				public CellData(int masterId, int progress)
				{
				}

				public CellData(EventPassiveElement elem, int progress)
				{
				}

				public Material GetIconMat(IconLoader.Size size = IconLoader.Size.M)
				{
					return null;
				}
			}

			public class RaidEventAbilityChara
			{
				public int charaId;

				public AbilityDataElement[] eventBoostList;
			}

			private static List<CellData> GetRaidBoostListByRarity(int eventId, bool isRare, [Optional] AtgenEventPassiveUpList[] specificList)
			{
				return null;
			}

			private static List<AbilityDataElement> GetEventCharaBoostListData(int eventId)
			{
				return null;
			}

			public static List<RaidEventAbilityChara> GetRaidEventAbilityCharaList()
			{
				return null;
			}

			public static int GetDroppedEventId()
			{
				return default(int);
			}

			public static List<CellData> GetDroppedRaidBoost()
			{
				return null;
			}

			public static bool IsAnyRaidBoostDropped()
			{
				return default(bool);
			}

			public static List<CellData> GetDroppedRareRaidBoost()
			{
				return null;
			}

			public static List<CellData> GetRaidBoostList(int eventId)
			{
				return null;
			}

			public static List<CellData> GetRareRaidBoostList(int eventId)
			{
				return null;
			}

			public static List<AbilityDataElement> GetEventCharaBoostList(int eventId)
			{
				return null;
			}

			public static string GetEventCharaName(int eventId)
			{
				return null;
			}
		}

		[SerializeField]
		[Header("Copy")]
		public RaidBoostCell boostCell;

		public RaidBoostCell rareBoostCell;

		public RaidBoostEventCharaCell raidBoostEventBoostCharaCell;

		public RaidBoostEventCharaCell raidBoostEventCharaCell;

		[SerializeField]
		[Header("Blocks")]
		public GameObject boostBlock;

		public GameObject rareBoostBlock;

		public GameObject eventCharaBoostBlock;

		[SerializeField]
		[Header("Title")]
		public Text eventCharaBoostText;

		[SerializeField]
		[Header("BottomText")]
		public Text bottomText;

		[SerializeField]
		[Header("Tab")]
		private TabBase typeTab;

		[SerializeField]
		private RectTransform normalEventScrollView;

		[SerializeField]
		protected Transform parentTransform;

		public const string prefabPath = "Prefabs/OutGame/EventQuest/RaidBoostPopup";

		private readonly Vector3 normalEventScrollViewPosition;

		private readonly Vector3 normalEventScrollViewSizeDelta;

		private readonly Vector3 specialEventScrollViewPosition;

		private readonly Vector3 specialEventScrollViewSizeDelta;

		private int eventId;

		public List<RaidBoostModel.CellData> boostList;

		public List<RaidBoostModel.CellData> rareBoostList;

		private List<AbilityDataElement> eventBoostList;

		private List<RaidBoostModel.RaidEventAbilityChara> raidEventAbilityCharaList;

		private static int GetEventJoinCharaId(int eventId)
		{
			return default(int);
		}

		public static RaidBoostPopup Create(int eventId)
		{
			return null;
		}

		public static RaidBoostPopup Create(int eventId, List<RaidBoostModel.CellData> boostList, List<RaidBoostModel.CellData> rareBoostList)
		{
			return null;
		}

		public static RaidBoostPopup Create(int eventId, List<RaidBoostModel.CellData> boostList, List<RaidBoostModel.CellData> rareBoostList, List<AbilityDataElement> eventBoostList)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void OnSelectedTypeTab(int activeIndex)
		{
		}
	}
}
