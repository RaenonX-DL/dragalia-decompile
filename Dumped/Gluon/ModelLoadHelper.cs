using System;

namespace Gluon
{
	public static class ModelLoadHelper
	{
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

		public static Func<int> overrideHumanModelBaseIdFunc;

		public static Func<int> overrideHumanModelVariationIdFunc;

		public static Func<int> overrideHumanMotionCharaIdFunc;

		public static Func<int> overrideDragonModelBaseIdFunc;

		public static Func<int> overrideDragonModelVariationIdFunc;

		public static Func<int> overrideDragonMotionCharaIdFunc;

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

		public static string ConvertCharacterModelPath(int characterId)
		{
			return null;
		}

		public static string ConvertCharacterMotionPath(int characterId)
		{
			return null;
		}

		public static string ConvertDragonModelPath(int dragonId)
		{
			return null;
		}

		public static string ConvertDragonMotionPath(int dragonId)
		{
			return null;
		}

		public static string ConvertEnemyModelPath(int enemyParamId)
		{
			return null;
		}

		public static string ConvertEnemyModelPathByEnemyDataID(int enemyDataId)
		{
			return null;
		}

		public static string ConvertEnemyMotionPath(int enemyParamId)
		{
			return null;
		}

		public static string ConvertEnemyMotionPathByEnemyDataID(int enemyDataId)
		{
			return null;
		}

		private static string ConvertHumanModelPath(int baseId, int variationId)
		{
			return null;
		}

		private static string ConvertHumanMotionPath(WeaponType category)
		{
			return null;
		}

		private static string ConvertHumanMotionPath(int weaponSkinId)
		{
			return null;
		}

		private static string ConvertDragonModelPath(int baseId, int variationId)
		{
			return null;
		}

		private static string ConvertDragonMotionPath(string fileName)
		{
			return null;
		}

		private static string ConvertMonsterModelPath(int baseId, int variationId)
		{
			return null;
		}

		private static string ConvertMonsterMotionPath(int baseId)
		{
			return null;
		}

		private static string ConvertMonsterMotionPath(string fileName)
		{
			return null;
		}

		private static string ConvertBossModelPath(int baseId, int variationId)
		{
			return null;
		}

		private static string ConvertBossMotionPath(int baseId)
		{
			return null;
		}

		private static string ConvertBossMotionPath(string fileName)
		{
			return null;
		}

		private static string ConvertRaidModelPath(int baseId, int variationId)
		{
			return null;
		}

		private static string ConvertRaidMotionPath(int baseId)
		{
			return null;
		}

		private static string ConvertRaidMotionPath(string fileName)
		{
			return null;
		}

		private static string ConvertHighBossModelPath(int baseId, int variationId)
		{
			return null;
		}

		private static string ConvertHighBossMotionPath(int baseId)
		{
			return null;
		}

		private static string ConvertHighBossMotionPath(string fileName)
		{
			return null;
		}

		private static string ConvertObjectModelPath(int baseId, int variationId)
		{
			return null;
		}

		private static string ConvertObjectMotionPath(int baseId)
		{
			return null;
		}
	}
}
