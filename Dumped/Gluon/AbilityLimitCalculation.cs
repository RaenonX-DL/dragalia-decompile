using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class AbilityLimitCalculation
	{
		public class CategoryKeys
		{
			public int type;

			public int variousId;

			public AbilityTargetAction targetActionId;

			public AbilityCondition conditionId;

			public int limitedGroupId;

			public void Setup(int type, int variousId, AbilityTargetAction targetActionId = AbilityTargetAction.NONE, AbilityCondition conditionId = AbilityCondition.NONE, int limitedGroupId = 0)
			{
			}
		}

		private class CategoryComparer : IEqualityComparer<CategoryKeys>
		{
			public bool Equals(CategoryKeys a, CategoryKeys b)
			{
				return default(bool);
			}

			public int GetHashCode(CategoryKeys obj)
			{
				return default(int);
			}
		}

		private List<AbilityDataElement> abilityDatas;

		public Dictionary<CategoryKeys, float> limitedDict
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void AddList(int id)
		{
		}

		public void AddList(AbilityDataElement ade)
		{
		}

		public void DecideLimited()
		{
		}

		private void AddDictionary(CategoryKeys keys, float value)
		{
		}

		private void AddDictionary(CategoryKeys keys, float value, AbilityTargetAction targetActionId)
		{
		}

		private void OverwriteLimit(CategoryKeys keys, float value)
		{
		}

		private void OverwriteLimit(CategoryKeys keys, float value, AbilityTargetAction targetActionId)
		{
		}

		public float ApplyLimit(CategoryKeys keys, float currentValue)
		{
			return default(float);
		}
	}
}
