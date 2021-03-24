/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradePanelBase : MonoBehaviour
	{
		// Fields
		protected ShopTradeScene scene;
		[CompilerGenerated]
		private ShopTradeProductData.CommonShopType _initShopType_k__BackingField;
	
		// Properties
		public ShopTradeProductData.CommonShopType initShopType { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public ShopTradePanelBase();
	
		// Methods
		public virtual void OnCellButtonPressed(ShopTradeProductData.TradeShopItemData data);
		public virtual void OnCellButtonPressedForCommonItem(ShopTradeProductData.CommonShopItemData data);
		public void PlayExitAnimation(Action onFinished, AnimationUICanvas.AnimationPattern pattern = AnimationUICanvas.AnimationPattern.Pattern_1);
		public void OnMenuButtonPressed(ShopTradeMenuButton button);
		[HideInInspector]
		public void OnMenuButtonPressed(ShopTradeModel.PanelType type);
		public virtual void RefreshCurrentPage();
		public virtual void ScrollToItem(int tradeId);
	}
}
