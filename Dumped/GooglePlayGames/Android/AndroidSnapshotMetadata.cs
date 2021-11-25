using System;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidSnapshotMetadata : ISavedGameMetadata
	{
		private AndroidJavaObject mJavaSnapshot;

		private AndroidJavaObject mJavaMetadata;

		private AndroidJavaObject mJavaContents;

		public AndroidJavaObject JavaSnapshot => null;

		public AndroidJavaObject JavaMetadata => null;

		public AndroidJavaObject JavaContents => null;

		public bool IsOpen => default(bool);

		public string Filename => null;

		public string Description => null;

		public string CoverImageURL => null;

		public TimeSpan TotalTimePlayed => default(TimeSpan);

		public DateTime LastModifiedTimestamp => default(DateTime);

		public AndroidSnapshotMetadata(AndroidJavaObject javaSnapshot)
		{
		}

		public AndroidSnapshotMetadata(AndroidJavaObject javaMetadata, AndroidJavaObject javaContents)
		{
		}
	}
}
