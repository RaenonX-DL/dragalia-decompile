using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultRaidBoostPopup : PopupBase
	{
		[SerializeField]
		[Header("Copy")]
		public RaidBoostCell boostCell;

		public RaidBoostCell rareBoostCell;

		[SerializeField]
		[Header("Text")]
		public Text comment;

		public const string prefabPath = "Prefabs/OutGame/QuestResult/Popup/QuestResultRaidBoostPopup";

		private const string flashPath = "Prefabs/OutGame/QuestResult/pf_QuestResultRareRaidBoost";

		public static QuestResultRaidBoostPopup Create()
		{
			return null;
		}

		public static bool IsRaidBoostDropped()
		{
			return default(bool);
		}

		private List<RaidBoostPopup.RaidBoostModel.CellData> GetRaidBoostList()
		{
			return null;
		}

		private List<RaidBoostPopup.RaidBoostModel.CellData> GetRareBoostList()
		{
			return null;
		}

		protected override void Start()
		{
		}
	}
}
