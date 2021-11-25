using System;
using UnityEngine.Events;

namespace Gluon
{
	public class AutoMaterialSelectDialog : AutoSelectDialogBase
	{
		public UnityAction autoSelectAction;

		public const string configDragonRarityKey = "AutoMaterialSelectDragonRarity";

		public const string configWeaponRarityKey = "AutoMaterialSelectWeaponRarity";

		public const string configAmuletRarityKey = "AutoMaterialSelectAmuletRarity";

		public const string configDragonLevelKey = "AutoMaterialSelectDragonLevel";

		public const string configWeaponLevelKey = "AutoMaterialSelectWeaponLevel";

		public const string configAmuletLevelKey = "AutoMaterialSelectAmuletLevel";

		public const string configDragonPlusKey = "AutoMaterialSelectDragonPlus";

		public const string configWeaponPlusKey = "AutoMaterialSelectWeaponPlus";

		public const string configAmuletPlusKey = "AutoMaterialSelectAmuletPlus";

		public static AutoMaterialSelectDialog Create()
		{
			return null;
		}

		public void SetupConfigDialog(GrowthBaseType type, int countMax, Func<int> getAutoSelectCount)
		{
		}

		protected override void OkButtonPressed()
		{
		}

		public static int[] GetAutoSelectConfigParam(GrowthBaseType baseType)
		{
			return null;
		}
	}
}
