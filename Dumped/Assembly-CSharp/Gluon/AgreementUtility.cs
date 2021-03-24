/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AgreementUtility
	{
		// Fields
		public static int eulaVersion;
		public static int privacyVersion;
		public static string region;
		public static string lang;
		private const string AgreementConfirmedKey = "ConfirmAgreement";
		public static List<VersionInfo> versionInfos;
	
		// Constructors
		public AgreementUtility();
		static AgreementUtility();
	
		// Methods
		public void SetConfirmedAgreement(bool confirmed = false);
		public bool GetConfirmedAgreement();
		public static void UpdateVersionInfo();
		public static string GetEulaAgreementLanguageText(Localize.TextId textId);
	}
}
