/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Cri.Movie;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MovieManager : MonoBehaviour
	{
		// Fields
		private const int SORT_ORDER_BASE = 1;
		private List<string> preinMovieFileList;
		private Dictionary<string, MovieData> _moviePlayerDic;
		private readonly Dictionary<int, TrackParam> _trackParamDict;
		private static MovieManager _instance;
	
		// Properties
		private string RawAssetRootFullPath { get; }
		public static MovieManager instance { get; }
	
		// Nested types
		[Flags]
		public enum MovieCategory
		{
			All = -1,
			CutIn = 1,
			Other = 2
		}
	
		private class MovieData
		{
			// Fields
			public MoviePlayerHandle handle;
			public MovieCategory category;
			public float playSpeed;
	
			// Constructors
			public MovieData();
		}
	
		private class TrackParam
		{
			// Fields
			[CompilerGenerated]
			private float _Volume_k__BackingField;
			[CompilerGenerated]
			private bool _Mute_k__BackingField;
	
			// Properties
			public float Volume { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool Mute { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public TrackParam();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__19_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Awake_b__19_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public GameObject blackLayerObj;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _CreatePlayerWithSkipButton_b__0();
		}
	
		// Constructors
		public MovieManager();
	
		// Methods
		public float GetVolume(int trackNo);
		public void SetVolume(int trackNo, float volume);
		public void SetPlaySpeed(MovieCategory category, float playSpeed);
		public Material GetMovieMaterial(MoviePlayerHandle handle);
		public bool GetMute(int trackNo);
		public void SetMute(int trackNo, bool mute);
		public static bool IsInstanceEmpty();
		public void Awake();
		private MoviePlayerHandle Create(GameObject parentObject, MoviePlayerType playerType = MoviePlayerType.ForUI);
		public MoviePlayerHandle CreatePlayer(string movieFile, GameObject parentObject, MovieCategory category = MovieCategory.Other, MoviePlayerType playerType = MoviePlayerType.ForUI);
		public MoviePlayerHandle CreatePlayerWithSkipButton(string movieFile, MovieCategory category = MovieCategory.Other, GameObject parentObject = null);
		private GameObject CreateBackgroundLayer(MoviePlayerHandle playerHandle);
		public void SetPlayEndType(MoviePlayerHandle playerHandle, PlayEndType playEndType);
		public void SetPlayerParentTransform(MoviePlayerHandle playerHandle, Transform parent, bool worldPositionStays = true);
		public float GetDurationTime(MoviePlayerHandle playerHandle);
		public void SetRaycastTarget(MoviePlayerHandle playerHandle, bool enableRaycastTarget);
		public void Play(MoviePlayerHandle playerHandle, bool isLoop = false, Action playStartCallback = null, Action playEndCallback = null, Action stoppedCallback = null, float playSpeed = 1f);
		private void ApplyVolume(MoviePlayerHandle playerHandle);
		public bool IsPlaying(MoviePlayerHandle playerHandle);
		public bool IsPlaying();
		public void Pause(MoviePlayerHandle playerHandle, bool isPause);
		public bool IsPaused(MoviePlayerHandle playerHandle);
		public void Stop(MoviePlayerHandle playerHandle);
		public void Rewind(MoviePlayerHandle playerHandle, bool isWaitForPlay);
		public void Clear(MoviePlayerHandle playerHandle);
		public void Clear(MovieCategory category);
		public void ClearAll();
		public void AdjustScreenSize(MoviePlayerHandle playerHandle, Vector2 screenSize, bool isPanScan = false);
		[CompilerGenerated]
		private string _Awake_b__19_1(string basePath);
	}
}
