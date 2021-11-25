using UnityEngine;

namespace Gluon
{
	public class LocalizeUtil
	{
		public enum LocationCode
		{
			JP,
			TW,
			MO,
			HK,
			US,
			SG,
			CA,
			AU,
			NZ,
			GB,
			IE,
			None
		}

		public enum LanguageCode
		{
			ja,
			en,
			zh_Hans,
			zh_Hant,
			None
		}

		public static string[] replaceStringForUrlParameter;

		public static bool SetAppLangSameAsDeviceLangIfPossible()
		{
			return default(bool);
		}

		public static Localize.Language GetAppLangByDeviceLang()
		{
			return default(Localize.Language);
		}

		public static SystemLanguage GetDeviceLangByAppLang(Localize.Language appLang)
		{
			return default(SystemLanguage);
		}

		public static LanguageCode GetDeviceLanguageCode()
		{
			return default(LanguageCode);
		}

		public static bool IsDeviceLangIncludedInAppLangList()
		{
			return default(bool);
		}

		public static bool IsDeviceLanguageEnglish()
		{
			return default(bool);
		}

		public static LocationCode GetDeviceCountryCode()
		{
			return default(LocationCode);
		}

		public static string FormatLocalizedString(Localize.TextId textId, object[] args)
		{
			return null;
		}

		public static bool IsAnotherNameRubyNeeded()
		{
			return default(bool);
		}

		public static bool ShouldAvoidLineBreakOnSpaceForLanguage(Localize.Language lang)
		{
			return default(bool);
		}
	}
}
