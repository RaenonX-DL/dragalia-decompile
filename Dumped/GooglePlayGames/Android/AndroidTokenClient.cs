using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidTokenClient : TokenClient
	{
		private class ResultCallbackProxy : AndroidJavaProxy
		{
			private Action<AndroidJavaObject> mCallback;

			public ResultCallbackProxy(Action<AndroidJavaObject> callback)
			{
			}

			public void onResult(AndroidJavaObject tokenResult)
			{
			}
		}

		private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";

		private bool requestEmail;

		private bool requestAuthCode;

		private bool requestIdToken;

		private List<string> oauthScopes;

		private string webClientId;

		private bool forceRefresh;

		private bool hidePopups;

		private string accountName;

		private AndroidJavaObject account;

		private string email;

		private string authCode;

		private string idToken;

		public void SetRequestAuthCode(bool flag, bool forceRefresh)
		{
		}

		public void SetRequestEmail(bool flag)
		{
		}

		public void SetRequestIdToken(bool flag)
		{
		}

		public void SetWebClientId(string webClientId)
		{
		}

		public void SetHidePopups(bool flag)
		{
		}

		public void SetAccountName(string accountName)
		{
		}

		public void AddOauthScopes(string[] scopes)
		{
		}

		public void Signout()
		{
		}

		public string GetEmail()
		{
			return null;
		}

		public string GetAuthCode()
		{
			return null;
		}

		public string GetIdToken()
		{
			return null;
		}

		public void FetchTokens(bool silent, Action<int> callback)
		{
		}

		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		public bool HasPermissions(string[] scopes)
		{
			return default(bool);
		}

		private void DoFetchToken(bool silent, Action<int> callback)
		{
		}

		public AndroidJavaObject GetAccount()
		{
			return null;
		}

		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		private void DoGetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}
	}
}
