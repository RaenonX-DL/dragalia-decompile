/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi
{
	public class LeaderboardScoreData
	{
		// Fields
		private string mId;
		private ResponseStatus mStatus;
		private ulong mApproxCount;
		private string mTitle;
		private IScore mPlayerScore;
		private ScorePageToken mPrevPage;
		private ScorePageToken mNextPage;
		private List<PlayGamesScore> mScores;
	
		// Properties
		public bool Valid { get; }
		public ResponseStatus Status { get; internal set; }
		public ulong ApproximateCount { get; internal set; }
		public string Title { get; internal set; }
		public string Id { get; internal set; }
		public IScore PlayerScore { get; internal set; }
		public IScore[] Scores { get; }
		public ScorePageToken PrevPageToken { get; internal set; }
		public ScorePageToken NextPageToken { get; internal set; }
	
		// Constructors
		internal LeaderboardScoreData(string leaderboardId);
		internal LeaderboardScoreData(string leaderboardId, ResponseStatus status);
	
		// Methods
		internal int AddScore(PlayGamesScore score);
		public override string ToString();
	}
}
