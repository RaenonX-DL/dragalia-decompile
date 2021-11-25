using System;
using GooglePlayGames.BasicApi;

namespace GooglePlayGames
{
	internal interface TokenClient
	{
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

		void AddOauthScopes(string[] scopes);

		void SetHidePopups(bool flag);

		void FetchTokens(bool silent, Action<int> callback);

		void RequestPermissions(string[] scopes, Action<SignInStatus> callback);

		bool HasPermissions(string[] scopes);
	}
}
