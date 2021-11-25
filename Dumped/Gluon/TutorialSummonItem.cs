using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TutorialSummonItem : MonoBehaviour
	{
		[SerializeField]
		protected CommonIcon icon;

		[SerializeField]
		private Image iconDragonElements;

		[SerializeField]
		private Sprite[] dragonElements;

		private GiftType giftType;

		private int id;

		public void SetContent(SummonResultItemData data, IconLoader.Size size)
		{
		}

		private void SetIconDoragonElement(SummonResultItemData data)
		{
		}

		public void OnIconTouched()
		{
		}

		public void ShowItemDetail(SummonResultItemData itemData)
		{
		}

		private void TutorialFlagReset()
		{
		}
	}
}
