using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class ShopTradePanelBase : MonoBehaviour
	{
		protected ShopTradeScene scene;

		public ShopTradeProductData.CommonShopType initShopType
		{
			[CompilerGenerated]
			get
			{
				return default(ShopTradeProductData.CommonShopType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual void OnCellButtonPressed(ShopTradeProductData.TradeShopItemData data)
		{
		}

		public virtual void OnCellButtonPressedForCommonItem(ShopTradeProductData.CommonShopItemData data)
		{
		}

		public void PlayExitAnimation(Action onFinished, AnimationUICanvas.AnimationPattern pattern = AnimationUICanvas.AnimationPattern.Pattern_1)
		{
		}

		public void OnMenuButtonPressed(ShopTradeMenuButton button)
		{
		}

		[HideInInspector]
		public void OnMenuButtonPressed(ShopTradeModel.PanelType type)
		{
		}

		public virtual void RefreshCurrentPage()
		{
		}

		public virtual void ScrollToItem(int tradeId)
		{
		}
	}
}
