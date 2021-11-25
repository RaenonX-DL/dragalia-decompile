using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTradeMenuButton : MonoBehaviour
	{
		public ShopTradeModel.PanelType type;

		[SerializeField]
		[Header("For Disable (can be null)")]
		public Text disableReasonText;
	}
}
