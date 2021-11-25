using System;
using UnityEngine;

namespace Gluon
{
	public class LanguageOptionModel
	{
		[Serializable]
		public class Setting
		{
			public SystemLanguage displayLanguage;

			public SystemLanguage voiceLanguage;
		}

		[Serializable]
		public class LocalizeSetting
		{
			public Localize.Language displayLanguage;

			public Localize.Language voiceLanguage;
		}

		private static LanguageOptionModel instance;

		public const string oldOptionPrefString = "LanguageOptionSetting";

		public const string optionLocalizePrefString = "LocalizeLanguageOptionSetting";

		public static Localize.Language preRegisterSelectedLocalizeSystemLanguage;

		public Setting setting;

		public LocalizeSetting localizeSetting;

		public static LanguageOptionModel Instance => null;

		private LanguageOptionModel()
		{
		}

		static LanguageOptionModel()
		{
		}

		public void ApplyLanguageOptions()
		{
		}

		public void SaveSetting()
		{
		}

		private bool LoadSetting()
		{
			return default(bool);
		}

		public static bool isSettingExist()
		{
			return default(bool);
		}

		public static Localize.Language GetVoiceLanguage()
		{
			return default(Localize.Language);
		}

		public static void ApplyOptionsOnTitle()
		{
		}

		public void OnDisplayLanguageChangedFromOutterOption()
		{
		}

		public void OnVoiceLanguageChangedFromOutterOption(Localize.Language voiceLanguage)
		{
		}

		public static void ConvertSettingData(Setting setting, ref LocalizeSetting localizeSetting)
		{
		}
	}
}
