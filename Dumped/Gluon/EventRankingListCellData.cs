using System.Collections.Generic;

namespace Gluon
{
	public class EventRankingListCellData
	{
		public class RankingPartyMemberInfo
		{
			public int userId;

			public string name;

			public int level;

			public int emblemId;

			public int charaId;

			public int charaLevel;

			public ulong dragonId;

			public ulong weaponId;

			public RankingPartyMemberInfo(int userId, string name, int level, int emblemId, int charaId, int charaLevel)
			{
			}
		}

		public int rank;

		public int clearTime;

		public List<RankingPartyMemberInfo> rankingMemberList;
	}
}
