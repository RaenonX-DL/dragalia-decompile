/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LanguageOptionModel
	{
		// Fields
		private static LanguageOptionModel instance;
		public const string oldOptionPrefString = "LanguageOptionSetting";
		public const string optionLocalizePrefString = "LocalizeLanguageOptionSetting";
		public static Localize.Language preRegisterSelectedLocalizeSystemLanguage;
		public Setting setting;
		public LocalizeSetting localizeSetting;
	
		// Properties
		public static LanguageOptionModel Instance { get; }
	
		// Nested types
		[Serializable]
		public class Setting
		{
			// Fields
			public SystemLanguage displayLanguage;
			public SystemLanguage voiceLanguage;
	
			// Constructors
			public Setting();
		}
	
		[Serializable]
		public class LocalizeSetting
		{
			// Fields
			public Localize.Language displayLanguage;
			public Localize.Language voiceLanguage;
	
			// Constructors
			public LocalizeSetting();
		}
	
		// Constructors
		private LanguageOptionModel();
		static LanguageOptionModel();
	
		// Methods
		public void ApplyLanguageOptions();
		public void SaveSetting();
		private bool LoadSetting();
		public static bool isSettingExist();
		public static Localize.Language GetVoiceLanguage();
		public static void ApplyOptionsOnTitle();
		public void OnDisplayLanguageChangedFromOutterOption();
		public void OnVoiceLanguageChangedFromOutterOption(Localize.Language voiceLanguage);
		public static void ConvertSettingData(Setting setting, ref LocalizeSetting localizeSetting);
	}
}
