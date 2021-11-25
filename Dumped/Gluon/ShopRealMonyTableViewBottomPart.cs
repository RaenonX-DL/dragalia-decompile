using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopRealMonyTableViewBottomPart : MonoBehaviour
	{
		[SerializeField]
		[Header("BottomText")]
		public Text bottomText;

		public Text specifiedCommercialTransactionActText;

		public const string prefabPath = "Prefabs/OutGame/ShopTrade/Parts/ShopRealMonyTableViewBottomPart";

		[SerializeField]
		private GameObject paymentServicesActObj;

		[SerializeField]
		private GameObject specifiedCommercialActObj;

		public static ShopRealMonyTableViewBottomPart Create(Transform parent)
		{
			return null;
		}

		public static bool ShouldPaymentServiceActButtonOn()
		{
			return default(bool);
		}

		public static bool ShouldSpecifiedCommercialActButtonOn()
		{
			return default(bool);
		}

		private void Start()
		{
		}

		public void OnRecoverFailedPaymentButtonPressed()
		{
		}

		public void OnPaymentServicesActPressed()
		{
		}

		public static void OpenPaymentServicesAct()
		{
		}

		public void OnSpecifiedCommercialTransactionActPressed()
		{
		}

		public static void OpenSpecifiedCommercialTransactionAct()
		{
		}
	}
}
