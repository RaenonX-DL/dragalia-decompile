/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Android
{
	internal class AndroidTokenClient : TokenClient
	{
		// Fields
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
	
		// Nested types
		private class ResultCallbackProxy : AndroidJavaProxy
		{
			// Fields
			private Action<AndroidJavaObject> mCallback;
	
			// Constructors
			public ResultCallbackProxy(Action<AndroidJavaObject> callback);
	
			// Methods
			public void onResult(AndroidJavaObject tokenResult);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__20_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Signout_b__20_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public AndroidTokenClient __4__this;
			public bool silent;
			public Action<int> callback;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _FetchTokens_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public Action<SignInStatus> callback;
			public AndroidTokenClient __4__this;
			public string[] scopes;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _RequestPermissions_b__0(AndroidJavaObject accountWithNewScopes);
			internal void _RequestPermissions_b__1(AndroidJavaObject e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public AndroidTokenClient __4__this;
			public Action<int> callback;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _DoFetchToken_b__0(AndroidJavaObject tokenResult);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public AndroidTokenClient __4__this;
			public bool reAuthenticateIfNeeded;
			public Action<string> callback;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _GetAnotherServerAuthCode_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public Action<string> callback;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _DoGetAnotherServerAuthCode_b__0(AndroidJavaObject tokenResult);
		}
	
		// Constructors
		public AndroidTokenClient();
	
		// Methods
		public void SetRequestAuthCode(bool flag, bool forceRefresh);
		public void SetRequestEmail(bool flag);
		public void SetRequestIdToken(bool flag);
		public void SetWebClientId(string webClientId);
		public void SetHidePopups(bool flag);
		public void SetAccountName(string accountName);
		public void AddOauthScopes(params string[] scopes);
		public void Signout();
		public string GetEmail();
		public string GetAuthCode();
		public string GetIdToken();
		public void FetchTokens(bool silent, Action<int> callback);
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback);
		public bool HasPermissions(string[] scopes);
		private void DoFetchToken(bool silent, Action<int> callback);
		public AndroidJavaObject GetAccount();
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);
		private void DoGetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);
	}
}
