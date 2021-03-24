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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi
{
	public interface IPlayGamesClient
	{
		// Methods
		void Authenticate(bool silent, Action<SignInStatus> callback);
		bool IsAuthenticated();
		void SignOut();
		string GetUserId();
		void LoadFriends(Action<bool> callback);
		string GetUserDisplayName();
		string GetIdToken();
		string GetServerAuthCode();
		void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);
		string GetUserEmail();
		string GetUserImageUrl();
		void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);
		void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);
		void LoadAchievements(Action<Achievement[]> callback);
		void UnlockAchievement(string achievementId, Action<bool> successOrFailureCalllback);
		void RevealAchievement(string achievementId, Action<bool> successOrFailureCalllback);
		void IncrementAchievement(string achievementId, int steps, Action<bool> successOrFailureCalllback);
		void SetStepsAtLeast(string achId, int steps, Action<bool> callback);
		void ShowAchievementsUI(Action<UIStatus> callback);
		void AskForLoadFriendsResolution(Action<UIStatus> callback);
		LoadFriendsStatus GetLastLoadFriendsStatus();
		void ShowCompareProfileWithAlternativeNameHintsUI(string otherUserId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback);
		void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback);
		void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback);
		void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback);
		void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);
		void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);
		void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);
		int LeaderboardMaxResults();
		void SubmitScore(string leaderboardId, long score, Action<bool> successOrFailureCalllback);
		void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> successOrFailureCalllback);
		void RequestPermissions(string[] scopes, Action<SignInStatus> callback);
		bool HasPermissions(string[] scopes);
		ISavedGameClient GetSavedGameClient();
		IEventsClient GetEventsClient();
		IVideoClient GetVideoClient();
		IUserProfile[] GetFriends();
		void SetGravityForPopups(Gravity gravity);
	}
}
