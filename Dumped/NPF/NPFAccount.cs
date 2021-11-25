using System;
using Gluon;
using NPF.NPFWrapper;
using NPF.User;
using UnityEngine.Events;

namespace NPF
{
	public class NPFAccount
	{
		public const string accountQAURL = "https://www.nintendo.co.jp/support/my_nintendo/account-restart.html";

		private const string lang_jp = "jp-JP";

		private const string lang_en = "en-US";

		private const string lang_zh_traditional = "zh-TW";

		private NPFErrorParam lastError;

		private const int NPF_ERROR_NA_LINKED_CODE = 409;

		public void SwitchNintendoAccount(BaaSUser user, Action NintendoAccountLinkSucceed, Action NintendoAccountSwitchSucceed)
		{
		}

		public void LinkByNintendoAccount(BaaSUser user, Action NintendoAccountLinkSucceed)
		{
		}

		public void AuthorizeByNintentoAccount()
		{
		}

		private void RetryNAAuth(NintendoAccount nintendoAccount)
		{
		}

		public void NintendoAccountAuthErrorHandler(NPFError error)
		{
		}

		private void NintendoAccountAuthErrorTypeHandler(NPFErrorParam error)
		{
		}

		public void SetLanguage(Localize.Language language)
		{
		}

		private void OpenLoadingPopup()
		{
		}

		private void CloseLoadingPopup()
		{
		}

		private void ErrorPopup(int errorCode)
		{
		}

		private void ErrorPopup(string errorTitle, string errorMessage)
		{
		}

		private void GetRegion(UnityAction<string> next)
		{
		}

		private void CancelPopup(NPFErrorParam lastError)
		{
		}

		public void NintendoAccountCountryCodeNotAvalible()
		{
		}

		private void NintendoAccountAuthErrorPopup()
		{
		}

		private void NintendoAccountStatusErrorPopup(string url)
		{
		}

		private void AuthSucceedPopup()
		{
		}

		public void EULAUpdatePopup()
		{
		}

		private void CreateWarningPopup(string region)
		{
		}
	}
}
