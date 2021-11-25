using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MenuVariousNotationPopup : CommonPopup
	{
		[SerializeField]
		private Text termsText;

		[SerializeField]
		private Text copyrightText;

		[SerializeField]
		private Text specifiedCommercialTransactionActText;

		[SerializeField]
		private Text paymentServicesActText;

		[SerializeField]
		private Text privacyPolicyText;

		[SerializeField]
		private Text healthPrecautionsText;

		[SerializeField]
		private GameObject specifiedCommercialTransactionActObj;

		[SerializeField]
		private GameObject paymentServicesActObj;

		public MenuPopup menuPopup;

		public static MenuVariousNotationPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		public void OnTermsButtonPressed()
		{
		}

		public void OnCopyrightButtonPressed()
		{
		}

		public void OnSpecifiedCommercialTransactionActButtonPressed()
		{
		}

		public void OnPaymentServicesActButtonPressed()
		{
		}

		public void OnPrivacyPolicyButtonPressed()
		{
		}

		public void OnHealthPrecautionsButtonPressed()
		{
		}
	}
}
