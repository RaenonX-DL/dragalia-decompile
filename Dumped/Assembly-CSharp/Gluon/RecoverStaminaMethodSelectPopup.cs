/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using NPF;
using NPF.NPFWrapper;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RecoverStaminaMethodSelectPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text titleText;
		public UnityEngine.UI.Text commentText;
		public UnityEngine.UI.Text ownedStoneText;
		public UnityEngine.UI.Text ownedPaidStoneText;
		public UnityEngine.UI.Text itemRecoverCommentText;
		public UnityEngine.UI.Text insufficientStaminaCommentText;
		[Header]
		[SerializeField]
		public Button itemButton;
		public Button freeStoneButton;
		public Button paidStoneButton;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text paidStoneText;
		public UnityEngine.UI.Text freeStoneText;
		public GameObject multiStaminaIconGO;
		private bool insufficientOfStone;
		private bool isCreateByQuest;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public bool isQuest;
			public Action<List<NPFPayment.ProductInfo>> __9__1;
			public Action<List<NPFPayment.ProductInfo>> __9__4;
			public Action<ShopGetListResponse> __9__3;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _CreateModule_b__0(ItemGetListResponse itemRes);
			internal void _CreateModule_b__1(List<NPFPayment.ProductInfo> infoList);
			internal void _CreateModule_b__3(ShopGetListResponse res);
			internal void _CreateModule_b__4(List<NPFPayment.ProductInfo> infoList);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<NPFErrorParam> __9__15_2;
			public static Action<NPFErrorParam> __9__15_5;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CreateModule_b__15_2(NPFErrorParam error);
			internal void _CreateModule_b__15_5(NPFErrorParam error);
		}
	
		// Constructors
		public RecoverStaminaMethodSelectPopup();
	
		// Methods
		public static bool IsInShopMaintenance();
		public static void CreateModule(GameObject destroyWatcherAttach, bool isMulti, int requiredStamina, Action onDoneWithAnyAction, Action onCancelled, bool isQuest = false);
		private static RecoverStaminaMethodSelectPopup Create();
		protected override void Start();
		public void OnUseFreeStoneButtonPressed();
		public void OnUseOrPurchaseStoneButtonPressed();
		public void ReCreatePopup();
		public void OnUIseItemButtonPressed();
		public void OnCloseButtonPressed();
	}
}
