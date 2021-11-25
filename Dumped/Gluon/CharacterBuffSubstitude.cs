using System.Collections.Generic;

namespace Gluon
{
	public static class CharacterBuffSubstitude
	{
		public static readonly float SubstitudeReduceDamageRate;

		public static bool IsSubstitudableDamage(int damage, DamageCalculation.DamageStatus status, CollisionHitAttribute hitAttr)
		{
			return default(bool);
		}

		public static bool IsSubstitudableDamageCharacter(CharacterBase owner)
		{
			return default(bool);
		}

		public static bool BuildSubstitudeInfos(CharacterBase owner, int originalDamage, out int outReducedDamage, ref List<DamageCalculation.DamageStatus.SubstitudeInfo> outResult)
		{
			return default(bool);
		}

		public static bool IsSubstitudeTarget(CharacterBase owner, CharacterSelector target)
		{
			return default(bool);
		}

		public static void ConsumeSubstitudeBuff(CharacterBase owner)
		{
		}
	}
}
