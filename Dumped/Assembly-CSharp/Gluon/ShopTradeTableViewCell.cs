/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradeTableViewCell : TableViewCell<Gluon.ShopTradeProductData.TradeShopItemData>
	{
		// Fields
		[SerializeField]
		public UnityEventShopItemData buttonPressed;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text nameText;
		public UnityEngine.UI.Text limitCountText;
		public UnityEngine.UI.Text priceText;
		public UnityEngine.UI.Text endTimeText;
		public UnityEngine.UI.Text commentText;
		public CommonIcon icon;
		public bool isUseShortQuantityLimit;
		public bool hideQuantityLimitPrefix;
		[Header]
		[SerializeField]
		public GameObject limitCountLine;
		public GameObject timeLimitLine;
		[SerializeField]
		private List<GameObject> rarityObjs;
		[Header]
		[SerializeField]
		public ShopTradeMaterialIcon[] materials;
		[Header]
		[SerializeField]
		public GameObject[] moonIconGOs;
		[Header]
		[SerializeField]
		public GameObject newFlag;
		[Header]
		[SerializeField]
		public Button button;
		[Header]
		[SerializeField]
		public GameObject needStoryBlockGO;
		public UnityEngine.UI.Text needStoryText;
		[SerializeField]
		private GameObject lockIconObj;
		[Header]
		[SerializeField]
		private Sprite emptyMaterialSprite;
		[Header]
		[SerializeField]
		public RectTransform bgFrame;
		public int highQuantityLimitLayoutHeight;
		public int lowQuantityLimitLayoutHeight;
		private ShopTradePanelBase panel;
		private ShopTradeProductData.TradeShopItemData data;
		private TradeItemType type;
	
		// Nested types
		public enum TradeItemType
		{
			Common = 0,
			AbilityCrest = 1
		}
	
		[Serializable]
		public class UnityEventShopItemData : UnityEvent<ShopTradeProductData.TradeShopItemData>
		{
			// Constructors
			public UnityEventShopItemData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public bool shouldEnableButton;
			public ShopTradeTableViewCell __4__this;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		// Constructors
		public ShopTradeTableViewCell();
	
		// Methods
		private void Start();
		public override void UpdateContent(ShopTradeProductData.TradeShopItemData data);
		private ShopTradeProductData.InsufficientReason CheckSufficiencyCondition();
		public void OnExchangeButtonPressed();
		private void UpdateUI();
		private void UpdateOKButtonForCrest(bool canExcange);
	}
}
