using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Gluon.Shooting
{
	[LuaCallCSharp(GenFlag.No)]
	public class GameParameterController : STGSingletonMonoBehaviour<GameParameterController>
	{
		public class ParseTableBase
		{
		}

		public class ParseEnemyOrderTable : ParseTableBase
		{
			public int id;

			public EnemyManager.TemplateType type;

			public int guideAction;

			public int level;

			public int fafnirAction;

			public int fafnirLevel;

			public static int columnNum;
		}

		public class ParseBossActionOrderTable : ParseTableBase
		{
			public int id;

			public int level;

			public int phase;

			public string actionName;

			public int interval;

			public static int columnNum;
		}

		public class ParseEnemyPatternDefineTable : ParseTableBase
		{
			public int id;

			public EnemyManager.TemplateType type;

			public int guideAction;

			public int enemyNum;

			public int[] enemyDelay;

			public int bulletNum;

			public bool isAMAP;

			public int angleSpace;

			public float bulletSpeed;

			public BulletManager.TemplateType bulletType;

			public int bulletColor;

			public int[] firstDelayBegin;

			public int[] firstDelayEnd;

			public int[] intervalRandBegin;

			public int[] intervalRandEnd;

			public static int columnNum;
		}

		public class ParsePlayerBulletTable : ParseTableBase
		{
			public int level;

			public int mainStringNum;

			public int mainSpeed;

			public int subAStringNum;

			public int subASpeed;

			public int subBStringNum;

			public int subBSpeed;

			public static int columnNum;
		}

		public class ParseEnemyLevelTable : ParseTableBase
		{
			public EnemyManager.TemplateType type;

			public int level;

			public int hp;

			public int score;

			public int minPlayerLevel;

			public int maxPlayerLevel;

			public int takeStarSCount;

			public int takeStarMCount;

			public const int columnNum = 8;
		}

		[SerializeField]
		[Multiline]
		[Header("è\u0087ªæ©\u009få¼¾ã\u0081®è\u00a8­å®\u009aTableï¼\u0088ç¢ºå®\u009aï¼\u0089")]
		public string playerBulletTableText;

		[SerializeField]
		[Multiline]
		[Header("ç·\u00a8é\u009a\u008aé\u00a0\u0086ç\u0095ªã\u0081®è\u00a8­å®\u009aTableï¼\u0088ç¢ºå®\u009aï¼\u0089")]
		public string enemyOrderTableText;

		[SerializeField]
		[Multiline]
		[Header("EasyMode ç·\u00a8é\u009a\u008aé\u00a0\u0086ç\u0095ªã\u0081®è\u00a8­å®\u009aTableï¼\u0088ç¢ºå®\u009aï¼\u0089")]
		public string easyEnemyOrderTableText;

		[SerializeField]
		[Multiline]
		[Header("ç·\u00a8é\u009a\u008aå\u0080\u008bå\u0088¥ã\u0081®è\u00a8­å®\u009aTableï¼\u0088ç¢ºå®\u009aï¼\u0089")]
		public string enemyPatternDetailTableText;

		[SerializeField]
		[Multiline]
		[Header("EasyMode ç·\u00a8é\u009a\u008aå\u0080\u008bå\u0088¥ã\u0081®è\u00a8­å®\u009aTableï¼\u0088ç¢ºå®\u009aï¼\u0089")]
		public string easyEnemyPatternDetailTableText;

		[SerializeField]
		[Multiline]
		[Header("æ\u0095µLevelã\u0081®è\u00a8­å®\u009aTableï¼\u0088ç¢ºå®\u009aï¼\u0089")]
		public string enemyLevelDataTableText;

		[SerializeField]
		[Multiline]
		[Header("Bossè\u00a8­å®\u009aTableï¼\u0088ç¢ºå®\u009aï¼\u0089")]
		public string bossActionDataTableText;

		private List<ParseEnemyOrderTable> parsedEnemyOrderTable;

		private List<ParseBossActionOrderTable> parsedBossActionOrderTable;

		private List<ParseEnemyPatternDefineTable> parsedEnemyPatternDefineTable;

		private List<ParsePlayerBulletTable> parsedPlayerBulletTable;

		private List<ParseEnemyLevelTable> parsedEnemyLevelTable;

		public void Restart()
		{
		}

		public static string[] SplitText(string text)
		{
			return null;
		}

		public static List<T> FindObjectsOfTypeAll<T>()
		{
			return null;
		}

		public static EnemyManager.TemplateType ConvertEnemyName(string name)
		{
			return default(EnemyManager.TemplateType);
		}

		public static string ConvertToEnemyName(EnemyManager.TemplateType type)
		{
			return null;
		}

		public static BulletManager.TemplateType ConvertBulletName(string name)
		{
			return default(BulletManager.TemplateType);
		}

		public bool ParseEnemyOrder(string text)
		{
			return default(bool);
		}

		public void ApplyEnemyOrder()
		{
		}

		public void GetFafnirPatternScheduleByType(int guideAction, out ParseEnemyPatternDefineTable subFafSchedule)
		{
		}

		public ParseEnemyOrderTable GetEnemyPatternSchedule(int id, out ParseEnemyPatternDefineTable subSchedule, out ParseEnemyPatternDefineTable subFafSchedule)
		{
			return null;
		}

		public bool ParseBossActionOrder(string text)
		{
			return default(bool);
		}

		public void ApplyBossActionOrder()
		{
		}

		public ParseBossActionOrderTable GetBossNextAction(ref int id, int level, int bossPhase)
		{
			return null;
		}

		public bool ParseEnemyPatternDefine(string text)
		{
			return default(bool);
		}

		public void ApplyEnemyPatternDefine()
		{
		}

		public bool ParsePlayerBullet(string text)
		{
			return default(bool);
		}

		private void ApplyPlayerBullet()
		{
		}

		public bool ParseEnemyLevel(string text)
		{
			return default(bool);
		}

		private void ApplyEnemyLevel()
		{
		}

		public ParseEnemyLevelTable GetEnemyLevelByType(EnemyManager.TemplateType type, int playerLevel)
		{
			return null;
		}

		public ParseEnemyLevelTable GetEnemyLevel(ParseEnemyPatternDefineTable table, int playerLevel)
		{
			return null;
		}
	}
}
