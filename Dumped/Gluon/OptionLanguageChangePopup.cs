using System;
using UnityEngine.UI;

namespace Gluon
{
	public class OptionLanguageChangePopup : PopupBase
	{
		public OptionLanguageSelectToggle[] toggles;

		public OptionLanguageSelectToggle[] voiceToggles;

		public Text voiceComment;

		private Action<Localize.Language, Localize.Language> onActionDone;

		private Localize.Language toChangeLanguage;

		private Localize.Language selectedLanguage;

		private Localize.Language toChangeVoiceLanguage;

		private Localize.Language selectedVoiceLanguage;

		private OptionLanguageSettingPopup.FromType fromType;

		private bool isVoiceOn;

		public static OptionLanguageChangePopup Create(Action<Localize.Language, Localize.Language> onActionDone, OptionLanguageSettingPopup.FromType fromType)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void UpdateVoiceComment()
		{
		}

		private void SetupToggle(OptionLanguageSelectToggle[] settingToggles, Localize.Language settingSelectedLanguage)
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		public void OnOKButtonPressed()
		{
		}

		public void OnLanguageChecked(Localize.Language uiSelectedLanguage)
		{
		}

		public void OnVoiceLanguageChecked(Localize.Language uiSelectedLanguage)
		{
		}

		public void RefreshDisplayLanguage()
		{
		}
	}
}
