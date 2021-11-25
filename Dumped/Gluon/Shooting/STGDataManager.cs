using System;
using System.Collections.Generic;

namespace Gluon.Shooting
{
	public class STGDataManager
	{
		public enum Mode
		{
			Easy,
			Hard,
			Extreme
		}

		[Serializable]
		public class SaveData
		{
			public bool isEndingRead;

			public bool isFromShooting;

			public bool isEasyCleared;

			public bool isExtremeReleased;

			public RankingData[] easyRankingData;

			public RankingData[] hardRankingData;

			public RankingData[] extremeRankingData;
		}

		[Serializable]
		public class RankingData
		{
			public int bossLevel;

			public int score;

			public bool isRankIn;

			public RankingData(int bossLevel, int score, bool isRankIn = false)
			{
			}
		}

		public class CurrentGameData
		{
			public class EnemyRankBreakdown
			{
				public int score;

				public int count;
			}

			public Mode mode;

			public bool isFromLoginBonus;

			public EnemyRankBreakdown[] enemyBreakdown;

			public int otherScore;

			public int bossLevel;

			public bool isBossExit;

			public int totalScore => default(int);

			public void Clear()
			{
			}

			public bool AddScore(int addScore, int enemyLevel)
			{
				return default(bool);
			}
		}

		private static STGDataManager instance;

		private const string saveDataPrefs = "APRIL2019_STG_SaveData";

		private const int eventId = 21501;

		public SaveData saveData;

		public Dictionary<Mode, int[]> evaluationScoreDic;

		public CurrentGameData currentGameData;

		public static STGDataManager Instance => null;

		public static void Dispose()
		{
		}

		private STGDataManager()
		{
		}

		public static bool IsWithinLoginBonusEntryPeriod()
		{
			return default(bool);
		}

		public static bool IsWithinMyPageEntryPeriod()
		{
			return default(bool);
		}

		public void SaveScoreData()
		{
		}

		public void LoadData()
		{
		}

		public void RecordClear(int level)
		{
		}

		public RankingData[] GetRankingData(Mode mode)
		{
			return null;
		}

		public void CleanRankInData()
		{
		}
	}
}
