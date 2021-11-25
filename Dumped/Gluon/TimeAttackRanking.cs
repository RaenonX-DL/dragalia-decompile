using System.Collections.Generic;

namespace Gluon
{
	public class TimeAttackRanking
	{
		public class RankingInfo
		{
			public int rank;

			public bool isNew;

			public int eventId;

			public ulong viewerId;

			public int questId;

			public float clearTime;

			public int startTime;

			public int endTime;

			public string partyHash;

			public PartyInfo[] partyInfoList;
		}

		public class PartyInfo
		{
			public ulong viewerId;

			public int charaId;

			public int charaRarity;

			public int charaLevel;
		}

		public bool isRanking;

		public int eventId;

		public RankingInfo[] rankingInfoList;

		public List<QuestResultModel.QuestBonus.QuestBonusInfo> tierRewardInfoList;

		public void Load()
		{
		}

		public void LoadTierRewardList()
		{
		}
	}
}
