/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SSRSummonTicketShopInfoPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text titleText;
		public UnityEngine.UI.Text topText;
		[Header]
		[SerializeField]
		public RawImage image;
		[Header]
		[SerializeField]
		public CommonIcon diamondIcon;
		public CommonIcon[] ssrTicketIcons;
		public GameObject[] ssrTicketIconGOs;
		[Header]
		[SerializeField]
		public Button purchaseButton;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text limitCountText;
		public UnityEngine.UI.Text priceText;
		public UnityEngine.UI.Text insufficientText;
		[Header]
		[SerializeField]
		public GameObject[] charaDescriptionGOs;
		public GameObject[] dragonDescritptionGOs;
		[Header]
		[SerializeField]
		public GameObject specifiedCommercialActObj;
		public UnityEngine.UI.Text specifiedCommercialTransactionActText;
		private Action onPurchaseDone;
		private const string imagePathTemplate = "Images/OutGame/Shop/Top/SummonTicketPack/{0}";
	
		// Nested types
		public class PackModel
		{
			// Fields
			private static PackModel instance;
			public int diamondCount;
			public List<int> ssrTicketIds;
			public List<SummonTicketShopInfo> summonTicketShopItems;
			public int price;
			public long completeDate;
			public int tradeId;
			public string productId;
			public ShopTradeProductData.CommonShopItemData data;
	
			// Properties
			public static PackModel Instance { get; }
	
			// Constructors
			private PackModel();
			static PackModel();
	
			// Methods
			public static void DeleteInstance();
		}
	
		public class SummonTicketShopInfo
		{
			// Fields
			public int id;
			public GiftType type;
			public int count;
	
			// Constructors
			public SummonTicketShopInfo();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__19_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Setup_b__19_0();
		}
	
		[CompilerGenerated]
		private struct _OnOddsButtonClicked_d__20 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int i;
			private SummonTicketElement _elem_5__2;
			private TaskAwaiter<SummonGetOddsDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public SSRSummonTicketShopInfoPopup();
	
		// Methods
		public static void CreateModule(ShopTradeProductData.CommonShopItemData item, Action onPurchaseDone);
		private void Setup();
		public async void OnOddsButtonClicked(int i);
		public void OnPurchaseButtonClicked();
		public void OnSpecifiedCommercialTransactionActPressed();
		[CompilerGenerated]
		private void _OnPurchaseButtonClicked_b__21_0(ShopTradeAgeSelectPopup.AgeGroup ageGroup);
		[CompilerGenerated]
		private void _OnPurchaseButtonClicked_b__21_1();
	}
}
