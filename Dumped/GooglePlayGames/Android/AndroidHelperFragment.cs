using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidHelperFragment
	{
		private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";

		public static AndroidJavaObject GetActivity()
		{
			return null;
		}

		public static AndroidJavaObject GetDefaultPopupView()
		{
			return null;
		}

		public static void ShowAchievementsUI(Action<UIStatus> cb)
		{
		}

		public static void ShowCaptureOverlayUI()
		{
		}

		public static void ShowAllLeaderboardsUI(Action<UIStatus> cb)
		{
		}

		public static void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan timeSpan, Action<UIStatus> cb)
		{
		}

		public static void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> cb)
		{
		}

		public static void IsResolutionRequired(AndroidJavaObject friendsSharingConsentException, Action<bool> cb)
		{
		}

		public static void AskForLoadFriendsResolution(AndroidJavaObject friendsSharingConsentException, Action<UIStatus> cb)
		{
		}

		public static void ShowSelectSnapshotUI(bool showCreateSaveUI, bool showDeleteSaveUI, int maxDisplayedSavedGames, string uiTitle, Action<SelectUIStatus, ISavedGameMetadata> cb)
		{
		}
	}
}
