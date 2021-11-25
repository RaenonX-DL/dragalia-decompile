using System;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	internal class PlayGamesAchievement : IAchievement, IAchievementDescription
	{
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

		public bool isIncremental => default(bool);

		public int currentSteps => default(int);

		public int totalSteps => default(int);

		public double percentCompleted
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		public bool completed => default(bool);

		public bool hidden => default(bool);

		public DateTime lastReportedDate => default(DateTime);

		public string title => null;

		public Texture2D image => null;

		public string achievedDescription => null;

		public string unachievedDescription => null;

		public int points => default(int);

		internal PlayGamesAchievement()
		{
		}

		internal PlayGamesAchievement(ReportProgress progressCallback)
		{
		}

		internal PlayGamesAchievement(Achievement ach)
		{
		}

		public void ReportProgress(Action<bool> callback)
		{
		}

		private Texture2D LoadImage()
		{
			return null;
		}
	}
}
