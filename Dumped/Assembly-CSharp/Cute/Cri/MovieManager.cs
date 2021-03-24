/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CriMana;
using Cute.Cri.Movie;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class MovieManager : MonoBehaviour
	{
		// Fields
		public const string USM_EXTENSION = ".usm";
		public const string STR_SUBFOLDER_MOVIE = "m/";
		private List<string> preinMovieFileNameList;
		private readonly Dictionary<MoviePlayerType, string> moviePlayerPrefs;
		public const string MOVIE_MASK_SHADER_PATH = "Cute/Cri/SofdecPrimeYuvUIMask";
		[SerializeField]
		private GameObject forObj;
		[SerializeField]
		private GameObject forUI;
		private const int PLAYER_MAX_COUNT = 10;
		private Dictionary<MoviePlayerHandle, MoviePlayerBase> playerDic;
		[CompilerGenerated]
		private int _SortOrderBase_k__BackingField;
		[CompilerGenerated]
		private Vector2 _FullScreenDesignSize_k__BackingField;
		[CompilerGenerated]
		private Func<bool> _IsUseAssetBundle_k__BackingField;
		[CompilerGenerated]
		private Func<string, string> _AssetFilePathGetter_k__BackingField;
		[CompilerGenerated]
		private static bool _IsInitialized_k__BackingField;
		private static MovieManager instance;
	
		// Properties
		public int SortOrderBase { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector2 FullScreenDesignSize { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Func<bool> IsUseAssetBundle { [CompilerGenerated] private get; [CompilerGenerated] set; }
		public Func<string, string> AssetFilePathGetter { [CompilerGenerated] private get; [CompilerGenerated] set; }
		public static bool IsInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static MovieManager Instance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public MovieManager __4__this;
			public MoviePlayerHandle moviePlayerHandle;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _CreateMoviePlayer_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _DisableMoviePlayerParentCoroutine_d__38 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MovieManager __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DisableMoviePlayerParentCoroutine_d__38(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MovieManager();
		static MovieManager();
	
		// Methods
		public static bool IsInstanceEmpty();
		private void OnDestroy();
		private void Initialize();
		public MoviePlayerHandle CreateMoviePlayer(MoviePlayerType type, GameObject parentObj = null);
		private bool AvailableCreatePlayer();
		private void DisableMoviePlayerParent();
		[IteratorStateMachine]
		private IEnumerator DisableMoviePlayerParentCoroutine();
		public Transform GetPlayerParentTransform(MoviePlayerHandle playerHandle);
		public void SetPlayerParentTransform(MoviePlayerHandle playerHandle, Transform trans, bool worldPositionStays = true);
		public Transform GetPlayerTransform(MoviePlayerHandle playerHandle);
		public Vector2 GetScreenSize(MoviePlayerHandle playerHandle);
		public void SetScreenSize(MoviePlayerHandle playerHandle, Vector2 screenSize);
		public void AdjustScreenSize(MoviePlayerHandle playerHandle, Vector2 dispRectSize, bool isPanScan = false);
		public void AdjustScreenSize(MoviePlayerHandle playerHandle, float height, bool isPanScan = false);
		public void SetLayer(MoviePlayerHandle playerHandle, int layer);
		private void SetLayer(int layer, Transform trans);
		public string GetSortingLayerName(MoviePlayerHandle playerHandle);
		public void SetIsTargetForReycast(MoviePlayerHandle playerHandle, bool isTargetForReycast);
		public void SetSortingLayerName(MoviePlayerHandle playerHandle, string sortingLayerName);
		public int GetSortingOrder(MoviePlayerHandle playerHandle);
		public void SetSortingOrder(MoviePlayerHandle playerHandle, int sortingOrder);
		public void SetPlayEndType(MoviePlayerHandle playerHandle, PlayEndType playEndType);
		public Material GetMovieMaterial(MoviePlayerHandle playerHandle);
		public void RegisterPreinMovieFileNameList(List<string> movieFileNameList);
		private string GetMovieFilePath(string movieFile);
		public int GetMovieFileLoadCount();
		public void SetPrepareAfterLoading(MoviePlayerHandle playerHandle, bool isPrepareAfterLoading);
		public void Load(MoviePlayerHandle playerHandle, string movieFile, Action loadFinishedCallback = null, string customShaderPath = "");
		public void SetBufferingTime(MoviePlayerHandle playerHandle, float sec);
		public void SetMaxFrameDrop(MoviePlayerHandle playerHandle, CriManaMovieMaterial.MaxFrameDrop frameDrop);
		public void Play(MoviePlayerHandle playerHandle, Action playStartCallback = null, Action playEndCallback = null, Action stoppedCallback = null);
		public void LoadRepeatMovie(MoviePlayerHandle playerHandle, string introMovieFile, string repeatMovieFile, Action loadFinishedCallback = null, string customShaderPath = "");
		public void LoadRepeatMovieH264(MoviePlayerHandle playerHandle, string introMovieFile, string repeatMovieFile, uint introMovieMaxPicSize, uint repeatMovieMaxPicSize, Action loadFinishedCallback = null, string customShaderPath = "");
		public void SkipToRepeatSection(MoviePlayerHandle playerHandle);
		public bool IsPlayingIntroSection(MoviePlayerHandle playerHandle);
		public void SetDestroyedCallback(MoviePlayerHandle playerHandle, Action destroyedCallback);
		public void Stop(MoviePlayerHandle playerHandle);
		public void StopAll();
		public void Pause(MoviePlayerHandle playerHandle, bool isPause);
		public void PauseAll(bool isPause);
		public void SetLoop(MoviePlayerHandle playerHandle, bool isLoop);
		public void SetLoopAll(bool isLoop);
		public void SetPlaySpeed(MoviePlayerHandle playerHandle, float speed);
		public void SetVolume(MoviePlayerHandle playerHandle, float volume);
		public void SetVolumeAll(float volume);
		public void SetSubAudioVolume(MoviePlayerHandle playerHandle, float volume);
		public void SetSubAudioVolumeAll(float volume);
		public void SetExtraAudioVolume(MoviePlayerHandle playerHandle, float volume);
		public void SetExtraAudioVolumeAll(float volume);
		public void SetAllVolume(float volume);
		public uint GetSeekPositionFrame(MoviePlayerHandle playerHandle);
		public float GetSeekPositionTime(MoviePlayerHandle playerHandle);
		public uint GetDurationFrame(MoviePlayerHandle playerHandle);
		public float GetDurationTime(MoviePlayerHandle playerHandle);
		public float GetCurrentSeekRate(MoviePlayerHandle playerHandle);
		public void SeekByFrame(MoviePlayerHandle playerHandle, int seekFrame, bool isWaitForPlay = false);
		public void SeekByTime(MoviePlayerHandle playerHandle, float seekTime, bool isWaitForPlay = false);
		public bool IsStopAll();
		public bool IsReady(MoviePlayerHandle playerHandle);
		public bool IsError(MoviePlayerHandle playerHandle);
		public bool IsPlaying(MoviePlayerHandle playerHandle);
		public bool IsPlaying();
		public void Clear(MoviePlayerHandle playerHandle);
		public void ClearAll();
		public bool IsPaused(MoviePlayerHandle playerHandle);
		public bool IsStopped(MoviePlayerHandle playerHandle);
		public bool IsExistPlayer(MoviePlayerHandle playerHandle);
		public MovieInfo GetMovieInfo(MoviePlayerHandle playerHandle);
		public FrameInfo GetFrameInfo(MoviePlayerHandle playerHandle);
		public bool IsH264Supported();
	}
}
