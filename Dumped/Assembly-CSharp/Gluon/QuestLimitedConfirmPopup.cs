/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestLimitedConfirmPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/QuestPrepare/QuestLimitedConfirmPopup";
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
		private UnityEngine.UI.Text firstConfirmText;
		[SerializeField]
		private Image firstElementalIcon;
		[SerializeField]
		private LocalizeTextLayoutPadding iconVerticalPadding;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text secondConfirmText;
		[SerializeField]
		private Image secondElementalIcon;
		[SerializeField]
		private UnityEngine.UI.Text forCalcText;
		[SerializeField]
		private UnityEngine.UI.Text forCalcTtitleText;
		[Header]
		[SerializeField]
		private GameObject limitedWeaponTypeTitleIconPanel;
		[SerializeField]
		private GameObject limitedWeaponTypeFirstIconPanel;
		[SerializeField]
		private GameObject limitedWeaponTypeSecondIconPanel;
		[SerializeField]
		private Image limitedWeaponTypeBaseIcon;
		[SerializeField]
		private Image thirdElementalIcon;
		private string firstElementStr;
		private string secondElementStr;
		private UnityEvent cancelButtonPressed;
		private UnityEvent changePartyButtonPressed;
		private static readonly Localize.TextId[] limitedElementalTypeFirstTextIdList;
		private static readonly Localize.TextId[] limitedElementalTypeSecondTextIdList;
		private static readonly Localize.TextId[] limitedElementalAndWeaponTypeTextIdList;
		private LimitedQuestType limitedQuestType;
	
		// Nested types
		public enum LimitedQuestType
		{
			OnlyElementalType = 0,
			OnlyWeaponType = 1,
			ElementalAndWeaponType = 2,
			None = 3,
			Max = 4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public UnityAction closeCallback;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _SetCallback_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public UnityAction cancelCallback;
			public UnityAction changePartyCallback;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _SetCallback_b__0();
			internal void _SetCallback_b__1();
		}
	
		// Constructors
		public QuestLimitedConfirmPopup();
		static QuestLimitedConfirmPopup();
	
		// Methods
		public static QuestLimitedConfirmPopup Create(ElementalType limitedElementalType, List<WeaponType> limitedWeaponTypeList, bool setChangePartyButton);
		private void SetupTextAndIcon(ElementalType limitedElementalType, List<WeaponType> limitedWeaponTypeList);
		private void SetupLimitedElementalTextAndIcon(ElementalType limitedElementalType);
		private void SetupLimitedElementalAndWeaponTextAndIcon(ElementalType limitedElementalType, List<WeaponType> limitedWeaponTypeList);
		private void BuildLayout();
		private new void Start();
		private void InitializeButtons(bool setPartyChangeButton);
		public void SetCallback(UnityAction closeCallback);
		public void SetCallback(UnityAction cancelCallback, UnityAction changePartyCallback);
		public void OnCancelButtonPressed();
		public void OnChangePartyButtonPressed();
		public void OnCloseButtonPressed();
	}
}
