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
	public class RecoverStaminaSingleItemConfirmPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonIcon icon;
		public UnityEngine.UI.Text itemName;
		public UnityEngine.UI.Text itemDescription;
		public UnityEngine.UI.Text stoneComment;
		public UnityEngine.UI.Text insufficientStaminaCommentText;
		public UnityEngine.UI.Text titleText;
		[Header]
		[SerializeField]
		public CommonSliderSelection slider;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text beforeStaminaText;
		public UnityEngine.UI.Text afterStaminaText;
		public UnityEngine.UI.Text beforeInventoryCountText;
		public UnityEngine.UI.Text afterInventoryCountText;
		public UnityEngine.UI.Text staminaTabText;
		public UnityEngine.UI.Text priceText;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text staminaExceedsLimitText;
		public UnityEngine.UI.Text stoneStaminaExceedsLimitText;
		public Button okButton;
		[Header]
		[SerializeField]
		public GameObject[] stoneOnlyGOs;
		public GameObject[] itemOnlyGOs;
		public GameObject[] paidStoneOnlyGOs;
		public GameObject[] freeStoneOnlyGOs;
		public Button stonePlusButton;
		public Button stoneMinusButton;
		public UnityEngine.UI.Text itemNameTabText;
		[Header]
		[SerializeField]
		private List<MaintenanceFunctionType> maintenanceTypes;
		private int itemId;
		private bool isFreeStone;
		private int useCount;
		private StaminaUtilBase staminaUtil;
		private int recoveryPointPerItem;
		private int beforeStamina;
		private int inventoryCount;
		private bool isMulti;
		private int afterStamina;
		public ItemListPopup itemListPopup;
		private bool isShowRecoverDonePopup;
	
		// Constructors
		public RecoverStaminaSingleItemConfirmPopup();
	
		// Methods
		public static RecoverStaminaSingleItemConfirmPopup Create(int itemId);
		public static RecoverStaminaSingleItemConfirmPopup CreateForStoneWithModel(bool isFreeStone, bool isCreateRecoverDonePopup);
		protected override void Start();
		private bool IsUseButtonInteractable(int useCount);
		public void OnSliderValueChanged(float val);
		public void OnUseButtonPressed();
		public void OnCloseButtonPressed();
		[CompilerGenerated]
		private void _OnUseButtonPressed_b__40_0();
	}
}
