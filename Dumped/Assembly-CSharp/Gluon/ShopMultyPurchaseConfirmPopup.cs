/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopMultyPurchaseConfirmPopup : ShopPurchaseConfirmPopupBase
	{
		// Fields
		[SerializeField]
		private CommonSliderSelection buyCountSlider;
	
		// Constructors
		public ShopMultyPurchaseConfirmPopup();
	
		// Methods
		public static ShopMultyPurchaseConfirmPopup Create(ShopTradeProductData.CommonShopItemData data, Action onPurchaseDone);
		protected override void Start();
		protected override void RefreshPurchaseInfo(int buyCount = 1);
		private void RefreshSliderInfo();
		[CompilerGenerated]
		private void _Start_b__2_0(float value);
	}
}
