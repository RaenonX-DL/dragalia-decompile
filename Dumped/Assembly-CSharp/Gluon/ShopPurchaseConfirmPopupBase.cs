/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using NPF.NPFWrapper;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopPurchaseConfirmPopupBase : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public Image packIcon;
		public UnityEngine.UI.Text packName;
		public UnityEngine.UI.Text packDescription;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text periodText;
		public UnityEngine.UI.Text limitCountText;
		public UnityEngine.UI.Text priceText;
		public UnityEngine.UI.Text realMoneyText;
		public UnityEngine.UI.Text okButtonText;
		public Button okButton;
		[Header]
		[SerializeField]
		public GameObject crystalIcon;
		public GameObject dragonDiamondIcon;
		public GameObject goldIcon;
		public GameObject moonIcon;
		public GameObject manaIcon;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text beforeCountText;
		public UnityEngine.UI.Text afterCountText;
		public UnityEngine.UI.Text insufficientText;
		public UnityEngine.UI.Text overflowText;
		[Header]
		[SerializeField]
		public GameObject periodObj;
		public GameObject resourcesGO;
		public GameObject insufficientTextGO;
		public GameObject overflowTextGO;
		protected ShopTradeProductData.CommonShopItemData data;
		protected Action onPurchaseDone;
		protected bool toPurchaseDia;
		private int buyQuantity;
		private bool isSentToPresentBox;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public Action<ShopTradeAgeSelectPopup.AgeGroup> onCheckDone;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _CheckAgeGroup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public Action onDone;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _ProcessCommonPurchase_b__0(ShopSpecialShopPurchaseResponse res);
			internal void _ProcessCommonPurchase_b__1(ShopMaterialShopPurchaseResponse res);
			internal void _ProcessCommonPurchase_b__2(ShopNormalShopPurchaseResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public int tradeId;
			public ShopTradeProductData.CommonShopType shopType;
			public string productId;
			public Action onDone;
			public Action purchaseAction;
			public Action<ShopGetListResponse> __9__8;
			public Action<int> __9__7;
			public Action __9__5;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _ProcessRealMoneyPurchase_b__0();
			internal void _ProcessRealMoneyPurchase_b__5();
			internal void _ProcessRealMoneyPurchase_b__7(int diaCount);
			internal void _ProcessRealMoneyPurchase_b__8(ShopGetListResponse getListRes);
			internal void _ProcessRealMoneyPurchase_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_1
		{
			// Fields
			public int reqShopType;
			public __c__DisplayClass39_0 CS___8__locals1;
			public Action<NPFErrorParam> __9__6;
	
			// Constructors
			public __c__DisplayClass39_1();
	
			// Methods
			internal void _ProcessRealMoneyPurchase_b__4(ShopPreChargeCheckResponse res);
			internal void _ProcessRealMoneyPurchase_b__6(NPFErrorParam error);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ShopChargeCancelResponse> __9__39_9;
			public static Action<NPFErrorParam> __9__39_2;
			public static Action __9__39_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ProcessRealMoneyPurchase_b__39_9(ShopChargeCancelResponse cancelRes);
			internal void _ProcessRealMoneyPurchase_b__39_2(NPFErrorParam error);
			internal void _ProcessRealMoneyPurchase_b__39_3();
		}
	
		// Constructors
		public ShopPurchaseConfirmPopupBase();
	
		// Methods
		public virtual void Init(ShopTradeProductData.CommonShopItemData data, Action onPurchaseDone);
		protected override void Start();
		public long GetCurrentPaymentCount(out string insufficientTemplate);
		protected virtual void RefreshPurchaseInfo(int buyCount = 1);
		protected void RefreshHoldingInfo(int buyCount = 1);
		private bool CheckOverLimit(int buyCount);
		private static int CalculateAgeCorrect(int year, int month, int day);
		public static void CheckAgeGroup(Action<ShopTradeAgeSelectPopup.AgeGroup> onCheckDone);
		public static ShopCommonPopup CheckUnableToPurchaseTimeForSustainablePack(ShopTradeProductData.CommonShopItemData.PackContentType packContentType);
		public void OnPurchaseButtonPressed();
		private void ProcessPurchase(ShopTradeAgeSelectPopup.AgeGroup ageGroup = ShopTradeAgeSelectPopup.AgeGroup.None);
		private void ProcessCommonPurchase(Action onDone);
		public static void ProcessRealMoneyPurchase(string productId, ShopTradeAgeSelectPopup.AgeGroup ageGroup, ShopTradeProductData.CommonShopType shopType, int tradeId, Action onDone);
		public void OnSpecifiedCommercialTransactionActPressed();
		[CompilerGenerated]
		private void _OnPurchaseButtonPressed_b__36_0();
		[CompilerGenerated]
		private void _OnPurchaseButtonPressed_b__36_1();
		[CompilerGenerated]
		private void _OnPurchaseButtonPressed_b__36_2(ShopTradeAgeSelectPopup.AgeGroup ageGroup);
		[CompilerGenerated]
		private void _ProcessPurchase_b__37_0();
	}
}
