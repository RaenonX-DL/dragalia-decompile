/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using UnityEngine;
using UnityEngine.SocialPlatforms;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Android
{
	public class AndroidClient : IPlayGamesClient
	{
		// Fields
		private readonly object GameServicesLock;
		private readonly object AuthStateLock;
		private readonly PlayGamesClientConfiguration mConfiguration;
		private ISavedGameClient mSavedGameClient;
		private IEventsClient mEventsClient;
		private IVideoClient mVideoClient;
		private AndroidTokenClient mTokenClient;
		private Player mUser;
		private AuthState mAuthState;
		private IUserProfile[] mFriends;
		private LoadFriendsStatus mLastLoadFriendsStatus;
		private AndroidJavaClass mGamesClass;
		private static string TasksClassName;
		private AndroidJavaObject mFriendsResolutionException;
		private readonly int mLeaderboardMaxResults;
		private readonly int mFriendsMaxResults;
	
		// Nested types
		private enum AuthState
		{
			Unauthenticated = 0,
			Authenticated = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public AndroidClient __4__this;
			public Action<SignInStatus> callback;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _Authenticate_b__0(int result);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_1
		{
			// Fields
			public AndroidJavaObject taskGetPlayer;
			public AndroidJavaObject taskIsCaptureSupported;
			public __c__DisplayClass18_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass18_1();
	
			// Methods
			internal void _Authenticate_b__1(AndroidJavaObject completeTask);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<Achievement[]> __9__18_2;
			public static Action __9__42_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Authenticate_b__18_2(Achievement[] ignore);
			internal void _SignOut_b__42_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0<T>
		{
			// Fields
			public Action<T> callback;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _AsOnGameThreadCallback_b__1(T result);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__19<T>
		{
			// Fields
			public static readonly __c__19<T> __9;
			public static Action<T> __9__19_0;
	
			// Constructors
			static __c__19();
			public __c__19();
	
			// Methods
			internal void _AsOnGameThreadCallback_b__19_0(T _p0_);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public Action callback;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _InvokeCallbackOnGameThread_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0<T>
		{
			// Fields
			public Action<T> callback;
			public T data;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _InvokeCallbackOnGameThread_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0<T1, T2>
		{
			// Fields
			public Action<T1, T2> toInvokeOnGameThread;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _AsOnGameThreadCallback_b__0(T1 result1, T2 result2);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_1<T1, T2>
		{
			// Fields
			public T1 result1;
			public T2 result2;
			public __c__DisplayClass22_0<T1, T2> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass22_1();
	
			// Methods
			internal void _AsOnGameThreadCallback_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0<T1, T2>
		{
			// Fields
			public Action<T1, T2> callback;
			public T1 t1;
			public T2 t2;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _InvokeCallbackOnGameThread_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public AndroidClient __4__this;
			public Action<bool> callback;
			public int pageSize;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _LoadAllFriends_b__0(LoadFriendsStatus result);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public AndroidClient __4__this;
			public Action<LoadFriendsStatus> callback;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _LoadFriendsPaginated_b__0(AndroidJavaObject annotatedData);
			internal void _LoadFriendsPaginated_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_1
		{
			// Fields
			public AndroidJavaObject exception;
			public __c__DisplayClass35_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass35_1();
	
			// Methods
			internal void _LoadFriendsPaginated_b__2(bool resolutionRequired);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public Action<UIStatus> callback;
			public AndroidClient __4__this;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _AskForLoadFriendsResolution_b__0(AndroidJavaObject annotatedData);
			internal void _AskForLoadFriendsResolution_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_1
		{
			// Fields
			public AndroidJavaObject exception;
			public __c__DisplayClass37_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass37_1();
	
			// Methods
			internal void _AskForLoadFriendsResolution_b__2(bool resolutionRequired);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public Action<FriendsListVisibilityStatus> callback;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _GetFriendsListVisibility_b__0(AndroidJavaObject annotatedData);
			internal void _GetFriendsListVisibility_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public Action<CommonStatusCodes, PlayerStats> callback;
			public AndroidClient __4__this;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal void _GetPlayerStats_b__0(AndroidJavaObject annotatedData);
			internal void _GetPlayerStats_b__1(AndroidJavaObject e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public string[] userIds;
			public Action<IUserProfile[]> callback;
	
			// Constructors
			public __c__DisplayClass48_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_1
		{
			// Fields
			public IUserProfile[] users;
			public int count;
			public object countLock;
			public int resultCount;
			public __c__DisplayClass48_0 CS___8__locals1;
			public Action<AndroidJavaObject> __9__0;
	
			// Constructors
			public __c__DisplayClass48_1();
	
			// Methods
			internal void _LoadUsers_b__0(AndroidJavaObject annotatedData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_2
		{
			// Fields
			public int i;
			public __c__DisplayClass48_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass48_2();
	
			// Methods
			internal void _LoadUsers_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public Action<Achievement[]> callback;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _LoadAchievements_b__0(AndroidJavaObject annotatedData);
			internal void _LoadAchievements_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0
		{
			// Fields
			public AndroidClient __4__this;
			public Action<AndroidJavaObject> callback;
	
			// Constructors
			public __c__DisplayClass57_0();
	
			// Methods
			internal void _AddOnFailureListenerWithSignOut_b__0(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public AndroidClient __4__this;
			public Action<UIStatus> callback;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _GetUiSignOutCallbackOnGameThread_b__0(UIStatus status);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_1
		{
			// Fields
			public UIStatus status;
			public __c__DisplayClass58_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass58_1();
	
			// Methods
			internal void _GetUiSignOutCallbackOnGameThread_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public Action<LeaderboardScoreData> callback;
			public AndroidClient __4__this;
			public string leaderboardId;
			public LeaderboardCollection collection;
			public LeaderboardTimeSpan timeSpan;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _LoadScores_b__0(AndroidJavaObject annotatedData);
			internal void _LoadScores_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_1
		{
			// Fields
			public AndroidJavaObject exception;
			public __c__DisplayClass59_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass59_1();
	
			// Methods
			internal void _LoadScores_b__2(bool resolutionRequired);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public Action<LeaderboardScoreData> callback;
			public AndroidClient __4__this;
			public ScorePageToken token;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _LoadMoreScores_b__0(AndroidJavaObject annotatedData);
			internal void _LoadMoreScores_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_1
		{
			// Fields
			public AndroidJavaObject exception;
			public __c__DisplayClass60_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass60_1();
	
			// Methods
			internal void _LoadMoreScores_b__2(bool resolutionRequired);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public AndroidClient __4__this;
			public Action<SignInStatus> callback;
	
			// Constructors
			public __c__DisplayClass64_0();
	
			// Methods
			internal void _RequestPermissions_b__0(SignInStatus code);
		}
	
		// Constructors
		internal AndroidClient(PlayGamesClientConfiguration configuration);
		static AndroidClient();
	
		// Methods
		public void Authenticate(bool silent, Action<SignInStatus> callback);
		private static Action<T> AsOnGameThreadCallback<T>(Action<T> callback);
		private static void InvokeCallbackOnGameThread(Action callback);
		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data);
		private static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread);
		private static void InvokeCallbackOnGameThread<T1, T2>(Action<T1, T2> callback, T1 t1, T2 t2);
		private void InitializeGameServices();
		private void InitializeTokenClient();
		public string GetUserEmail();
		public string GetIdToken();
		public string GetServerAuthCode();
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);
		public bool IsAuthenticated();
		public void LoadFriends(Action<bool> callback);
		private void LoadAllFriends(int pageSize, bool forceReload, bool loadMore, Action<bool> callback);
		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback);
		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback);
		private void LoadFriendsPaginated(int pageSize, bool isLoadMore, bool forceReload, Action<LoadFriendsStatus> callback);
		public LoadFriendsStatus GetLastLoadFriendsStatus();
		public void AskForLoadFriendsResolution(Action<UIStatus> callback);
		public void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback);
		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback);
		public IUserProfile[] GetFriends();
		public void SignOut();
		public void SignOut(Action uiCallback);
		public string GetUserId();
		public string GetUserDisplayName();
		public string GetUserImageUrl();
		public void SetGravityForPopups(Gravity gravity);
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);
		public void LoadAchievements(Action<Achievement[]> callback);
		public void UnlockAchievement(string achId, Action<bool> callback);
		public void RevealAchievement(string achId, Action<bool> callback);
		public void IncrementAchievement(string achId, int steps, Action<bool> callback);
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback);
		public void ShowAchievementsUI(Action<UIStatus> callback);
		public int LeaderboardMaxResults();
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);
		private void AddOnFailureListenerWithSignOut(AndroidJavaObject task, Action<AndroidJavaObject> callback);
		private Action<UIStatus> GetUiSignOutCallbackOnGameThread(Action<UIStatus> callback);
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);
		private LeaderboardScoreData CreateLeaderboardScoreData(string leaderboardId, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ResponseStatus status, AndroidJavaObject leaderboardScoresJava);
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback);
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback);
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback);
		private void UpdateClients();
		public bool HasPermissions(string[] scopes);
		public ISavedGameClient GetSavedGameClient();
		public IEventsClient GetEventsClient();
		public IVideoClient GetVideoClient();
		private AndroidJavaObject getAchievementsClient();
		private AndroidJavaObject getGamesClient();
		private AndroidJavaObject getPlayersClient();
		private AndroidJavaObject getLeaderboardsClient();
		private AndroidJavaObject getPlayerStatsClient();
		private AndroidJavaObject getVideosClient();
	}
}
