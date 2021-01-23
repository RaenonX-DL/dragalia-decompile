/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PurchaseShopItemPopup : ShopCommonPopup
	{
		// Fields
		[Header]
		[SerializeField]
		public PurchaseShopItemTableViewController tableview;
		[Header]
		[SerializeField]
		public Transform topPart;
		public UnityEngine.UI.Text ownedPaidStoneText;
		private UnityAction onCloseCallbak;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public GiftType giftType;
			public UnityAction OnOkCallback;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _CreateModule_b__0(ShopGetListResponse res);
		}
	
		// Constructors
		public PurchaseShopItemPopup();
	
		// Methods
		public static void CreateModule(GiftType giftType, UnityAction OnOkCallback = null, bool connect = false);
		public void SetContent(GiftType giftType);
		public void popupUpdate();
		public override void OnCloseButtonPressed();
	}
}
