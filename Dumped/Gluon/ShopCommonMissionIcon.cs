using System;
using System.Collections.Generic;
using Gluon.Mission.ListView;

namespace Gluon
{
	public class ShopCommonMissionIcon : MissionTableViewCell
	{
		private MissionTableViewData data;

		private static List<MissionTableViewData> specialMissionDataList;

		public Action<MissionTableViewData> onChallengeButtonCallback;

		public static void LoadAllSpecialMissions(Action onDone)
		{
		}

		public void SetupByShopContentData(ShopTradeProductData.CommonShopItemContentData contentData)
		{
		}

		public void OnIconPressed()
		{
		}

		private void OpenDetailPopup()
		{
		}
	}
}
