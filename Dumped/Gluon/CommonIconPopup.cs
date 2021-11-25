using UnityEngine;

namespace Gluon
{
	public class CommonIconPopup : CommonPopup
	{
		public CommonIcon commonIcon;

		public static CommonIconPopup CreatePopup(Size size = Size.S, BottomButtons bottomButtons = BottomButtons.Close, bool showBlackLayer = true, bool showStartAnimation = true)
		{
			return null;
		}

		public void SetImageMaterial(Material mat)
		{
		}

		public void SetupByGiftTypeAndId(GiftType giftType, int id, IconLoader.Size size = IconLoader.Size.M, int level = 1, int limitBreak = 0, int rarity = 3, int additionalMaxLevel = 0)
		{
		}

		public CommonIconListSortDeco CreateDeco(IconLoader.Size iconSize)
		{
			return null;
		}

		public void IsCommonIconButtonEvent(bool value)
		{
		}
	}
}
