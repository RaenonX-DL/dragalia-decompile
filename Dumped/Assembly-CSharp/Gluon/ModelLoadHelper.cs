/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class ModelLoadHelper
	{
		// Fields
		private const string HUMAN_RESOURCES_PATH = "Characters/";
		private const string HUMAN_MODEL_PATH = "Characters/model/";
		public const string HUMAN_MOTION_PATH = "Characters/motion/";
		private const string DRAGON_RESOURCES_PATH = "Dragon/";
		private const string DRAGON_MODEL_PATH = "Dragon/model/";
		private const string DRAGON_MOTION_PATH = "Dragon/motion/";
		private const string MONSTER_RESOURCES_PATH = "Enemy/";
		private const string MONSTER_MODEL_PATH = "Enemy/model/";
		private const string MONSTER_MOTION_PATH = "Enemy/motion/";
		private const string BOSS_RESOURCES_PATH = "Boss/";
		private const string BOSS_MODEL_PATH = "Boss/model/";
		private const string BOSS_MOTION_PATH = "Boss/motion/";
		private const string RAID_RESOURCES_PATH = "Raid/";
		private const string RAID_MODEL_PATH = "Raid/model/";
		private const string RAID_MOTION_PATH = "Raid/motion/";
		private const string HIGHBOSS_RESOURCES_PATH = "HighBoss/";
		private const string HIGHBOSS_MODEL_PATH = "HighBoss/model/";
		private const string HIGHBOSS_MOTION_PATH = "HighBoss/motion/";
	
		// Nested types
		public enum EnemyCategory
		{
			NONE = 0,
			MONSTER = 1,
			BOSS = 2,
			DRAGON = 3,
			RAID = 4,
			HUMAN = 5,
			UNIQUE = 6,
			HIGH_BOSS = 7,
			OBJECT = 9
		}
	
		// Methods
		public static string ConvertCharacterModelPath(int characterId);
		public static string ConvertCharacterMotionPath(int characterId);
		public static string ConvertDragonModelPath(int dragonId);
		public static string ConvertDragonMotionPath(int dragonId);
		public static string ConvertEnemyModelPath(int enemyParamId);
		public static string ConvertEnemyModelPathByEnemyDataID(int enemyDataId);
		public static string ConvertEnemyMotionPath(int enemyParamId);
		public static string ConvertEnemyMotionPathByEnemyDataID(int enemyDataId);
		private static string ConvertHumanModelPath(int baseId, int variationId);
		private static string ConvertHumanMotionPath(WeaponType category);
		private static string ConvertHumanMotionPath(int weaponSkinId);
		private static string ConvertDragonModelPath(int baseId, int variationId);
		private static string ConvertDragonMotionPath(string fileName);
		private static string ConvertMonsterModelPath(int baseId, int variationId);
		private static string ConvertMonsterMotionPath(int baseId);
		private static string ConvertMonsterMotionPath(string fileName);
		private static string ConvertBossModelPath(int baseId, int variationId);
		private static string ConvertBossMotionPath(int baseId);
		private static string ConvertBossMotionPath(string fileName);
		private static string ConvertRaidModelPath(int baseId, int variationId);
		private static string ConvertRaidMotionPath(int baseId);
		private static string ConvertRaidMotionPath(string fileName);
		private static string ConvertHighBossModelPath(int baseId, int variationId);
		private static string ConvertHighBossMotionPath(int baseId);
		private static string ConvertHighBossMotionPath(string fileName);
		private static string ConvertObjectModelPath(int baseId, int variationId);
		private static string ConvertObjectMotionPath(int baseId);
	}
}
