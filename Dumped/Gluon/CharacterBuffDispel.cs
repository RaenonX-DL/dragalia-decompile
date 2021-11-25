namespace Gluon
{
	public static class CharacterBuffDispel
	{
		public struct PriorityData
		{
			public int baseValue;

			public float sec;

			public static PriorityData Lowest()
			{
				return default(PriorityData);
			}

			public static bool operator <(PriorityData a, PriorityData b)
			{
				return default(bool);
			}

			public static bool operator >(PriorityData a, PriorityData b)
			{
				return default(bool);
			}
		}

		public const int DispelEfficacyType = 100;

		private static bool _tmpHasDispel;

		public static PriorityData GetDispelPriority(ref CharacterBuff.BuffUnion buff)
		{
			return default(PriorityData);
		}

		public static bool IsDispelHitAttribute(CollisionHitAttribute hitAttr)
		{
			return default(bool);
		}

		public static bool IsDispelActionCondition(int actionConditionId)
		{
			return default(bool);
		}
	}
}
