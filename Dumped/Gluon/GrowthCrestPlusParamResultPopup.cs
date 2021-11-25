using UnityEngine.UI;

namespace Gluon
{
	public class GrowthCrestPlusParamResultPopup : CommonPopup
	{
		public class BeforeData
		{
			public int hp;

			public int hpPlus;

			public int atk;

			public int atkPlus;

			public int power;

			public int totalPlus;
		}

		public CommonUnitIcon unitIcon;

		public Text beforeHpPlusText;

		public Text beforeAtkPlusText;

		public Text afterHpPlusText;

		public Text afterAtkPlusText;

		public Text beforeTotalPlusText;

		public Text afterTotalPlusText;

		public Text beforeHpText;

		public Text afterHpText;

		public Text beforeAtkText;

		public Text afterAtkText;

		public Text beforePowerText;

		public Text afterPowerText;

		public static GrowthCrestPlusParamResultPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model, BeforeData beforeData)
		{
		}
	}
}
