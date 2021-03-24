/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi
{
	public struct PlayGamesClientConfiguration
	{
		// Fields
		public static readonly PlayGamesClientConfiguration DefaultConfiguration;
		private readonly bool mEnableSavedGames;
		private readonly string[] mScopes;
		private readonly bool mRequestAuthCode;
		private readonly bool mForceRefresh;
		private readonly bool mHidePopups;
		private readonly bool mRequestEmail;
		private readonly bool mRequestIdToken;
		private readonly string mAccountName;
	
		// Properties
		public bool EnableSavedGames { get; }
		public bool IsHidingPopups { get; }
		public bool IsRequestingAuthCode { get; }
		public bool IsForcingRefresh { get; }
		public bool IsRequestingEmail { get; }
		public bool IsRequestingIdToken { get; }
		public string AccountName { get; }
		public string[] Scopes { get; }
	
		// Nested types
		public class Builder
		{
			// Fields
			private bool mEnableSaveGames;
			private List<string> mScopes;
			private bool mHidePopups;
			private bool mRequestAuthCode;
			private bool mForceRefresh;
			private bool mRequestEmail;
			private bool mRequestIdToken;
			private string mAccountName;
	
			// Constructors
			public Builder();
	
			// Methods
			public Builder EnableSavedGames();
			public Builder EnableHidePopups();
			public Builder RequestServerAuthCode(bool forceRefresh);
			public Builder RequestEmail();
			public Builder RequestIdToken();
			public Builder SetAccountName(string accountName);
			public Builder AddOauthScope(string scope);
			public PlayGamesClientConfiguration Build();
			internal bool HasEnableSaveGames();
			internal bool IsRequestingAuthCode();
			internal bool IsHidingPopups();
			internal bool IsForcingRefresh();
			internal bool IsRequestingEmail();
			internal bool IsRequestingIdToken();
			internal string GetAccountName();
			internal string[] getScopes();
		}
	
		// Constructors
		private PlayGamesClientConfiguration(Builder builder);
		static PlayGamesClientConfiguration();
	
		// Methods
		public static bool operator ==(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2);
		public static bool operator !=(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2);
		public override int GetHashCode();
		public override bool Equals(object obj);
	}
}
