using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF;
using NPF.User;
using NPF.VCM;
using UnityEngine.Events;

namespace Gluon
{
	public class NPFEventHandlerImpl : NPFSDK.NPFEventHandler
	{
		private NPFAccount account;

		public UnityAction<BaaSUser> BaaSUserAuthSucceed;

		public static bool isHandlingPendingPurchase;

		private static bool isIgnoreNAAuthError;

		private static bool isBassAuthNetworkErrorPopupOpened;

		public static bool isBootScene
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool IsIgnoreNAAuthError
		{
			set
			{
			}
		}

		public void OnBaaSAuthError(NPFError error)
		{
		}

		public void OnBaaSAuthStart()
		{
		}

		public void OnBaaSAuthUpdate(BaaSUser user)
		{
		}

		private void CheckBaaSUserStatus(BaaSUser user)
		{
		}

		public void OnNintendoAccountAuthError(NPFError error)
		{
		}

		private static void CallAfterBootScene(Action next)
		{
		}

		private static IEnumerator DelayedCall(Action next)
		{
			return null;
		}

		public void OnVirtualCurrencyPurchaseProcessError(NPFError error)
		{
		}

		public void OnVirtualCurrencyPurchaseProcessSuccess(IDictionary<string, VirtualCurrencyWallet> wallets)
		{
		}

		public void OnVirtualCurrencyPurchaseHasPendingPurchase()
		{
		}

		private void BassAuthNetworkErrorPopup(NPFError error)
		{
		}

		private void BassAuthErrorPopup(NPFError error)
		{
		}

		private void SetLanguage()
		{
		}

		public void OnPendingAuthorizationByNintendoAccount2()
		{
		}

		public void OnPendingSwitchByNintendoAccount2()
		{
		}

		public void OnVirtualCurrencyPurchasesUpdated()
		{
		}
	}
}
