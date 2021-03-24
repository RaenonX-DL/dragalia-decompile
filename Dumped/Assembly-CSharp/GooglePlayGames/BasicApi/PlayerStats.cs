/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi
{
	public class PlayerStats
	{
		// Fields
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
	
		// Properties
		public bool Valid { get; }
		public int NumberOfPurchases { get; }
		public float AvgSessionLength { get; }
		public int DaysSinceLastPlayed { get; }
		public int NumberOfSessions { get; }
		public float SessPercentile { get; }
		public float SpendPercentile { get; }
		public float SpendProbability { get; }
		public float ChurnProbability { get; }
		public float HighSpenderProbability { get; }
		public float TotalSpendNext28Days { get; }
	
		// Constructors
		public PlayerStats(int numberOfPurchases, float avgSessionLength, int daysSinceLastPlayed, int numberOfSessions, float sessPercentile, float spendPercentile, float spendProbability, float churnProbability, float highSpenderProbability, float totalSpendNext28Days);
		public PlayerStats();
		static PlayerStats();
	
		// Methods
		public bool HasNumberOfPurchases();
		public bool HasAvgSessionLength();
		public bool HasDaysSinceLastPlayed();
		public bool HasNumberOfSessions();
		public bool HasSessPercentile();
		public bool HasSpendPercentile();
		public bool HasChurnProbability();
		public bool HasHighSpenderProbability();
		public bool HasTotalSpendNext28Days();
	}
}
