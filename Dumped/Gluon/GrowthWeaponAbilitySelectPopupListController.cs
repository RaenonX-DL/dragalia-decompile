using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class GrowthWeaponAbilitySelectPopupListController : CommonIconListController
	{
		[HideInInspector]
		public int targetWeaponId;

		[HideInInspector]
		public int totalUseRupi;

		public Dictionary<int, int> needMaterialData;

		protected override CommonIconListCellData CreateWeaponPassiveAbilityCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		public void UpdateCellDataSelectNumber(List<int> selectList)
		{
		}

		private bool IsReleasablePassiveAbility(int dataId)
		{
			return default(bool);
		}

		public void UpdateReleasableFlag(List<int> selectList)
		{
		}
	}
}
