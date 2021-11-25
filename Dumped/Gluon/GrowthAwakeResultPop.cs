using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthAwakeResultPop : CommonPopup
	{
		public class BeforeData
		{
			public int rarity;

			public int limitLevel;

			public int hpValue;

			public int atkValue;

			public int powerValue;

			public int manacircleCount;

			public int maxManacircleValue;

			public int storyIndex;
		}

		public GameObject iconBeforeAfterRoot;

		public Image breforeIcon;

		public Image afterIcon;

		public GameObject iconSingleRoot;

		public Image singleIcon;

		public Text beforeLevel;

		public Text afterLevel;

		public Text beforeHp;

		public Text afterHp;

		public Text beforeAtk;

		public Text afterAtk;

		public Text beforePower;

		public Text afterPower;

		public Text beforeManacircle;

		public Text afterManacircle;

		[SerializeField]
		private Text statusLevelText;

		[SerializeField]
		private Text statusHpText;

		[SerializeField]
		private Text statusAtkText;

		[SerializeField]
		private Text statusPowerText;

		[SerializeField]
		private Text statusManacircleText;

		public static GrowthAwakeResultPop Create(bool showBlackLayer = true)
		{
			return null;
		}

		public void InitPop(ulong unitKeyId)
		{
		}

		public void InitPopForPlatinumCrystal(ulong unitKeyId, BeforeData beforeData, GrowthManaCircleManaPieceData[] manaPieceDataList)
		{
		}

		private void InitText()
		{
		}
	}
}
