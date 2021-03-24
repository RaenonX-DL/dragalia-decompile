/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopCommonIcon : CommonIcon
	{
		// Fields
		[SerializeField]
		private GameObject[] rarityImages;
		private ShopTradeProductData.CommonShopItemContentData contentData;
		private const string specialMaterialTemplate = "Images/Icon/ShopSpecialItem/{0}/{1}";
		private SpecialIconSetting specialIconInfo;
		private static SpecialIconSetting[] specialIcons;
		private static int specialItemIndex;
	
		// Nested types
		public class SpecialIconSetting
		{
			// Fields
			public string iconName;
			public string name;
			public string description;
			public ShopTradeProductData.CommonShopType shopType;
	
			// Constructors
			public SpecialIconSetting();
			public SpecialIconSetting(string iconName, string name, string description, ShopTradeProductData.CommonShopType shopType);
	
			// Methods
			public SpecialIconSetting MakeClone();
		}
	
		// Constructors
		public ShopCommonIcon();
		static ShopCommonIcon();
	
		// Methods
		public static void SetSpecialContentNameAndDescription(SpecialIconSetting[] specialIcons = null);
		public override void SetupByGiftTypeAndId(GiftType giftType, int id, IconLoader.Size size = IconLoader.Size.M, int level = 1, int limitBreak = 0, int rarity = 4, int additionalMaxLevel = 0, int limitOver = 0);
		public void SetupByShopContentData(ShopTradeProductData.CommonShopItemContentData contentData, ShopTradeProductData.CommonShopItemData.PackContentType contentType, ShopTradeProductData.CommonShopType shopType);
		private int GetRarity(GiftType giftType, int itemId);
		private void SetRairyImages(GiftType giftType, int itemId);
		public static Material GetShopSpecialIconMaterial(string iconName, ShopTradeProductData.CommonShopType shopType, IconLoader.Size size = IconLoader.Size.M);
		private static string GetShopIconSubFolder(ShopTradeProductData.CommonShopType shopType);
		public static void SetPackIcon(Image image, ShopTradeProductData.CommonShopType shopType, string fileName);
		public override void OnIconLongPressed();
	}
}
