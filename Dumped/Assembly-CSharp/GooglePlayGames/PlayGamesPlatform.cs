/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using UnityEngine.SocialPlatforms;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames
{
	public class PlayGamesPlatform : ISocialPlatform
	{
		// Fields
		private static PlayGamesPlatform sInstance;
		private static bool sNearbyInitializePending;
		private static INearbyConnectionClient sNearbyConnectionClient;
		private readonly PlayGamesClientConfiguration mConfiguration;
		private PlayGamesLocalUser mLocalUser;
		private IPlayGamesClient mClient;
		private string mDefaultLbUi;
		private Dictionary<string, string> mIdMap;
	
		// Properties
		public static bool DebugLogEnabled { get; set; }
		public static PlayGamesPlatform Instance { get; }
		public static INearbyConnectionClient Nearby { get; }
		public ISavedGameClient SavedGame { get; }
		public IEventsClient Events { get; }
		public IVideoClient Video { get; }
		public ILocalUser localUser { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public Action<INearbyConnectionClient> callback;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _InitializeNearby_b__0(INearbyConnectionClient client);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public Action<bool> callback;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _Authenticate_b__0(bool success, string msg);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public Action<bool, string> callback;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _Authenticate_b__0(SignInStatus status);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public Action<SignInStatus> callback;
			public PlayGamesPlatform __4__this;
			public Action<SignInStatus> __9__5;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _Authenticate_b__1(SignInStatus code);
			internal void _Authenticate_b__2(SignInStatus code);
			internal void _Authenticate_b__3(SignInStatus silentSignInResultCode);
			internal void _Authenticate_b__5(SignInStatus interactiveSignInResultCode);
			internal void _Authenticate_b__4();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<SignInStatus> __9__34_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Authenticate_b__34_0(SignInStatus status);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public Action<string> callback;
			public PlayGamesPlatform __4__this;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _GetAnotherServerAuthCode_b__0(SignInStatus status);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public string achievementID;
			public double progress;
			public PlayGamesPlatform __4__this;
			public Action<bool> callback;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal void _ReportProgress_b__0(Achievement[] ach);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public Action<IAchievementDescription[]> callback;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal void _LoadAchievementDescriptions_b__0(Achievement[] ach);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public Action<IAchievement[]> callback;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _LoadAchievements_b__0(Achievement[] ach);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public Action<IScore[]> callback;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _LoadScores_b__0(LeaderboardScoreData scoreData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0
		{
			// Fields
			public PlayGamesPlatform __4__this;
			public ILeaderboard board;
			public Action<bool> callback;
	
			// Constructors
			public __c__DisplayClass70_0();
	
			// Methods
			internal void _LoadScores_b__0(LeaderboardScoreData scoreData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0
		{
			// Fields
			public PlayGamesPlatform __4__this;
			public PlayGamesLeaderboard board;
			public Action<bool> callback;
	
			// Constructors
			public __c__DisplayClass82_0();
	
			// Methods
			internal void _HandleLoadingScores_b__0(LeaderboardScoreData nextScoreData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass85_0<T>
		{
			// Fields
			public Action<T> callback;
			public T data;
	
			// Constructors
			public __c__DisplayClass85_0();
	
			// Methods
			internal void _InvokeCallbackOnGameThread_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_0<T>
		{
			// Fields
			public Action<T> toConvert;
	
			// Constructors
			public __c__DisplayClass86_0();
	
			// Methods
			internal void _ToOnGameThread_b__1(T val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_1<T>
		{
			// Fields
			public T val;
			public __c__DisplayClass86_0<T> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass86_1();
	
			// Methods
			internal void _ToOnGameThread_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__86<T>
		{
			// Fields
			public static readonly __c__86<T> __9;
			public static Action<T> __9__86_0;
	
			// Constructors
			static __c__86();
			public __c__86();
	
			// Methods
			internal void _ToOnGameThread_b__86_0(T _p0_);
		}
	
		// Constructors
		internal PlayGamesPlatform(IPlayGamesClient client);
		private PlayGamesPlatform(PlayGamesClientConfiguration configuration);
		static PlayGamesPlatform();
	
		// Methods
		public static void InitializeInstance(PlayGamesClientConfiguration configuration);
		public static void InitializeNearby(Action<INearbyConnectionClient> callback);
		public static PlayGamesPlatform Activate();
		public void SetGravityForPopups(Gravity gravity);
		public void AddIdMapping(string fromId, string toId);
		public void Authenticate(Action<bool> callback);
		public void Authenticate(Action<bool, string> callback);
		public void Authenticate(Action<bool> callback, bool silent);
		public void Authenticate(Action<bool, string> callback, bool silent);
		public void Authenticate(SignInInteractivity signInInteractivity, Action<SignInStatus> callback);
		public void Authenticate(ILocalUser unused, Action<bool> callback);
		public void Authenticate(ILocalUser unused, Action<bool, string> callback);
		public bool IsAuthenticated();
		public void SignOut();
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);
		public string GetUserId();
		public string GetIdToken();
		public string GetServerAuthCode();
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);
		public string GetUserEmail();
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);
		public string GetUserDisplayName();
		public string GetUserImageUrl();
		public void ReportProgress(string achievementID, double progress, Action<bool> callback);
		public void RevealAchievement(string achievementID, Action<bool> callback = null);
		public void UnlockAchievement(string achievementID, Action<bool> callback = null);
		public void IncrementAchievement(string achievementID, int steps, Action<bool> callback);
		public void SetStepsAtLeast(string achievementID, int steps, Action<bool> callback);
		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback);
		public void LoadAchievements(Action<IAchievement[]> callback);
		public IAchievement CreateAchievement();
		public void ReportScore(long score, string board, Action<bool> callback);
		public void ReportScore(long score, string board, string metadata, Action<bool> callback);
		public void LoadScores(string leaderboardId, Action<IScore[]> callback);
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);
		public ILeaderboard CreateLeaderboard();
		public void ShowAchievementsUI();
		public void ShowAchievementsUI(Action<UIStatus> callback);
		public void ShowLeaderboardUI();
		public void ShowLeaderboardUI(string leaderboardId);
		public void ShowLeaderboardUI(string leaderboardId, Action<UIStatus> callback);
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);
		public void SetDefaultLeaderboardForUI(string lbid);
		public void LoadFriends(ILocalUser user, Action<bool> callback);
		public void LoadScores(ILeaderboard board, Action<bool> callback);
		public void RequestPermission(string scope, Action<SignInStatus> callback);
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback);
		public bool HasPermission(string scope);
		public bool HasPermissions(string[] scopes);
		public bool GetLoading(ILeaderboard board);
		public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback);
		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback);
		public void AskForLoadFriendsResolution(Action<UIStatus> callback);
		public LoadFriendsStatus GetLastLoadFriendsStatus();
		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback);
		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback);
		internal void HandleLoadingScores(PlayGamesLeaderboard board, LeaderboardScoreData scoreData, Action<bool> callback);
		internal IUserProfile[] GetFriends();
		private string MapId(string id);
		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data);
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert);
	}
}
