using Gluon.Master;

namespace Gluon
{
	public static class ExtendAbilityData
	{
		public static float GetAbilityUpValue(this AbilityDataElement self, int idx)
		{
			return default(float);
		}

		public static int GetAbilityType(this AbilityDataElement self, int idx)
		{
			return default(int);
		}

		public static int GetAbilityLimitedGroupId(this AbilityDataElement self, int idx)
		{
			return default(int);
		}

		public static int GetVariousId(this AbilityDataElement self, int idx, int count)
		{
			return default(int);
		}

		public static ElementalType GetReplacedElementalTypeWithTalisman(this AbilityDataElement self, int talismanId)
		{
			return default(ElementalType);
		}

		public static WeaponType GetReplacedWeaponTypeWithTalisman(this AbilityDataElement self, int talismanId)
		{
			return default(WeaponType);
		}

		private static CharaDataElement GetTalismanOwnerCharaData(int talismanId)
		{
			return null;
		}
	}
}
