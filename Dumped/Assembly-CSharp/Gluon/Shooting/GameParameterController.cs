/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	[LuaCallCSharp]
	public class GameParameterController : STGSingletonMonoBehaviour<Gluon.Shooting.GameParameterController>
	{
		// Fields
		[Header]
		[Multiline]
		[SerializeField]
		public string playerBulletTableText;
		[Header]
		[Multiline]
		[SerializeField]
		public string enemyOrderTableText;
		[Header]
		[Multiline]
		[SerializeField]
		public string easyEnemyOrderTableText;
		[Header]
		[Multiline]
		[SerializeField]
		public string enemyPatternDetailTableText;
		[Header]
		[Multiline]
		[SerializeField]
		public string easyEnemyPatternDetailTableText;
		[Header]
		[Multiline]
		[SerializeField]
		public string enemyLevelDataTableText;
		[Header]
		[Multiline]
		[SerializeField]
		public string bossActionDataTableText;
		private List<ParseEnemyOrderTable> parsedEnemyOrderTable;
		private List<ParseBossActionOrderTable> parsedBossActionOrderTable;
		private List<ParseEnemyPatternDefineTable> parsedEnemyPatternDefineTable;
		private List<ParsePlayerBulletTable> parsedPlayerBulletTable;
		private List<ParseEnemyLevelTable> parsedEnemyLevelTable;
	
		// Nested types
		public class ParseTableBase
		{
			// Constructors
			public ParseTableBase();
		}
	
		public class ParseEnemyOrderTable : ParseTableBase
		{
			// Fields
			public int id;
			public EnemyManager.TemplateType type;
			public int guideAction;
			public int level;
			public int fafnirAction;
			public int fafnirLevel;
			public static int columnNum;
	
			// Constructors
			public ParseEnemyOrderTable();
			static ParseEnemyOrderTable();
		}
	
		public class ParseBossActionOrderTable : ParseTableBase
		{
			// Fields
			public int id;
			public int level;
			public int phase;
			public string actionName;
			public int interval;
			public static int columnNum;
	
			// Constructors
			public ParseBossActionOrderTable();
			static ParseBossActionOrderTable();
		}
	
		public class ParseEnemyPatternDefineTable : ParseTableBase
		{
			// Fields
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
	
			// Constructors
			public ParseEnemyPatternDefineTable();
			static ParseEnemyPatternDefineTable();
		}
	
		public class ParsePlayerBulletTable : ParseTableBase
		{
			// Fields
			public int level;
			public int mainStringNum;
			public int mainSpeed;
			public int subAStringNum;
			public int subASpeed;
			public int subBStringNum;
			public int subBSpeed;
			public static int columnNum;
	
			// Constructors
			public ParsePlayerBulletTable();
			static ParsePlayerBulletTable();
		}
	
		public class ParseEnemyLevelTable : ParseTableBase
		{
			// Fields
			public EnemyManager.TemplateType type;
			public int level;
			public int hp;
			public int score;
			public int minPlayerLevel;
			public int maxPlayerLevel;
			public int takeStarSCount;
			public int takeStarMCount;
			public const int columnNum = 8;
	
			// Constructors
			public ParseEnemyLevelTable();
		}
	
		// Constructors
		public GameParameterController();
	
		// Methods
		public void Restart();
		public static string[] SplitText(string text);
		public static List<T> FindObjectsOfTypeAll<T>();
		public static EnemyManager.TemplateType ConvertEnemyName(string name);
		public static string ConvertToEnemyName(EnemyManager.TemplateType type);
		public static BulletManager.TemplateType ConvertBulletName(string name);
		public bool ParseEnemyOrder(string text);
		public void ApplyEnemyOrder();
		public void GetFafnirPatternScheduleByType(int guideAction, out ParseEnemyPatternDefineTable subFafSchedule);
		public ParseEnemyOrderTable GetEnemyPatternSchedule(int id, out ParseEnemyPatternDefineTable subSchedule, out ParseEnemyPatternDefineTable subFafSchedule);
		public bool ParseBossActionOrder(string text);
		public void ApplyBossActionOrder();
		public ParseBossActionOrderTable GetBossNextAction(ref int id, int level, int bossPhase);
		public bool ParseEnemyPatternDefine(string text);
		public void ApplyEnemyPatternDefine();
		public bool ParsePlayerBullet(string text);
		private void ApplyPlayerBullet();
		public bool ParseEnemyLevel(string text);
		private void ApplyEnemyLevel();
		public ParseEnemyLevelTable GetEnemyLevelByType(EnemyManager.TemplateType type, int playerLevel);
		public ParseEnemyLevelTable GetEnemyLevel(ParseEnemyPatternDefineTable table, int playerLevel);
	}
}
