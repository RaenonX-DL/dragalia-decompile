/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestLimitedElementConfirmPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/QuestPrepare/QuestLimitedElementConfirmPopup";
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text popupTitle;
		[SerializeField]
		private Button cancelButton;
		[SerializeField]
		private UnityEngine.UI.Text cancelText;
		[SerializeField]
		private Button changePartyButton;
		[SerializeField]
		private UnityEngine.UI.Text changePartyText;
		[SerializeField]
		private Button closeButton;
		[SerializeField]
		private UnityEngine.UI.Text closeText;
		[Header]
		[SerializeField]
		private Image titleElementIcon;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text firstElementalText;
		[SerializeField]
		private Image firstElementalIcon;
		[SerializeField]
		private LocalizeTextLayoutPadding firstElementTextPadding;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text secondElementalText;
		[SerializeField]
		private Image secondElementalIcon;
		[SerializeField]
		private LocalizeTextLayoutPadding secondElementTextPadding;
		private string firstElementStr;
		private string secondElementStr;
		private const string FormatIconTagText = "{0}";
		private const string FormatIconTagReplaceText = "    ";
		private const string FormatIconTagReplaceText_ZH_TW = "     ";
		private UnityEvent cancelButtonPressed;
		private UnityEvent changePartyButtonPressed;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public UnityAction closeCallback;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _SetCallback_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public UnityAction cancelCallback;
			public UnityAction changePartyCallback;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _SetCallback_b__0();
			internal void _SetCallback_b__1();
		}
	
		// Constructors
		public QuestLimitedElementConfirmPopup();
	
		// Methods
		public static QuestLimitedElementConfirmPopup Create(ElementalType limitedElementalType, bool setChangePartyButton);
		private void Initialize(ElementalType limitedElementalType, bool setChangePartyButton);
		private new void Start();
		private void InitializeButtons(bool setPartyChangeButton);
		public void SetCallback(UnityAction closeCallback);
		public void SetCallback(UnityAction cancelCallback, UnityAction changePartyCallback);
		public void OnCancelButtonPressed();
		public void OnChangePartyButtonPressed();
		public void OnCloseButtonPressed();
	}
}
