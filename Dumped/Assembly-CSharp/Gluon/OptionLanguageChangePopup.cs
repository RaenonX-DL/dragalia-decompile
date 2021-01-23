/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OptionLanguageChangePopup : PopupBase
	{
		// Fields
		public OptionLanguageSelectToggle[] toggles;
		public OptionLanguageSelectToggle[] voiceToggles;
		public UnityEngine.UI.Text voiceComment;
		private Action<Localize.Language, Localize.Language> onActionDone;
		private Localize.Language toChangeLanguage;
		private Localize.Language selectedLanguage;
		private Localize.Language toChangeVoiceLanguage;
		private Localize.Language selectedVoiceLanguage;
		private OptionLanguageSettingPopup.FromType fromType;
		private bool isVoiceOn;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public CommonPopup popup;
			public OptionLanguageChangePopup __4__this;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _OnOKButtonPressed_b__0();
			internal void _OnOKButtonPressed_b__1();
		}
	
		// Constructors
		public OptionLanguageChangePopup();
	
		// Methods
		public static OptionLanguageChangePopup Create(Action<Localize.Language, Localize.Language> onActionDone, OptionLanguageSettingPopup.FromType fromType);
		protected override void Start();
		private void UpdateVoiceComment();
		private void SetupToggle(OptionLanguageSelectToggle[] settingToggles, Localize.Language settingSelectedLanguage);
		public void OnCancelButtonPressed();
		public void OnOKButtonPressed();
		public void OnLanguageChecked(Localize.Language uiSelectedLanguage);
		public void OnVoiceLanguageChecked(Localize.Language uiSelectedLanguage);
		public void RefreshDisplayLanguage();
	}
}
