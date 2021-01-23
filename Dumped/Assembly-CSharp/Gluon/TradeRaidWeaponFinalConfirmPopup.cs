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
	public class TradeRaidWeaponFinalConfirmPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonIcon icon;
		private ShopTradeProductData.TradeShopItemData data;
		private Action onTrade;
	
		// Constructors
		public TradeRaidWeaponFinalConfirmPopup();
	
		// Methods
		public static TradeRaidWeaponFinalConfirmPopup Create(ShopTradeProductData.TradeShopItemData data, Action onTrade);
		protected override void Start();
		public void OnTradeButtonPressed();
	}
}
