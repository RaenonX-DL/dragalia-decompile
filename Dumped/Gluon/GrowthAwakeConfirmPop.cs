using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthAwakeConfirmPop : CommonPopup
	{
		public Image breforeIcon;

		public Image afterIcon;

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

		public Text needDew;

		public Text beforeDew;

		public Text afterDew;

		[SerializeField]
		private Text headerAwakeText;

		[SerializeField]
		private Text headerItemText;

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

		[SerializeField]
		private Text needDewText;

		[SerializeField]
		private Text awakeAlertText;

		public static GrowthAwakeConfirmPop Create(bool showBlackLayer = true)
		{
			return null;
		}

		public void InitPop(ulong unitKeyId)
		{
		}

		private void InitText()
		{
		}
	}
}
