/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Android
{
	internal class AndroidHelperFragment
	{
		// Fields
		private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public Action<UIStatus> cb;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _ShowAchievementsUI_b__0(int uiCode);
			internal void _ShowAchievementsUI_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public Action<UIStatus> cb;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _ShowAllLeaderboardsUI_b__0(int uiCode);
			internal void _ShowAllLeaderboardsUI_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public Action<UIStatus> cb;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _ShowLeaderboardUI_b__0(int uiCode);
			internal void _ShowLeaderboardUI_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public Action<UIStatus> cb;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _ShowCompareProfileWithAlternativeNameHintsUI_b__0(int uiCode);
			internal void _ShowCompareProfileWithAlternativeNameHintsUI_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public Action<UIStatus> cb;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _AskForLoadFriendsResolution_b__0(int uiCode);
			internal void _AskForLoadFriendsResolution_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public Action<SelectUIStatus, ISavedGameMetadata> cb;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _ShowSelectSnapshotUI_b__0(AndroidJavaObject result);
			internal void _ShowSelectSnapshotUI_b__1(AndroidJavaObject exception);
		}
	
		// Constructors
		public AndroidHelperFragment();
	
		// Methods
		public static AndroidJavaObject GetActivity();
		public static AndroidJavaObject GetDefaultPopupView();
		public static void ShowAchievementsUI(Action<UIStatus> cb);
		public static void ShowCaptureOverlayUI();
		public static void ShowAllLeaderboardsUI(Action<UIStatus> cb);
		public static void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan timeSpan, Action<UIStatus> cb);
		public static void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> cb);
		public static void IsResolutionRequired(AndroidJavaObject friendsSharingConsentException, Action<bool> cb);
		public static void AskForLoadFriendsResolution(AndroidJavaObject friendsSharingConsentException, Action<UIStatus> cb);
		public static void ShowSelectSnapshotUI(bool showCreateSaveUI, bool showDeleteSaveUI, int maxDisplayedSavedGames, string uiTitle, Action<SelectUIStatus, ISavedGameMetadata> cb);
	}
}
