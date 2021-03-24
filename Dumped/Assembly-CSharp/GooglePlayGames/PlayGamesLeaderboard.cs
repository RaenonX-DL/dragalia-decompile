/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames
{
	public class PlayGamesLeaderboard : ILeaderboard
	{
		// Fields
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
	
		// Properties
		public bool loading { get; internal set; }
		public string id { get; set; }
		public UserScope userScope { get; set; }
		public Range range { get; set; }
		public TimeScope timeScope { get; set; }
		public IScore localUserScore { get; }
		public uint maxRange { get; }
		public IScore[] scores { get; }
		public string title { get; }
		public int ScoreCount { get; }
	
		// Constructors
		public PlayGamesLeaderboard(string id);
	
		// Methods
		public void SetUserFilter(string[] userIDs);
		public void LoadScores(Action<bool> callback);
		internal bool SetFromData(LeaderboardScoreData data);
		internal void SetMaxRange(ulong val);
		internal void SetTitle(string value);
		internal void SetLocalUserScore(PlayGamesScore score);
		internal int AddScore(PlayGamesScore score);
		internal bool HasAllScores();
	}
}
