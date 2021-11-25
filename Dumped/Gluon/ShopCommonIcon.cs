using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopCommonIcon : CommonIcon
	{
		public class SpecialIconSetting
		{
			public string iconName;

			public string name;

			public string description;

			public ShopTradeProductData.CommonShopType shopType;

			public SpecialIconSetting()
			{
			}

			public SpecialIconSetting(string iconName, string name, string description, ShopTradeProductData.CommonShopType shopType)
			{
			}

			public SpecialIconSetting MakeClone()
			{
				return null;
			}
		}

		[SerializeField]
		private GameObject[] rarityImages;

		private ShopTradeProductData.CommonShopItemContentData contentData;

		private const string specialMaterialTemplate = "Images/Icon/ShopSpecialItem/{0}/{1}";

		private SpecialIconSetting specialIconInfo;

		private static SpecialIconSetting[] specialIcons;

		private static int specialItemIndex;

		public static void SetSpecialContentNameAndDescription([Optional] SpecialIconSetting[] specialIcons)
		{
		}

		public override void SetupByGiftTypeAndId(GiftType giftType, int id, IconLoader.Size size = IconLoader.Size.M, int level = 1, int limitBreak = 0, int rarity = 4, int additionalMaxLevel = 0, int limitOver = 0)
		{
		}

		public void SetupByShopContentData(ShopTradeProductData.CommonShopItemContentData contentData, ShopTradeProductData.CommonShopItemData.PackContentType contentType, ShopTradeProductData.CommonShopType shopType)
		{
		}

		private int GetRarity(GiftType giftType, int itemId)
		{
			return default(int);
		}

		private void SetRairyImages(GiftType giftType, int itemId)
		{
		}

		public static Material GetShopSpecialIconMaterial(string iconName, ShopTradeProductData.CommonShopType shopType, IconLoader.Size size = IconLoader.Size.M)
		{
			return null;
		}

		private static string GetShopIconSubFolder(ShopTradeProductData.CommonShopType shopType)
		{
			return null;
		}

		public static void SetPackIcon(Image image, ShopTradeProductData.CommonShopType shopType, string fileName)
		{
		}

		public override void OnIconLongPressed()
		{
		}
	}
}
