/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi
{
	public class Achievement
	{
		// Fields
		private static readonly DateTime UnixEpoch;
		private string mId;
		private bool mIsIncremental;
		private bool mIsRevealed;
		private bool mIsUnlocked;
		private int mCurrentSteps;
		private int mTotalSteps;
		private string mDescription;
		private string mName;
		private long mLastModifiedTime;
		private ulong mPoints;
		private string mRevealedImageUrl;
		private string mUnlockedImageUrl;
	
		// Properties
		public bool IsIncremental { get; set; }
		public int CurrentSteps { get; set; }
		public int TotalSteps { get; set; }
		public bool IsUnlocked { get; set; }
		public bool IsRevealed { get; set; }
		public string Id { get; set; }
		public string Description { get; set; }
		public string Name { get; set; }
		public DateTime LastModifiedTime { get; set; }
		public ulong Points { get; set; }
		public string RevealedImageUrl { get; set; }
		public string UnlockedImageUrl { get; set; }
	
		// Constructors
		public Achievement();
		static Achievement();
	
		// Methods
		public override string ToString();
	}
}
