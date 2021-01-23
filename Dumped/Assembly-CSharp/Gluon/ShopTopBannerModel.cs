/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class ShopTopBannerModel
	{
		// Nested types
		public class BannerData
		{
			// Fields
			public int pickGroupId;
			public int bgId;
			public int mainImageId;
			public int goodsId;
			public SlideBannerType bannerType;
			public int popupImageId;
			public ShopTradeModel.PanelType displayPage;
			public List<ShopTradeProductData.CommonShopType> shopTypeList;
			public Type type;
	
			// Properties
			public ShopTradeProductData.CommonShopType toShopType { get; }
			public ShopTradeModel.PanelType toPage { get; }
	
			// Nested types
			public enum Type
			{
				Top = 0,
				Center = 1
			}
	
			public enum SlideBannerType
			{
				SlideBanner = 1,
				FixedBanner = 2
			}
	
			private enum MasterPageType
			{
				None = 0,
				Top = 1,
				Special = 2,
				Limited = 3,
				Material = 4,
				Trade = 5,
				Amulet = 6,
				Diamond = 7,
				Storage = 8,
				Sustainable = 9
			}
	
			private enum MasterShopType
			{
				None = 0,
				Special = 1,
				MaterialDaily = 2,
				MaterialWeekly = 3,
				MaterialMonthly = 4,
				Normal = 5
			}
	
			// Constructors
			public BannerData();
	
			// Methods
			public bool EqualsTo(BannerData o);
			private void ConvertMasterPageType(int masterPageType);
			private void ConvertMasterShopType(int masterShopType);
			public static BannerData WrapTopBanner(ShopHeaderBannerElement elem);
			public static BannerData WrapCenterBanner(ShopCenterBannerElement elem);
			public void UpdateImage(Image image);
			public void UpdateBGImage(Image image);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public ShopTradeModel.PanelType page;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal bool _GetTopBannersForPage_b__3(BannerData x);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<ShopHeaderBannerElement, int> __9__1_0;
			public static Func<ShopHeaderBannerElement, bool> __9__1_1;
			public static Func<ShopHeaderBannerElement, BannerData> __9__1_2;
			public static Func<ShopCenterBannerElement, int> __9__2_0;
			public static Func<ShopCenterBannerElement, bool> __9__2_1;
			public static Func<ShopCenterBannerElement, BannerData> __9__2_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetTopBannersForPage_b__1_0(ShopHeaderBannerElement x);
			internal bool _GetTopBannersForPage_b__1_1(ShopHeaderBannerElement x);
			internal BannerData _GetTopBannersForPage_b__1_2(ShopHeaderBannerElement x);
			internal int _GetCenterBanners_b__2_0(ShopCenterBannerElement x);
			internal bool _GetCenterBanners_b__2_1(ShopCenterBannerElement x);
			internal BannerData _GetCenterBanners_b__2_2(ShopCenterBannerElement x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public BannerData item;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal bool _GetCenterBanners_b__3(BannerData a);
		}
	
		// Methods
		public static List<BannerData> GetTopBannersForPage(ShopTradeModel.PanelType page);
		public static List<BannerData> GetCenterBanners();
	}
}
