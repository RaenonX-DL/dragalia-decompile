/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using UnityEngine.SocialPlatforms;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi
{
	public class DummyClient : IPlayGamesClient
	{
		// Constructors
		public DummyClient();
	
		// Methods
		public void Authenticate(bool silent, Action<SignInStatus> callback);
		public bool IsAuthenticated();
		public void SignOut();
		public string GetIdToken();
		public string GetUserId();
		public string GetServerAuthCode();
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);
		public string GetUserEmail();
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);
		public string GetUserDisplayName();
		public string GetUserImageUrl();
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);
		public void LoadAchievements(Action<Achievement[]> callback);
		public void UnlockAchievement(string achId, Action<bool> callback);
		public void RevealAchievement(string achId, Action<bool> callback);
		public void IncrementAchievement(string achId, int steps, Action<bool> callback);
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback);
		public void ShowAchievementsUI(Action<UIStatus> callback);
		public void AskForLoadFriendsResolution(Action<UIStatus> callback);
		public LoadFriendsStatus GetLastLoadFriendsStatus();
		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback);
		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback);
		public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback);
		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback);
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);
		public int LeaderboardMaxResults();
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback);
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback);
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback);
		public bool HasPermissions(string[] scopes);
		public ISavedGameClient GetSavedGameClient();
		public IEventsClient GetEventsClient();
		public IVideoClient GetVideoClient();
		public void LoadFriends(Action<bool> callback);
		public IUserProfile[] GetFriends();
		public void SetGravityForPopups(Gravity gravity);
		private static void LogUsage();
	}
}
