/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.SocialPlatforms;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames
{
	public class PlayGamesScore : IScore
	{
		// Fields
		private string mLbId;
		private long mValue;
		private ulong mRank;
		private string mPlayerId;
		private string mMetadata;
		private DateTime mDate;
	
		// Properties
		public string leaderboardID { get; set; }
		public long value { get; set; }
		public DateTime date { get; }
		public string formattedValue { get; }
		public string userID { get; }
		public int rank { get; }
		public string metaData { get; }
	
		// Constructors
		internal PlayGamesScore(DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata);
	
		// Methods
		public void ReportScore(Action<bool> callback);
	}
}
