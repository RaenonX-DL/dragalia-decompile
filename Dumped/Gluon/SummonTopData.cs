using System.Collections.Generic;
using Gluon.Http;

namespace Gluon
{
	public class SummonTopData
	{
		public class SwitchableSummonInfo
		{
			public int summonId;
		}

		public List<SummonTopItemData> starlegendSummonItems;

		public List<SummonTopItemData> normalSummonItems;

		public List<SummonTopItemData> charaSsrSummonItems;

		public List<SummonTopItemData> platinumSummonItems;

		public List<SummonTopItemData> dragonSsrSummonItems;

		public List<SummonTopItemData> campaginSsrSummonItems;

		public List<SummonTopItemData> charaSsrUpdateSummonItems;

		public List<SummonTopItemData> dragonSsrUpdateSummonItems;

		public List<SummonTopItemData> excludeSsrSummonItems;

		public List<SummonTopItemData> csStarlegendSummonItems;

		public List<SummonTopItemData> csNormalSummonItems;

		public List<SummonTopItemData> csPlatinumSummonItems;

		public List<SummonTopItemData> csCampaginSsrSummonItems;

		public List<SummonTopItemData> csExcludeSsrSummonItems;

		public SummonTopItemData topItemDataForPointTrade;

		public bool isCSSummonExist;

		public int ownedPaidStoneCount => default(int);

		public int ownedFreeStoneCount => default(int);

		public int ownedSingleTicketCount => default(int);

		public int ownedMultiTicketCount => default(int);

		public void UpdateDataFromResponse()
		{
		}

		public void ClearAllTopItemDataLists()
		{
		}

		public List<SwitchableSummonInfo> CreateCSSummonList(int currentSummonId)
		{
			return null;
		}

		public void RefreshSummonList()
		{
		}

		public void UpdateDataFromResponse(SummonRequestResponse res)
		{
		}
	}
}
