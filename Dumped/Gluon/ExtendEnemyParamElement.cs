using Gluon.Master;

namespace Gluon
{
	public static class ExtendEnemyParamElement
	{
		public enum EnemyParamaEnum
		{
			POISON = 1,
			BURN,
			FREEZE,
			PARALYSIS,
			DARKNESS,
			SWOON,
			SLOWMOVE,
			SLEEP,
			CURSE,
			FROSTBITE,
			FLASHHEAT,
			CRASHWIND,
			DARKABS,
			DESTROYFIRE
		}

		private static readonly int registAbnormalRateCount;

		public static int GetRegistAbnormalId(this EnemyParamElement masterData, int enemyParamAbnormalStatusNumber)
		{
			return default(int);
		}

		public static int GetRegistAbnormalRate(this EnemyParamElement masterData, int enemyParamAbnormalStatusNumber)
		{
			return default(int);
		}

		public static AbnormalStatusType GetRegistAbnormalType(this EnemyParamElement masterData, int enemyParamAbnormalStatusNumber)
		{
			return default(AbnormalStatusType);
		}

		public static int GetRegistAbnormalRateCount(this EnemyParamElement masterData)
		{
			return default(int);
		}
	}
}
