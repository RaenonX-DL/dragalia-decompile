/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TradeItemDonePopup : ShopCommonPopup
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text itemName;
		public CommonIcon icon;
		public UnityEngine.UI.Text ownedCount;
		public UnityEngine.UI.Text sentToPresentBoxText;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text singleExchangedText;
		public UnityEngine.UI.Text multiExchangedText;
		public GameObject ownedCountParent;
		[SerializeField]
		private List<GameObject> rarityObjs;
		private Action onPopupClosed;
	
		// Constructors
		public TradeItemDonePopup();
	
		// Methods
		public static TradeItemDonePopup Create(ShopTradeProductData.TradeShopItemData data, int tradedCount, Action onPopupClosed);
		public static TradeItemDonePopup Create(string itemName, GiftType giftType, int itemId, int limitBreak, int bunchCount, bool sentToPresentBox, int tradedCount, Action onPopupClosed);
		private void Init(string itemName, GiftType giftType, int itemId, int limitBreak, int bunchCount, bool sentToPresentBox, int tradedCount);
	}
}
