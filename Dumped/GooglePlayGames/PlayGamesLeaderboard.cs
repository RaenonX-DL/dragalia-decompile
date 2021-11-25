using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesLeaderboard : ILeaderboard
	{
		private string mId;

		private UserScope mUserScope;

		private Range mRange;

		private TimeScope mTimeScope;

		private string[] mFilteredUserIds;

		private bool mLoading;

		private IScore mLocalUserScore;

		private uint mMaxRange;

		private List<PlayGamesScore> mScoreList;

		private string mTitle;

		public bool loading
		{
			get
			{
				return default(bool);
			}
			internal set
			{
			}
		}

		public string id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UserScope userScope
		{
			get
			{
				return default(UserScope);
			}
			set
			{
			}
		}

		public Range range
		{
			get
			{
				return default(Range);
			}
			set
			{
			}
		}

		public TimeScope timeScope
		{
			get
			{
				return default(TimeScope);
			}
			set
			{
			}
		}

		public IScore localUserScore => null;

		public uint maxRange => default(uint);

		public IScore[] scores => null;

		public string title => null;

		public int ScoreCount => default(int);

		public PlayGamesLeaderboard(string id)
		{
		}

		public void SetUserFilter(string[] userIDs)
		{
		}

		public void LoadScores(Action<bool> callback)
		{
		}

		internal bool SetFromData(LeaderboardScoreData data)
		{
			return default(bool);
		}

		internal void SetMaxRange(ulong val)
		{
		}

		internal void SetTitle(string value)
		{
		}

		internal void SetLocalUserScore(PlayGamesScore score)
		{
		}

		internal int AddScore(PlayGamesScore score)
		{
			return default(int);
		}

		internal bool HasAllScores()
		{
			return default(bool);
		}
	}
}
