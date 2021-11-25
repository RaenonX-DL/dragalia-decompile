using System;

namespace GooglePlayGames.BasicApi
{
	public class Achievement
	{
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

		public bool IsIncremental
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int CurrentSteps
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int TotalSteps
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool IsUnlocked
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool IsRevealed
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string Id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime LastModifiedTime
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public ulong Points
		{
			get
			{
				return default(ulong);
			}
			set
			{
			}
		}

		public string RevealedImageUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string UnlockedImageUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}
	}
}
