/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.SavedGame
{
	public struct SavedGameMetadataUpdate
	{
		// Fields
		private readonly bool mDescriptionUpdated;
		private readonly string mNewDescription;
		private readonly bool mCoverImageUpdated;
		private readonly byte[] mNewPngCoverImage;
		private readonly TimeSpan? mNewPlayedTime;
	
		// Properties
		public bool IsDescriptionUpdated { get; }
		public string UpdatedDescription { get; }
		public bool IsCoverImageUpdated { get; }
		public byte[] UpdatedPngCoverImage { get; }
		public bool IsPlayedTimeUpdated { get; }
		public TimeSpan? UpdatedPlayedTime { get; }
	
		// Nested types
		public struct Builder
		{
			// Fields
			internal bool mDescriptionUpdated;
			internal string mNewDescription;
			internal bool mCoverImageUpdated;
			internal byte[] mNewPngCoverImage;
			internal TimeSpan? mNewPlayedTime;
	
			// Methods
			public Builder WithUpdatedDescription(string description);
			public Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage);
			public Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime);
			public SavedGameMetadataUpdate Build();
		}
	
		// Constructors
		private SavedGameMetadataUpdate(Builder builder);
	}
}
