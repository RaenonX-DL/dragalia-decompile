/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DreamSelectItemPopup : PopupBase, ICustomMessage
	{
		// Fields
		public const string path = "Prefabs/OutGame/ShopTrade/Popup/DreamSelectItemPopup";
		[SerializeField]
		private DreamSelectItemCtrl[] tabCtrls;
		[SerializeField]
		private TabBase tabView;
		[SerializeField]
		private UnityEngine.UI.Text periodText;
		[SerializeField]
		private UnityEngine.UI.Text remainCountText;
		[SerializeField]
		private float sortButtonPosY;
		[CompilerGenerated]
		private ShopTradeProductData.CommonShopItemData _itemData_k__BackingField;
		private CommonSortButton sortButton;
	
		// Properties
		public ShopTradeProductData.CommonShopItemData itemData { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public DreamSelectItemPopup __4__this;
			public List<ulong> keyIds;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _OnSortButtonClicked_b__0();
		}
	
		// Constructors
		public DreamSelectItemPopup();
	
		// Methods
		public static void Create(ShopTradeProductData.CommonShopItemData itemData);
		private void Awake();
		private void OnEnable();
		private void OnDisable();
		protected override void Start();
		private List<ulong> CreateDataIdList(GiftType giftType);
		private void OnSortButtonClicked();
		private void UpdateSortAndFilter(int tabViewIndex);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _Start_b__15_0(int index, bool calledFromUI);
		[CompilerGenerated]
		private void _OnMessagReceived_b__19_0();
	}
}
