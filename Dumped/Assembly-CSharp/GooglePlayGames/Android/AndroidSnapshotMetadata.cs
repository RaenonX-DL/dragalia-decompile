/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Android
{
	internal class AndroidSnapshotMetadata : ISavedGameMetadata
	{
		// Fields
		private AndroidJavaObject mJavaSnapshot;
		private AndroidJavaObject mJavaMetadata;
		private AndroidJavaObject mJavaContents;
	
		// Properties
		public AndroidJavaObject JavaSnapshot { get; }
		public AndroidJavaObject JavaMetadata { get; }
		public AndroidJavaObject JavaContents { get; }
		public bool IsOpen { get; }
		public string Filename { get; }
		public string Description { get; }
		public string CoverImageURL { get; }
		public TimeSpan TotalTimePlayed { get; }
		public DateTime LastModifiedTimestamp { get; }
	
		// Constructors
		public AndroidSnapshotMetadata(AndroidJavaObject javaSnapshot);
		public AndroidSnapshotMetadata(AndroidJavaObject javaMetadata, AndroidJavaObject javaContents);
	}
}
