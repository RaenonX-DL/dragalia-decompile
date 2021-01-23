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
	public class ShopSustainableInfoPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject[] dailyCrystalGOs;
		public GameObject[] dailyStaminaGOs;
		public GameObject[] questBonusGOs;
		[SerializeField]
		private MaintenanceButtonController purchageButtonMaintenance;
		private ShopTradeProductData.CommonShopItemData.PackContentType contentType;
	
		// Constructors
		public ShopSustainableInfoPopup();
	
		// Methods
		public static ShopSustainableInfoPopup Create(ShopTradeProductData.CommonShopItemData.PackContentType contentType);
		protected override void Start();
		public void OnOKButtonPressed();
		public static void SwitchToSustainableItem(ShopTradeProductData.CommonShopItemData.PackContentType packContentType);
	}
}
