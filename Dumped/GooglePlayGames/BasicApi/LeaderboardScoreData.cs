using System.Collections.Generic;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	public class LeaderboardScoreData
	{
		private string mId;

		private ResponseStatus mStatus;

		private ulong mApproxCount;

		private string mTitle;

		private IScore mPlayerScore;

		private ScorePageToken mPrevPage;

		private ScorePageToken mNextPage;

		private List<PlayGamesScore> mScores;

		public bool Valid => default(bool);

		public ResponseStatus Status
		{
			get
			{
				return default(ResponseStatus);
			}
			internal set
			{
			}
		}

		public ulong ApproximateCount
		{
			get
			{
				return default(ulong);
			}
			internal set
			{
			}
		}

		public string Title
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Id
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public IScore PlayerScore
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public IScore[] Scores => null;

		public ScorePageToken PrevPageToken
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public ScorePageToken NextPageToken
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal LeaderboardScoreData(string leaderboardId)
		{
		}

		internal LeaderboardScoreData(string leaderboardId, ResponseStatus status)
		{
		}

		internal int AddScore(PlayGamesScore score)
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
