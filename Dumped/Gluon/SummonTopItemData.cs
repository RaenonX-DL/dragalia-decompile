using System.Collections.Generic;
using Gluon.Http;

namespace Gluon
{
	public class SummonTopItemData
	{
		public enum ButtonType
		{
			None,
			Daily,
			SingleStoneOrTicket,
			MultiStoneOrTicket,
			SingleTicket,
			MultiTicket,
			StarLegend,
			SingleStone,
			MultiStone,
			CharaSsrTicket,
			Platinum,
			DragonSsrTicket,
			FreeMulti,
			BeginnerFreeMulti,
			Tutorial,
			CampaginTicket,
			manyFreeMulti,
			CharaSsrUpdateTicket,
			DragonSsrUpdateTicket,
			Exclude
		}

		public class PickupInfo
		{
			public int masterOrderIndex;

			public int resourceIndex;

			public int id;

			public GiftType giftType;

			public PickupInfo()
			{
			}

			public PickupInfo(int masterOrderIndex, int resourceIndex, int unitType, int id)
			{
			}

			private GiftType UnitTypeToGiftType(int unitType)
			{
				return default(GiftType);
			}
		}

		public bool hasCoverView;

		public int summonId;

		public int summonGroupId;

		public int summonPoint;

		public SummonType summonType;

		public int dailyPrice;

		public int singlePrice;

		public int multiPrice;

		public int haveExchangeSummonPoint;

		public int nessearyExchangeSummonPoint;

		public bool isExchangeSummon;

		public int addSummonPoint;

		public int addSummonPointStone;

		public bool isCSSummon;

		public int startTime;

		public int endTime;

		public bool bDailyDrawn;

		public bool bReachLimit;

		public int remainDrawableCount;

		public CampaignType campaignType;

		public int freeCountRest;

		public bool isBeginnerCampaign;

		public int beginnerCampaginCountRest;

		public int consecutionCampaginCountRest;

		public int campaginCountRest;

		public List<PickupInfo> pickupInfo;

		public void UpdateDataFromResponse(SummonList atgenSummonList)
		{
		}

		public int GetCurrentPlatinumIndex()
		{
			return default(int);
		}
	}
}
