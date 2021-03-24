/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames
{
	internal class PlayGamesAchievement : IAchievement, IAchievementDescription
	{
		// Fields
		private readonly ReportProgress mProgressCallback;
		private string mId;
		private bool mIsIncremental;
		private int mCurrentSteps;
		private int mTotalSteps;
		private double mPercentComplete;
		private bool mCompleted;
		private bool mHidden;
		private DateTime mLastModifiedTime;
		private string mTitle;
		private string mRevealedImageUrl;
		private string mUnlockedImageUrl;
		private UnityWebRequest mImageFetcher;
		private Texture2D mImage;
		private string mDescription;
		private ulong mPoints;
	
		// Properties
		public string id { get; set; }
		public bool isIncremental { get; }
		public int currentSteps { get; }
		public int totalSteps { get; }
		public double percentCompleted { get; set; }
		public bool completed { get; }
		public bool hidden { get; }
		public DateTime lastReportedDate { get; }
		public string title { get; }
		public Texture2D image { get; }
		public string achievedDescription { get; }
		public string unachievedDescription { get; }
		public int points { get; }
	
		// Constructors
		internal PlayGamesAchievement();
		internal PlayGamesAchievement(ReportProgress progressCallback);
		internal PlayGamesAchievement(Achievement ach);
	
		// Methods
		public void ReportProgress(Action<bool> callback);
		private Texture2D LoadImage();
	}
}
