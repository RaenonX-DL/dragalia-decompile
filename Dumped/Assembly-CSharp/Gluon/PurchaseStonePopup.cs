/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using NPF;
using NPF.NPFWrapper;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PurchaseStonePopup : ShopCommonPopup
	{
		// Fields
		[Header]
		[SerializeField]
		public PurchaseStoneTableViewController tableview;
		[Header]
		[SerializeField]
		public Transform topPart;
		public UnityEngine.UI.Text ownedPaidStoneText;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__8_2;
			public static Action<ShopGetListResponse> __9__8_0;
			public static Action<ErrorType, int> __9__8_1;
			public static Action<NPFErrorParam> __9__9_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _RequestForPaymentData_b__8_0(ShopGetListResponse res);
			internal void _RequestForPaymentData_b__8_2();
			internal void _RequestForPaymentData_b__8_1(ErrorType type, int n);
			internal void _UpdateStoneShopData_b__9_1(NPFErrorParam error);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public Action onLoadDone;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _UpdateStoneShopData_b__0(List<NPFPayment.ProductInfo> bundles);
		}
	
		// Constructors
		public PurchaseStonePopup();
	
		// Methods
		public static void CreateModule(GameObject destroyWatcher, Action onPurchaseDone, Action onCancelled);
		public static void CreateModuleForShopSceneCompatibility(GameObject destroyWatcher, Action onPurchaseDone, Action onCancelled, bool isDialog, Transform frameParent, RectTransform referenceRect);
		public static void ReloadModuleData();
		public void ReloadContents();
		protected override void Start();
		private static void RequestForPaymentData();
		private static void UpdateStoneShopData(Action onLoadDone);
		private static void CreateCurrentModule();
		private static void OnClosePopup();
		protected override void OnPanelModeSet();
		[CompilerGenerated]
		private void _ReloadContents_b__6_0();
	}
}
