using System;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesScore : IScore
	{
		private string mLbId;

		private long mValue;

		private ulong mRank;

		private string mPlayerId;

		private string mMetadata;

		private DateTime mDate;

		public string leaderboardID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long value
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public DateTime date => default(DateTime);

		public string formattedValue => null;

		public string userID => null;

		public int rank => default(int);

		public string metaData => null;

		internal PlayGamesScore(DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
		{
		}

		public void ReportScore(Action<bool> callback)
		{
		}
	}
}
