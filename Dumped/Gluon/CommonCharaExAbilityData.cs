using System.Collections.Generic;

namespace Gluon
{
	public class CommonCharaExAbilityData
	{
		public class UnitData
		{
			public int unitNo;

			public int rarity;

			public UnitData(int unitNo, int rarity)
			{
			}
		}

		public int unitNo;

		public int rarity;

		public int exAbilityId;

		public int category;

		public float abilityType1UpValue0;

		public bool abilityEnable;

		public bool isSecondExAbility;

		public List<UnitData> abilityDuplicateUnit;
	}
}
