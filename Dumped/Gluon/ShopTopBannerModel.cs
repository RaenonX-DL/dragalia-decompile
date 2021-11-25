using System.Collections.Generic;
using Gluon.Master;
using UnityEngine.UI;

namespace Gluon
{
	public static class ShopTopBannerModel
	{
		public class BannerData
		{
			public enum Type
			{
				Top,
				Center
			}

			public enum SlideBannerType
			{
				SlideBanner = 1,
				FixedBanner
			}

			private enum MasterPageType
			{
				None,
				Top,
				Special,
				Limited,
				Material,
				Trade,
				Amulet,
				Diamond,
				Storage,
				Sustainable
			}

			private enum MasterShopType
			{
				None,
				Special,
				MaterialDaily,
				MaterialWeekly,
				MaterialMonthly,
				Normal
			}

			public int pickGroupId;

			public int bgId;

			public int mainImageId;

			public int goodsId;

			public SlideBannerType bannerType;

			public int popupImageId;

			public ShopTradeModel.PanelType displayPage;

			public List<ShopTradeProductData.CommonShopType> shopTypeList;

			public Type type;

			public ShopTradeProductData.CommonShopType toShopType => default(ShopTradeProductData.CommonShopType);

			public ShopTradeModel.PanelType toPage => default(ShopTradeModel.PanelType);

			public bool EqualsTo(BannerData o)
			{
				return default(bool);
			}

			private void ConvertMasterPageType(int masterPageType)
			{
			}

			private void ConvertMasterShopType(int masterShopType)
			{
			}

			public static BannerData WrapTopBanner(ShopHeaderBannerElement elem)
			{
				return null;
			}

			public static BannerData WrapCenterBanner(ShopCenterBannerElement elem)
			{
				return null;
			}

			public void UpdateImage(Image image)
			{
			}

			public void UpdateBGImage(Image image)
			{
			}
		}

		public static List<BannerData> GetTopBannersForPage(ShopTradeModel.PanelType page)
		{
			return null;
		}

		public static List<BannerData> GetCenterBanners()
		{
			return null;
		}
	}
}
