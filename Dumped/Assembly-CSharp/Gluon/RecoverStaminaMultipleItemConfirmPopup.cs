/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RecoverStaminaMultipleItemConfirmPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text commentText;
		[SerializeField]
		private GameObject LackStaminaTextParent;
		[SerializeField]
		private UnityEngine.UI.Text insufficientStaminaCommentText;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text beforeStaminaText;
		[SerializeField]
		private UnityEngine.UI.Text afterStaminaText;
		[SerializeField]
		private UnityEngine.UI.Text staminaTabText;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text staminaExceedsLimitText;
		[SerializeField]
		private Button useButton;
		[SerializeField]
		private RecoverStaminaMultiItemListController controller;
		[CompilerGenerated]
		private int _beforeStamina_k__BackingField;
		private int _afterStamina;
		private bool isCreateRecoverDonePopup;
		[CompilerGenerated]
		private int _absoluteStaminaMax_k__BackingField;
		private StaminaUtilBase staminaUtil;
	
		// Properties
		private int beforeStamina { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int afterStamina { get; set; }
		public int absoluteStaminaMax { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public RecoverStaminaMultipleItemConfirmPopup();
	
		// Methods
		public static RecoverStaminaMultipleItemConfirmPopup CreateWithModel(bool isCreateRecoverDonePopup);
		private void Setup(bool isCreateRecoverDonePopup);
		private bool IsUseButtonInteractable();
		protected override void Start();
		public void OnUseButtonPressed();
		public void OnCloseButtonPressed();
	}
}
