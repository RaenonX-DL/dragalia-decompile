/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class STGDataManager
	{
		// Fields
		private static STGDataManager instance;
		private const string saveDataPrefs = "APRIL2019_STG_SaveData";
		private const int eventId = 21501;
		public SaveData saveData;
		public Dictionary<Mode, int[]> evaluationScoreDic;
		public CurrentGameData currentGameData;
	
		// Properties
		public static STGDataManager Instance { get; }
	
		// Nested types
		public enum Mode
		{
			Easy = 0,
			Hard = 1,
			Extreme = 2
		}
	
		[Serializable]
		public class SaveData
		{
			// Fields
			public bool isEndingRead;
			public bool isFromShooting;
			public bool isEasyCleared;
			public bool isExtremeReleased;
			public RankingData[] easyRankingData;
			public RankingData[] hardRankingData;
			public RankingData[] extremeRankingData;
	
			// Constructors
			public SaveData();
		}
	
		[Serializable]
		public class RankingData
		{
			// Fields
			public int bossLevel;
			public int score;
			public bool isRankIn;
	
			// Constructors
			public RankingData(int bossLevel, int score, bool isRankIn = false);
		}
	
		public class CurrentGameData
		{
			// Fields
			public Mode mode;
			public bool isFromLoginBonus;
			public EnemyRankBreakdown[] enemyBreakdown;
			public int otherScore;
			public int bossLevel;
			public bool isBossExit;
	
			// Properties
			public int totalScore { get; }
	
			// Nested types
			public class EnemyRankBreakdown
			{
				// Fields
				public int score;
				public int count;
	
				// Constructors
				public EnemyRankBreakdown();
			}
	
			// Constructors
			public CurrentGameData();
	
			// Methods
			public void Clear();
			public bool AddScore(int addScore, int enemyLevel);
		}
	
		// Constructors
		private STGDataManager();
		static STGDataManager();
	
		// Methods
		public static void Dispose();
		public static bool IsWithinLoginBonusEntryPeriod();
		public static bool IsWithinMyPageEntryPeriod();
		public void SaveScoreData();
		public void LoadData();
		public void RecordClear(int level);
		public RankingData[] GetRankingData(Mode mode);
		public void CleanRankInData();
	}
}
