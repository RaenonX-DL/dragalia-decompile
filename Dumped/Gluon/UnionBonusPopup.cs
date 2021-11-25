using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnionBonusPopup : CommonPopup
	{
		public class UnionBonusInfo
		{
			public int charaMasterId;

			public Rarity charaRarity;

			public List<CommonUnionAbilityData> abilityList;

			public UnionBonusInfo(int charaMasterId, Rarity charaRarity, List<CommonUnionAbilityData> abilityList)
			{
			}
		}

		private const string prefabPath = "Prefabs/OutGame/Party/Party/UnionBonusPopup";

		[SerializeField]
		private Text explainText;

		[SerializeField]
		[Header("Party UnionBonus")]
		private Transform unionBonusParent;

		[SerializeField]
		private UnionBonusUIChara unionBonusUIChara;

		[SerializeField]
		[Header("All UnionBonus")]
		private UnionBonusUIChara unionBonusCellBase;

		public static UnionBonusPopup Create()
		{
			return null;
		}

		public void InitSetting(List<UnionBonusInfo> unionBonusInfoList)
		{
		}

		public void InitSetting(List<UnionAbilityElement> unionBonusAbilityList)
		{
		}
	}
}
