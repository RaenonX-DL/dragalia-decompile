using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumStoryReviewCommonIconPopup : CommonIconPopup
	{
		[SerializeField]
		private Text iconName;

		public static AlbumStoryReviewCommonIconPopup CreateAlbumStoryReviewCommonIconPopup(Size size = Size.S, BottomButtons bottomButtons = BottomButtons.Close, bool showBlackLayer = true, bool showStartAnimation = true)
		{
			return null;
		}

		public void SetIconNameByGiftTypeAndId(GiftType giftType, int id)
		{
		}
	}
}
