/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames
{
	public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser
	{
		// Fields
		internal PlayGamesPlatform mPlatform;
		private string emailAddress;
		private PlayerStats mStats;
	
		// Properties
		public IUserProfile[] friends { get; }
		public bool authenticated { get; }
		public bool underage { get; }
		public new string userName { get; }
		public new string id { get; }
		public new bool isFriend { get; }
		public new UserState state { get; }
		public new string AvatarURL { get; }
		public string Email { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public PlayGamesLocalUser __4__this;
			public Action<CommonStatusCodes, PlayerStats> callback;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _GetStats_b__0(CommonStatusCodes rc, PlayerStats stats);
		}
	
		// Constructors
		internal PlayGamesLocalUser(PlayGamesPlatform plaf);
	
		// Methods
		public void Authenticate(Action<bool> callback);
		public void Authenticate(Action<bool, string> callback);
		public void Authenticate(Action<bool> callback, bool silent);
		public void Authenticate(Action<bool, string> callback, bool silent);
		public void LoadFriends(Action<bool> callback);
		public string GetIdToken();
		public void GetStats(Action<CommonStatusCodes, PlayerStats> callback);
	}
}
