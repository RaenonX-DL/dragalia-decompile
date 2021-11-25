using System.Collections.Generic;

namespace Gluon
{
	public class AgreementUtility
	{
		public static int eulaVersion;

		public static int privacyVersion;

		public static string region;

		public static string lang;

		private const string AgreementConfirmedKey = "ConfirmAgreement";

		public static List<VersionInfo> versionInfos;

		public void SetConfirmedAgreement(bool confirmed = false)
		{
		}

		public bool GetConfirmedAgreement()
		{
			return default(bool);
		}

		public static void UpdateVersionInfo()
		{
		}

		public static string GetEulaAgreementLanguageText(Localize.TextId textId)
		{
			return null;
		}
	}
}
