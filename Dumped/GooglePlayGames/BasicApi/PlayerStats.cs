namespace GooglePlayGames.BasicApi
{
	public class PlayerStats
	{
		private static float UNSET_VALUE;

		private bool mValid;

		private int mNumberOfPurchases;

		private float mAvgSessionLength;

		private int mDaysSinceLastPlayed;

		private int mNumberOfSessions;

		private float mSessPercentile;

		private float mSpendPercentile;

		private float mSpendProbability;

		private float mChurnProbability;

		private float mHighSpenderProbability;

		private float mTotalSpendNext28Days;

		public bool Valid => default(bool);

		public int NumberOfPurchases => default(int);

		public float AvgSessionLength => default(float);

		public int DaysSinceLastPlayed => default(int);

		public int NumberOfSessions => default(int);

		public float SessPercentile => default(float);

		public float SpendPercentile => default(float);

		public float SpendProbability => default(float);

		public float ChurnProbability => default(float);

		public float HighSpenderProbability => default(float);

		public float TotalSpendNext28Days => default(float);

		public PlayerStats(int numberOfPurchases, float avgSessionLength, int daysSinceLastPlayed, int numberOfSessions, float sessPercentile, float spendPercentile, float spendProbability, float churnProbability, float highSpenderProbability, float totalSpendNext28Days)
		{
		}

		public PlayerStats()
		{
		}

		public bool HasNumberOfPurchases()
		{
			return default(bool);
		}

		public bool HasAvgSessionLength()
		{
			return default(bool);
		}

		public bool HasDaysSinceLastPlayed()
		{
			return default(bool);
		}

		public bool HasNumberOfSessions()
		{
			return default(bool);
		}

		public bool HasSessPercentile()
		{
			return default(bool);
		}

		public bool HasSpendPercentile()
		{
			return default(bool);
		}

		public bool HasChurnProbability()
		{
			return default(bool);
		}

		public bool HasHighSpenderProbability()
		{
			return default(bool);
		}

		public bool HasTotalSpendNext28Days()
		{
			return default(bool);
		}
	}
}
