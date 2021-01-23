/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LocalizeUtil
	{
		// Fields
		public static string[] replaceStringForUrlParameter;
	
		// Nested types
		public enum LocationCode
		{
			JP = 0,
			TW = 1,
			MO = 2,
			HK = 3,
			US = 4,
			SG = 5,
			CA = 6,
			AU = 7,
			NZ = 8,
			GB = 9,
			IE = 10,
			None = 11
		}
	
		public enum LanguageCode
		{
			ja = 0,
			en = 1,
			zh_Hans = 2,
			zh_Hant = 3,
			None = 4
		}
	
		// Constructors
		public LocalizeUtil();
		static LocalizeUtil();
	
		// Methods
		public static bool SetAppLangSameAsDeviceLangIfPossible();
		public static Localize.Language GetAppLangByDeviceLang();
		public static SystemLanguage GetDeviceLangByAppLang(Localize.Language appLang);
		public static LanguageCode GetDeviceLanguageCode();
		public static bool IsDeviceLangIncludedInAppLangList();
		public static bool IsDeviceLanguageEnglish();
		public static LocationCode GetDeviceCountryCode();
		public static string FormatLocalizedString(Localize.TextId textId, params object[] args);
		public static bool IsAnotherNameRubyNeeded();
		public static bool ShouldAvoidLineBreakOnSpaceForLanguage(Localize.Language lang);
	}
}
