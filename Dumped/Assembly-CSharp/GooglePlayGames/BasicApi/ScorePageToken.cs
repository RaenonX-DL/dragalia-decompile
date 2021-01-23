/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi
{
	public class ScorePageToken
	{
		// Fields
		private string mId;
		private object mInternalObject;
		private LeaderboardCollection mCollection;
		private LeaderboardTimeSpan mTimespan;
		private ScorePageDirection mDirection;
	
		// Properties
		public LeaderboardCollection Collection { get; }
		public LeaderboardTimeSpan TimeSpan { get; }
		public ScorePageDirection Direction { get; }
		public string LeaderboardId { get; }
		internal object InternalObject { get; }
	
		// Constructors
		internal ScorePageToken(object internalObject, string id, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ScorePageDirection direction);
	}
}
