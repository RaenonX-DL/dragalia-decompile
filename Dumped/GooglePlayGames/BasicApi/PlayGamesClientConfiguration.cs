using System.Collections.Generic;

namespace GooglePlayGames.BasicApi
{
	public struct PlayGamesClientConfiguration
	{
		public class Builder
		{
			private bool mEnableSaveGames;

			private List<string> mScopes;

			private bool mHidePopups;

			private bool mRequestAuthCode;

			private bool mForceRefresh;

			private bool mRequestEmail;

			private bool mRequestIdToken;

			private string mAccountName;

			public Builder EnableSavedGames()
			{
				return null;
			}

			public Builder EnableHidePopups()
			{
				return null;
			}

			public Builder RequestServerAuthCode(bool forceRefresh)
			{
				return null;
			}

			public Builder RequestEmail()
			{
				return null;
			}

			public Builder RequestIdToken()
			{
				return null;
			}

			public Builder SetAccountName(string accountName)
			{
				return null;
			}

			public Builder AddOauthScope(string scope)
			{
				return null;
			}

			public PlayGamesClientConfiguration Build()
			{
				return default(PlayGamesClientConfiguration);
			}

			internal bool HasEnableSaveGames()
			{
				return default(bool);
			}

			internal bool IsRequestingAuthCode()
			{
				return default(bool);
			}

			internal bool IsHidingPopups()
			{
				return default(bool);
			}

			internal bool IsForcingRefresh()
			{
				return default(bool);
			}

			internal bool IsRequestingEmail()
			{
				return default(bool);
			}

			internal bool IsRequestingIdToken()
			{
				return default(bool);
			}

			internal string GetAccountName()
			{
				return null;
			}

			internal string[] getScopes()
			{
				return null;
			}
		}

		public static readonly PlayGamesClientConfiguration DefaultConfiguration;

		private readonly bool mEnableSavedGames;

		private readonly string[] mScopes;

		private readonly bool mRequestAuthCode;

		private readonly bool mForceRefresh;

		private readonly bool mHidePopups;

		private readonly bool mRequestEmail;

		private readonly bool mRequestIdToken;

		private readonly string mAccountName;

		public bool EnableSavedGames => default(bool);

		public bool IsHidingPopups => default(bool);

		public bool IsRequestingAuthCode => default(bool);

		public bool IsForcingRefresh => default(bool);

		public bool IsRequestingEmail => default(bool);

		public bool IsRequestingIdToken => default(bool);

		public string AccountName => null;

		public string[] Scopes => null;

		private PlayGamesClientConfiguration(Builder builder)
		{
		}

		public static bool operator ==(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2)
		{
			return default(bool);
		}

		public static bool operator !=(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
}
