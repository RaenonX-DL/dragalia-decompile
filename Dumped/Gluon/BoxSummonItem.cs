using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BoxSummonItem : MonoBehaviour
	{
		[SerializeField]
		protected CommonIcon icon;

		[SerializeField]
		private Text upperText;

		[SerializeField]
		private Text lowerText;

		[SerializeField]
		private Text obtainedText;

		[SerializeField]
		private Image itemBgImage;

		private GiftType giftType;

		private int id;

		private int twoStepId;

		private int quantity;

		private EventQuestPageBase currentPage;

		private PopupBase parentPopup;

		public void SetContent(AtgenBoxSummonDetail itemData, EventQuestPageBase page, PopupBase parentPopup, IconLoader.Size size, int index = 0)
		{
		}

		public void SetContent(AtgenDrawDetails itemData, EventQuestPageBase page, PopupBase parentPopup, IconLoader.Size size)
		{
		}

		public void SetContent(AtgenBuildEventRewardEntityList itemData, EventQuestPageBase page, PopupBase parentPopup, IconLoader.Size size)
		{
		}

		private void Init(string remainValueStr, string totalValueStr, IconLoader.Size size, bool shouldShowCountPlate, int index = 0)
		{
		}

		public void SetContent(BoxSummonResultPopup.BoxSummonResultPickUpData data, EventQuestPageBase page, PopupBase parentPopup, IconLoader.Size size)
		{
		}

		private void InitResult(BoxSummonResultPopup.BoxSummonResultPickUpData data, IconLoader.Size size, bool shouldShowCountPlate)
		{
		}

		public void OnIconTouched()
		{
		}
	}
}
