using System.Collections.Generic;

namespace Gluon
{
	public class MatchingRoomPlayerData
	{
		public struct RaidBoostSyncData
		{
			public int masterId;

			public int progress;

			public RaidBoostSyncData(int masterId, int progress)
			{
			}
		}

		public struct CharaSimpleSyncData
		{
			public int charaId;

			public int charaRarity;

			public int exAbility1Id;

			public int exAbility2Id;
		}

		public string playerName;

		public int playerAnotherNameId;

		public int partySlot;

		public MatchingRoomDetailData[] detailData;

		public int teamPower;

		public ulong viewerId;

		public List<RaidBoostSyncData> raidBoostSyncDatas;

		public int teamPowerPT2;

		public List<CharaSimpleSyncData> charaSimpleSyncDatas1;

		public List<CharaSimpleSyncData> charaSimpleSyncDatas2;

		public void CopyFromData(MatchingRoomPlayerData data)
		{
		}
	}
}
