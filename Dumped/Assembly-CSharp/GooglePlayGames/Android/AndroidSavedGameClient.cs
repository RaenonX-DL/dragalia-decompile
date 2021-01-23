/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Android
{
	internal class AndroidSavedGameClient : ISavedGameClient
	{
		// Fields
		private static readonly Regex ValidFilenameRegex;
		private AndroidJavaObject mSnapshotsClient;
		private AndroidClient mAndroidClient;
	
		// Nested types
		private class AndroidConflictResolver : IConflictResolver
		{
			// Fields
			private readonly AndroidJavaObject mSnapshotsClient;
			private readonly AndroidJavaObject mConflict;
			private readonly AndroidSnapshotMetadata mOriginal;
			private readonly AndroidSnapshotMetadata mUnmerged;
			private readonly Action<SavedGameRequestStatus, ISavedGameMetadata> mCompleteCallback;
			private readonly Action mRetryFileOpen;
			private readonly AndroidSavedGameClient mAndroidSavedGameClient;
	
			// Constructors
			internal AndroidConflictResolver(AndroidSavedGameClient androidSavedGameClient, AndroidJavaObject snapshotClient, AndroidJavaObject conflict, AndroidSnapshotMetadata original, AndroidSnapshotMetadata unmerged, Action<SavedGameRequestStatus, ISavedGameMetadata> completeCallback, Action retryOpen);
	
			// Methods
			public void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
			public void ChooseMetadata(ISavedGameMetadata chosenMetadata);
			[CompilerGenerated]
			private void _ResolveConflict_b__8_0(AndroidJavaObject dataOrConflict);
			[CompilerGenerated]
			private void _ResolveConflict_b__8_1(AndroidJavaObject exception);
			[CompilerGenerated]
			private void _ChooseMetadata_b__9_0(AndroidJavaObject dataOrConflict);
			[CompilerGenerated]
			private void _ChooseMetadata_b__9_1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public ConflictResolutionStrategy resolutionStrategy;
			public Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _OpenWithAutomaticConflictResolution_b__0(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public AndroidSavedGameClient __4__this;
			public Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback;
			public string filename;
			public DataSource source;
			public ConflictResolutionStrategy resolutionStrategy;
			public bool prefetchDataOnConflict;
			public ConflictCallback conflictCallback;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _InternalOpen_b__0(AndroidJavaObject dataOrConflict);
			internal void _InternalOpen_b__2();
			internal void _InternalOpen_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public Action<SavedGameRequestStatus, ISavedGameMetadata> callback;
			public AndroidSavedGameClient __4__this;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _CommitUpdate_b__0(AndroidJavaObject snapshotMetadata);
			internal void _CommitUpdate_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback;
			public AndroidSavedGameClient __4__this;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _FetchAllSavedGames_b__0(AndroidJavaObject annotatedData);
			internal void _FetchAllSavedGames_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public AndroidSavedGameClient __4__this;
			public Action<AndroidJavaObject> callback;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _AddOnFailureListenerWithSignOut_b__0(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public ConflictCallback conflictCallback;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _ToOnGameThread_b__0(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_1
		{
			// Fields
			public IConflictResolver resolver;
			public ISavedGameMetadata original;
			public byte[] originalData;
			public ISavedGameMetadata unmerged;
			public byte[] unmergedData;
			public __c__DisplayClass13_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass13_1();
	
			// Methods
			internal void _ToOnGameThread_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0<T1, T2>
		{
			// Fields
			public Action<T1, T2> toConvert;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _ToOnGameThread_b__0(T1 val1, T2 val2);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1<T1, T2>
		{
			// Fields
			public T1 val1;
			public T2 val2;
			public __c__DisplayClass17_0<T1, T2> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _ToOnGameThread_b__1();
		}
	
		// Constructors
		public AndroidSavedGameClient(AndroidClient androidClient, AndroidJavaObject account);
		static AndroidSavedGameClient();
	
		// Methods
		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback);
		public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback);
		private void InternalOpen(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback);
		public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback);
		public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback);
		public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);
		public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback);
		public void Delete(ISavedGameMetadata metadata);
		private void AddOnFailureListenerWithSignOut(AndroidJavaObject task, Action<AndroidJavaObject> callback);
		private ConflictCallback ToOnGameThread(ConflictCallback conflictCallback);
		internal static bool IsValidFilename(string filename);
		private static AndroidJavaObject AsMetadataChange(SavedGameMetadataUpdate update);
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert);
	}
}
