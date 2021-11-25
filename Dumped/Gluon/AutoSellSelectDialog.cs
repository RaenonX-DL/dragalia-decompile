using System;
using UnityEngine.Events;

namespace Gluon
{
	public class AutoSellSelectDialog : AutoSelectDialogBase
	{
		public UnityAction okButtonCallBack;

		public const string configDragonRarityKey = "AutoSellSelectDragonRarity";

		public const string configWeaponRarityKey = "AutoSellSelectWeaponRarity";

		public const string configAmuletRarityKey = "AutoSellSelectAmuletRarity";

		public const string configDragonLevelKey = "AutoSellSelectDragonLevel";

		public const string configWeaponLevelKey = "AutoSellSelectWeaponLevel";

		public const string configAmuletLevelKey = "AutoSellSelectAmuletLevel";

		public const string configDragonPlusKey = "AutoSellSelectDragonPlus";

		public const string configWeaponPlusKey = "AutoSellSelectWeaponPlus";

		public const string configAmuletPlusKey = "AutoSellSelectAmuletPlus";

		public static AutoSellSelectDialog Create()
		{
			return null;
		}

		public void SetupConfigDialog(SellListType type, int countMax, Func<int> getAutoSelectCount)
		{
		}

		protected override void OkButtonPressed()
		{
		}

		public static int[] GetAutoSelectConfigParam(SellListType listType)
		{
			return null;
		}
	}
}
