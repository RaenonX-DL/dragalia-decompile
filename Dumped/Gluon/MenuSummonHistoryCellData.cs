using Gluon.Http;

namespace Gluon
{
	public class MenuSummonHistoryCellData
	{
		public enum SummonType
		{
			SummonMulti,
			SummonSingle,
			SummonOnceaDay,
			SummonFreeSingle,
			SummonFreeMulti,
			SummonBeginnerCampaign,
			SummonScratchCampaign
		}

		public enum SummonPaymentType
		{
			None,
			Diamond,
			Crystal,
			SummonTicket,
			SummonTicketTen,
			CharaSsrTicket,
			DragonSsrTicket,
			CharaSsrUpdateTicket,
			DragonSsrUpdateTicket
		}

		public string unitName;

		public string summonDateTime;

		public string summonName;

		public SummonType summonType;

		public SummonPaymentType summonPaymentType;

		public Rarity summonRarity;

		public int summonDewPoint;

		public int summonPrizePoint;

		public GiftType summonGiftType;

		public int summonPoint;

		public void Load(SummonHistoryList data)
		{
		}

		private string GetSummonUnitName(SummonHistoryList data)
		{
			return null;
		}

		private string GetSummonTitle(SummonHistoryList data)
		{
			return null;
		}

		private SummonType GetSummonType(SummonHistoryList data)
		{
			return default(SummonType);
		}

		private SummonPaymentType GetSummonPaymentType(SummonHistoryList data)
		{
			return default(SummonPaymentType);
		}

		private string UnixTimeToStringLongSpace(double unixtime)
		{
			return null;
		}
	}
}
