using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BoxSummonResultItem : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private Image lineImage;

		[SerializeField]
		private Text quantityText;

		public void SetContent(BoxSummonResultPopup.BoxSummonResultData itemData)
		{
		}

		public void SetDispBorderline(bool f)
		{
		}
	}
}
