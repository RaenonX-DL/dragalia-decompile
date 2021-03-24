/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RecoverStaminaFinalConfirmPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject[] iconFrames;
		public CommonIcon[] icons;
		public UnityEngine.UI.Text commentText;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text beforeStaminaText;
		public UnityEngine.UI.Text afterStaminaText;
		public UnityEngine.UI.Text staminaTabText;
		[SerializeField]
		private GameObject overText;
		[SerializeField]
		private Button okButton;
		private bool isStone;
		private bool isFreeStone;
		private bool isMulti;
		private bool isJuice;
		private EntityData[] usedItem;
		private Action onSuccessOrHttpFailed;
		public ItemListPopup itemListPopup;
		private bool isShowRecoverDonePopup;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public Action onSuccessOrHttpFailed;
			public bool isFreeStone;
			public bool isShowDonePopup;
			public bool isMulti;
			public int beforeStone;
			public EntityData[] usedItem;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _CallRequestUseStone_b__0(ShopNormalShopPurchaseResponse res);
			internal void _CallRequestUseStone_b__1(ErrorType errorType, int errorCode);
			internal void _CallRequestUseStone_b__2();
		}
	
		// Constructors
		public RecoverStaminaFinalConfirmPopup();
	
		// Methods
		public static RecoverStaminaFinalConfirmPopup Create(int beforeStamina, int afterStamina, bool isMulti, EntityData[] usedItem, Action onSucessOrHttpFailed, bool isShowDonePopup, bool isFreeStone = true, int stoneValue = 50, bool isJuice = false);
		private void Setup(int beforeStamina, int afterStamina, bool isMulti, EntityData[] usedItem, bool isFreeStone, int stoneValue, bool isJuice);
		private void OnSuccessOrHttpFailed();
		public void OnCancelButtonPressed();
		public void OnOkButtonPressed();
		public void RequestUseItem();
		public static void CallRequestUseStone(bool isFreeStone, bool isMulti, EntityData[] usedItem, Action onSuccessOrHttpFailed, bool isShowDonePopup);
		public void RequestUseStone();
		private static void OnHttpError(ErrorType errorType, int errorCode, Action onFailed);
		[CompilerGenerated]
		private void _RequestUseItem_b__21_0(ItemUseRecoveryStaminaResponse res);
		[CompilerGenerated]
		private void _RequestUseItem_b__21_1(ErrorType errorType, int errorCode);
		[CompilerGenerated]
		private void _RequestUseItem_b__21_2();
		[CompilerGenerated]
		private void _RequestUseStone_b__23_0();
	}
}
