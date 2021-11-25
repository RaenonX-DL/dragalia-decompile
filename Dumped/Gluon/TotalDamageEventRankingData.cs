namespace Gluon
{
	public class TotalDamageEventRankingData
	{
		public class RankingInfo
		{
			public int rank;

			public bool isNew;

			public long damageValue;

			public int charaId;

			public int charaRarity;

			public int charaLevel;

			public int charaMaxLevel;
		}

		public bool isRanking;

		public int eventId;

		public RankingInfo[] rankingInfoList;

		private static readonly int rankingTopShowCount;

		public void Load()
		{
		}
	}
}
