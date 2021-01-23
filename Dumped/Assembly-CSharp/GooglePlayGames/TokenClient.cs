/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames
{
	internal interface TokenClient
	{
		// Methods
		string GetEmail();
		string GetAuthCode();
		string GetIdToken();
		void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);
		void Signout();
		void SetRequestAuthCode(bool flag, bool forceRefresh);
		void SetRequestEmail(bool flag);
		void SetRequestIdToken(bool flag);
		void SetWebClientId(string webClientId);
		void SetAccountName(string accountName);
		void AddOauthScopes(params string[] scopes);
		void SetHidePopups(bool flag);
		void FetchTokens(bool silent, Action<int> callback);
		void RequestPermissions(string[] scopes, Action<SignInStatus> callback);
		bool HasPermissions(string[] scopes);
	}
}
