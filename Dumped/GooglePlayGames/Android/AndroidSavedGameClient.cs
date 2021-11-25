using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidSavedGameClient : ISavedGameClient
	{
		private class AndroidConflictResolver : IConflictResolver
		{
			private readonly AndroidJavaObject mSnapshotsClient;

			private readonly AndroidJavaObject mConflict;

			private readonly AndroidSnapshotMetadata mOriginal;

			private readonly AndroidSnapshotMetadata mUnmerged;

			private readonly Action<SavedGameRequestStatus, ISavedGameMetadata> mCompleteCallback;

			private readonly Action mRetryFileOpen;

			private readonly AndroidSavedGameClient mAndroidSavedGameClient;

			internal AndroidConflictResolver(AndroidSavedGameClient androidSavedGameClient, AndroidJavaObject snapshotClient, AndroidJavaObject conflict, AndroidSnapshotMetadata original, AndroidSnapshotMetadata unmerged, Action<SavedGameRequestStatus, ISavedGameMetadata> completeCallback, Action retryOpen)
			{
			}

			public void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData)
			{
			}

			public void ChooseMetadata(ISavedGameMetadata chosenMetadata)
			{
			}
		}

		private static readonly Regex ValidFilenameRegex;

		private AndroidJavaObject mSnapshotsClient;

		private AndroidClient mAndroidClient;

		public AndroidSavedGameClient(AndroidClient androidClient, AndroidJavaObject account)
		{
		}

		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		private void InternalOpen(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback)
		{
		}

		public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback)
		{
		}

		public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
		{
		}

		public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback)
		{
		}

		public void Delete(ISavedGameMetadata metadata)
		{
		}

		private void AddOnFailureListenerWithSignOut(AndroidJavaObject task, Action<AndroidJavaObject> callback)
		{
		}

		private ConflictCallback ToOnGameThread(ConflictCallback conflictCallback)
		{
			return null;
		}

		internal static bool IsValidFilename(string filename)
		{
			return default(bool);
		}

		private static AndroidJavaObject AsMetadataChange(SavedGameMetadataUpdate update)
		{
			return null;
		}

		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}
	}
}
