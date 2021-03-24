/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OptionLanguageSettingPopup : PopupBase
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text commentText;
		public PointerEventHandler cancelButton;
		public PointerEventHandler closeButton;
		public GameObject singleButtonGameObject;
		public GameObject doubleButtonGameObject;
		private Action<Localize.Language, Localize.Language> onOk;
		private FromType fromType;
		private Localize.Language savedLanguage;
		private Localize.Language toChangeLanguage;
		private Localize.Language savedVoiceLanguage;
		private Localize.Language toChangeVoiceLanguage;
		private bool isVoiceOn;
	
		// Nested types
		public enum FromType
		{
			FirstBoot = 0,
			TitleMenu = 1,
			Option = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public CommonPopup popup;
			public OptionLanguageSettingPopup __4__this;
			public Action<PushNotificationUpdateSettingResponse> __9__2;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _OnOKButtonPressed_b__0();
			internal void _OnOKButtonPressed_b__2(PushNotificationUpdateSettingResponse res);
			internal void _OnOKButtonPressed_b__1();
		}
	
		// Constructors
		public OptionLanguageSettingPopup();
	
		// Methods
		public static OptionLanguageSettingPopup Create(Action<Localize.Language, Localize.Language> onOk, FromType fromType);
		protected override void Start();
		public void RefreshDisplayLanguage();
		public void OnChangeDisplayLanguageButtonPressed();
		public void OnCancelButtonPressed();
		public void OnOKButtonPressed();
		[CompilerGenerated]
		private void _OnChangeDisplayLanguageButtonPressed_b__16_0(Localize.Language displayLanguage, Localize.Language voiceLanguage);
	}
}
