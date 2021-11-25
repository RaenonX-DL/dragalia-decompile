using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class EventBonusPopup : CommonPopup
	{
		public class EventBonusCharaInfo
		{
			public int charaMasterId;

			public Rarity charaRarity;

			public List<EventBonusAbilityInfo> abilityList;

			public EventBonusCharaInfo()
			{
			}

			public EventBonusCharaInfo(int charaMasterId, Rarity charaRarity, List<EventBonusAbilityInfo> abilityList)
			{
			}
		}

		public class EventBonusAbilityInfo
		{
			public int equipMasterId;

			public AbilityConst.UnitType equipGiftType;

			public UnitDetailModel.DetailDataBase.SkillAbilityInfo abilityInfo;

			public EventBonusAbilityInfo()
			{
			}

			public EventBonusAbilityInfo(int equipMasterId, AbilityConst.UnitType equipGiftType, UnitDetailModel.DetailDataBase.SkillAbilityInfo abilityInfo)
			{
			}
		}

		private const string prefabPath = "Prefabs/OutGame/Party/Party/EventBonusPopup";

		public GameObject charaBonusBase;

		public EventBonusUIChara charaBonus;

		public GameObject otherBonusBase;

		public EventBonusUIOther otherBonus;

		[SerializeField]
		[Header("RaidBoost")]
		public RaidBoostCell boostCell;

		public RaidBoostCell rareBoostCell;

		[SerializeField]
		[Header("RaidBoostBlocks")]
		public GameObject boostBlock;

		public GameObject rareBoostBlock;

		[HideInInspector]
		public bool isHideRaidBoost;

		public static EventBonusPopup Create()
		{
			return null;
		}

		public void InitSetting(List<EventBonusCharaInfo> abilityInfoList, int questId = -1)
		{
		}

		private GameObject CreateInstance(GameObject obj, Transform parent)
		{
			return null;
		}

		private void SetText(GameObject obj, string titleStr)
		{
		}
	}
}
