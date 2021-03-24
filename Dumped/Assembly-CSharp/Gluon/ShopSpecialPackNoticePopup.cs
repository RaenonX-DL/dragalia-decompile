/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopSpecialPackNoticePopup : PopupBase
	{
		// Fields
		[SerializeField]
		public RawImage image;
		public UnityEngine.UI.Text titleText;
		[SerializeField]
		private MaintenanceButtonController okButtonMaintenance;
		private const string imagePathTemplate = "Images/OutGame/Shop/Top/ShopSpecialPackNotice/{0}";
		private List<ShopCenterBannerElement> dataList;
		private Action onDone;
		private const string prefRecordTemplate = "__ShopSpecialPackNoticePopup_{0}";
		private const string prefMontylyRecordTemplate = "__ShopMontylyPackNoticePopup_{0}_{1}";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ShopTradePanelBase> __9__13_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnGoSpecialShop_b__13_0(ShopTradePanelBase panel);
		}
	
		// Constructors
		public ShopSpecialPackNoticePopup();
	
		// Methods
		public static bool ShouldShowMonthlyBadge();
		public static void CreateModule(ShopTradeProductData.CommonShopData limitedShopData, Action onDone);
		private static ShopSpecialPackNoticePopup Create(List<ShopCenterBannerElement> dataList, Action onDone);
		protected override void Start();
		public void OnCloseButtonPressed();
		public void OnGoSpecialShop();
		[CompilerGenerated]
		private void _OnCloseButtonPressed_b__12_0();
	}
}
