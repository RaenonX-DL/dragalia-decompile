/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopCommonPurchaseConfirmPopup : ShopPurchaseConfirmPopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GridLayoutGroup contentParent;
		public GridLayoutGroup bonusParent;
		public GridLayoutGroup missionContentParent;
		public UnityEngine.UI.Text contentTitleText;
		public GameObject[] missionContents;
		public GameObject[] bonusContents;
		public GameObject specifiedCommercialActObj;
		public UnityEngine.UI.Text specifiedCommercialTransactionActText;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public ShopTradeProductData.CommonShopItemData data;
			public Action onPurchaseDone;
			public Action __9__0;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public ShopCommonPurchaseConfirmPopup();
	
		// Methods
		public static void Create(ShopTradeProductData.CommonShopItemData data, Action onPurchaseDone);
		private static ShopCommonPurchaseConfirmPopup DoCreate(ShopTradeProductData.CommonShopItemData data, Action onPurchaseDone);
		protected override void Start();
		private void GoChallengeMissionScene(MissionTableViewData data);
	}
}
