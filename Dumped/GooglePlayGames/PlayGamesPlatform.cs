using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesPlatform : ISocialPlatform
	{
		private static PlayGamesPlatform sInstance;

		private static bool sNearbyInitializePending;

		private static INearbyConnectionClient sNearbyConnectionClient;

		private readonly PlayGamesClientConfiguration mConfiguration;

		private PlayGamesLocalUser mLocalUser;

		private IPlayGamesClient mClient;

		private string mDefaultLbUi;

		private Dictionary<string, string> mIdMap;

		public static bool DebugLogEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static PlayGamesPlatform Instance => null;

		public static INearbyConnectionClient Nearby => null;

		public ISavedGameClient SavedGame => null;

		public IEventsClient Events => null;

		public IVideoClient Video => null;

		public ILocalUser localUser => null;

		internal PlayGamesPlatform(IPlayGamesClient client)
		{
		}

		private PlayGamesPlatform(PlayGamesClientConfiguration configuration)
		{
		}

		public static void InitializeInstance(PlayGamesClientConfiguration configuration)
		{
		}

		public static void InitializeNearby(Action<INearbyConnectionClient> callback)
		{
		}

		public static PlayGamesPlatform Activate()
		{
			return null;
		}

		public void SetGravityForPopups(Gravity gravity)
		{
		}

		public void AddIdMapping(string fromId, string toId)
		{
		}

		public void Authenticate(Action<bool> callback)
		{
		}

		public void Authenticate(Action<bool, string> callback)
		{
		}

		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		public void Authenticate(SignInInteractivity signInInteractivity, Action<SignInStatus> callback)
		{
		}

		public void Authenticate(ILocalUser unused, Action<bool> callback)
		{
		}

		public void Authenticate(ILocalUser unused, Action<bool, string> callback)
		{
		}

		public bool IsAuthenticated()
		{
			return default(bool);
		}

		public void SignOut()
		{
		}

		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		public string GetUserId()
		{
			return null;
		}

		public string GetIdToken()
		{
			return null;
		}

		public string GetServerAuthCode()
		{
			return null;
		}

		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		public string GetUserEmail()
		{
			return null;
		}

		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		public string GetUserDisplayName()
		{
			return null;
		}

		public string GetUserImageUrl()
		{
			return null;
		}

		public void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
		}

		public void RevealAchievement(string achievementID, [Optional] Action<bool> callback)
		{
		}

		public void UnlockAchievement(string achievementID, [Optional] Action<bool> callback)
		{
		}

		public void IncrementAchievement(string achievementID, int steps, Action<bool> callback)
		{
		}

		public void SetStepsAtLeast(string achievementID, int steps, Action<bool> callback)
		{
		}

		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
		}

		public void LoadAchievements(Action<IAchievement[]> callback)
		{
		}

		public IAchievement CreateAchievement()
		{
			return null;
		}

		public void ReportScore(long score, string board, Action<bool> callback)
		{
		}

		public void ReportScore(long score, string board, string metadata, Action<bool> callback)
		{
		}

		public void LoadScores(string leaderboardId, Action<IScore[]> callback)
		{
		}

		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		public ILeaderboard CreateLeaderboard()
		{
			return null;
		}

		public void ShowAchievementsUI()
		{
		}

		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		public void ShowLeaderboardUI()
		{
		}

		public void ShowLeaderboardUI(string leaderboardId)
		{
		}

		public void ShowLeaderboardUI(string leaderboardId, Action<UIStatus> callback)
		{
		}

		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		public void SetDefaultLeaderboardForUI(string lbid)
		{
		}

		public void LoadFriends(ILocalUser user, Action<bool> callback)
		{
		}

		public void LoadScores(ILeaderboard board, Action<bool> callback)
		{
		}

		public void RequestPermission(string scope, Action<SignInStatus> callback)
		{
		}

		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		public bool HasPermission(string scope)
		{
			return default(bool);
		}

		public bool HasPermissions(string[] scopes)
		{
			return default(bool);
		}

		public bool GetLoading(ILeaderboard board)
		{
			return default(bool);
		}

		public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback)
		{
		}

		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback)
		{
		}

		public void AskForLoadFriendsResolution(Action<UIStatus> callback)
		{
		}

		public LoadFriendsStatus GetLastLoadFriendsStatus()
		{
			return default(LoadFriendsStatus);
		}

		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback)
		{
		}

		internal void HandleLoadingScores(PlayGamesLeaderboard board, LeaderboardScoreData scoreData, Action<bool> callback)
		{
		}

		internal IUserProfile[] GetFriends()
		{
			return null;
		}

		private string MapId(string id)
		{
			return null;
		}

		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
		{
		}

		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}
	}
}
