using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Http;

namespace Gluon
{
	public class MatchingRoomSearchCondition
	{
		public int QuestId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Priority
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<MatchingRoomPlayerData> AllPartyRoomData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Clear()
		{
		}

		public string ToSql()
		{
			return null;
		}

		public static string GetSqlFromPartyData(MatchingRoomPlayerData partyData, bool isRaid)
		{
			return null;
		}

		public static bool IsSameElementalParty(MatchingRoomPlayerData partyData)
		{
			return default(bool);
		}

		public static RoomEntryCondition GetRoomEntryCondition(RoomList room)
		{
			return null;
		}

		public static bool CanJoinConditionalRoom(int questId, RoomEntryCondition condition, MatchingRoomPlayerData partyData)
		{
			return default(bool);
		}
	}
}
