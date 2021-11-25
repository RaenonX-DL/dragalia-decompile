using System.Collections.Generic;

namespace Gluon
{
	public class WeaponTypePool
	{
		private struct EffectPoolInfo
		{
			public string name;

			public int count;
		}

		private Dictionary<string, HashSet<CharacterBase>> actionEffectPoolInfo;

		private static EffectPoolInfo[][] effectPoolInfos;

		private int[] bulletPoolCount;

		private EffectPoolInfo[] charaEffectPoolInfos;

		private EffectPoolInfo[] playerEffectPoolInfos;

		public void CreatePool(List<CharacterSelector> characterSelectors)
		{
		}

		public static void CreateCommonPoolOnType(WeaponType weaponType)
		{
		}

		public void AddActionEffectGroupPool(string effectName, CharacterBase actionOwner)
		{
		}

		public void CreateActionEffectPool()
		{
		}

		public static void GetAllPoolTypeGroupName(out HashSet<string> groupNameList)
		{
		}
	}
}
