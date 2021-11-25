using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonPopup1CheckBox : CommonPopup
	{
		public enum TextSet
		{
			None,
			TermsOfService,
			AgeVerification
		}

		public GameObject TermsOfService;

		public GameObject AgeVerification;

		public Text birthDateText;

		private static CommonPopup1CheckBox popup;

		public Text limitTextOver20;

		public Text limitTextOver16Under20;

		public Text limitTextUnder16;

		public static CommonPopup1CheckBox OriginalCreate(TextSet setText, Size size = Size.S, BottomButtons bottomButtons = BottomButtons.Close, bool showText = false, bool showBlackLayer = false)
		{
			return null;
		}

		public void SetFixTextType(TextSet setText)
		{
		}

		public void SetBirthDate(int year, int mon)
		{
		}
	}
}
