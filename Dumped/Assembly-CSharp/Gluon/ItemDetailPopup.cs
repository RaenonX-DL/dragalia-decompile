/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ItemDetailPopup : CommonPopup
	{
		// Fields
		public ItemListPopup itemListPopup;
		[SerializeField]
		private CommonIcon itemIcon;
		[SerializeField]
		private UnityEngine.UI.Text itemNameText;
		[FormerlySerializedAs]
		[SerializeField]
		private UnityEngine.UI.Text descriptionText;
		[SerializeField]
		private UnityEngine.UI.Text dateText;
		[SerializeField]
		private UnityEngine.UI.Text overLimitWarningText;
		[SerializeField]
		private GameObject normalObj;
		[SerializeField]
		private GameObject tradeObj;
		[SerializeField]
		private Button tradeOkButton;
		private const string prefabPath = "Prefabs/OutGame/Item/ItemDetailPopup";
		private int useLimit;
		private int itemId;
	
		// Nested types
		public enum ShowType
		{
			MenuItemList = 0,
			Other = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<int> __9__14_5;
			public static Action __9__14_9;
			public static Func<char, bool> __9__15_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _InitSetting_b__14_5(int quest);
			internal void _InitSetting_b__14_9();
			internal bool _InitWithShopSpecialIconSetting_b__15_1(char c);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public int[] moveQuests;
			public GiftType giftType;
			public int itemId;
			public ItemDetailPopup __4__this;
			public string description;
			public UnityAction __9__2;
			public UnityAction __9__4;
			public UnityAction __9__8;
			public UnityAction __9__7;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _SetupMaterialPopup_b__0();
			internal void _SetupMaterialPopup_b__2();
			internal void _SetupMaterialPopup_b__1();
			internal void _SetupMaterialPopup_b__4();
			internal void _SetupMaterialPopup_b__6();
			internal void _SetupMaterialPopup_b__7();
			internal void _SetupMaterialPopup_b__8();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_1
		{
			// Fields
			public ItemGetQuestListPopup popup;
			public __c__DisplayClass16_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass16_1();
	
			// Methods
			internal void _SetupMaterialPopup_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_2
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass16_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass16_2();
	
			// Methods
			internal void _SetupMaterialPopup_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public TradeItemOnTheSpotPopup popup;
			public ItemDetailPopup __4__this;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _OnFetchFromTradeButtonPressed_b__1();
		}
	
		// Constructors
		public ItemDetailPopup();
	
		// Methods
		public static ItemDetailPopup Create();
		public void InitSetting(GiftType giftType, int itemId, bool isBackList = true, bool isInInventory = true, bool isShowNumberOwned = false, bool canTrade = false, bool enableChangeScene = true, ShowType showType = ShowType.Other);
		public void InitWithShopSpecialIconSetting(ShopCommonIcon.SpecialIconSetting specialIcon);
		private UnityAction SetupMaterialPopup(GiftType giftType, int itemId, string itemName, string detail, string description, DetailLinkType detailLinkType, int[] moveQuests, bool isInInventory = true);
		public void SetUseLimitText(int useLimit);
		public override void OnOkButtonPressed();
		public void OnFetchFromTradeButtonPressed();
		private void OnError(ErrorType errorType, int resultCode);
		private void LoadSceneShopTrade(ShopTradeModel.PanelType nextPanel);
		private bool IsUseLimitOver();
		public void SetItemCount(int count);
		[CompilerGenerated]
		private void _InitSetting_b__14_0();
		[CompilerGenerated]
		private void _InitSetting_b__14_1();
		[CompilerGenerated]
		private void _InitSetting_b__14_3();
		[CompilerGenerated]
		private void _InitSetting_b__14_4();
		[CompilerGenerated]
		private void _InitSetting_b__14_2();
		[CompilerGenerated]
		private void _InitSetting_b__14_6();
		[CompilerGenerated]
		private void _InitSetting_b__14_7();
		[CompilerGenerated]
		private void _InitSetting_b__14_8();
		[CompilerGenerated]
		private void _InitWithShopSpecialIconSetting_b__15_0();
		[CompilerGenerated]
		private void _OnFetchFromTradeButtonPressed_b__19_0();
		[CompilerGenerated]
		private void _OnFetchFromTradeButtonPressed_b__19_2();
	}
}
