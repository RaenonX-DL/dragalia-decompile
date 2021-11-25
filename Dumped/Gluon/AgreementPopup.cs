using System.Runtime.InteropServices;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class AgreementPopup : CommonPopup
	{
		public Text locationText;

		public Text locationButtonText;

		public Text agreementText;

		public Text agreementButtonText;

		public Text privacyPolicyButtonText;

		public Button locationButton;

		public Button agreementButton;

		public Button privacyPolicyButton;

		private string warningTextContent;

		private string agreementTextContent;

		private AgreementUtility utility;

		public static void CreateConfirmAgreement(UnityAction onCompleted, string location)
		{
		}

		private static AgreementPopup Create(UnityAction onCompleted)
		{
			return null;
		}

		private void OnRefreshLocation()
		{
		}

		private void SetNOANOEText(string locationCode)
		{
		}

		private void EulaAgree(string locationCode, UnityAction callback)
		{
		}

		private void SetButtonActive(bool isActive = true)
		{
		}

		public void RefreshLocationButton([Optional] string locationStr)
		{
		}

		public void OnLocationButtonPressed()
		{
		}

		public void OnAgreementButtonPressed()
		{
		}

		public void OnPrivacyPolicyButtonPressed()
		{
		}
	}
}
