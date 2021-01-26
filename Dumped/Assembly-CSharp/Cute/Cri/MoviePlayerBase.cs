/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CriMana;
using Cute.Cri.Movie;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public abstract class MoviePlayerBase : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private bool _IsPrepareAfterLoading_k__BackingField;
		private bool isPauseStandBy;
		private bool isLoop;
		private Action adjustScreenSize;
		private PlayEndType playEndType;
		private string moviePath;
		private string repeatMoviePath;
		private bool isLoadOn;
		private bool isPlayOn;
		private bool isSeekOn;
		private Action loadFinishedCallback;
		private Action playStartCallback;
		private Action playEndCallback;
		private Action stoppedCallback;
		private Action destroyedCallback;
		private bool isSkippedIntroSection;
		private bool isStopForSkippedIntro;
		private SeekControlData seekControlData;
	
		// Properties
		[SerializeField]
		protected abstract CriManaMovieMaterial MovieController { get; }
		protected Player Player { get; }
		public Material MovieMaterial { get; }
		public MovieInfo MovieInfo { get; }
		public FrameInfo FrameInfo { get; }
		public bool IsReady { get; }
		public bool IsPlaying { get; }
		public bool IsStopped { get; }
		public bool IsError { get; }
		public bool IsPaused { get; }
		public bool IsPrepareAfterLoading { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool Loop { get; set; }
		public abstract string SortingLayerName { get; set; }
		public abstract int SortingOrder { get; set; }
		public abstract bool IsTargetForReycast { get; set; }
		public abstract Vector2 ScreenSize { get; set; }
		public PlayEndType PlayEndType { get; set; }
		public Transform Transform { get; }
		public int FileLoadCount { get; }
	
		// Nested types
		private struct SeekControlData
		{
			// Fields
			[CompilerGenerated]
			private bool _IsSeekByTime_k__BackingField;
			[CompilerGenerated]
			private float _SeekTime_k__BackingField;
			[CompilerGenerated]
			private int _SeekFrame_k__BackingField;
			[CompilerGenerated]
			private bool _IsWaitForPlay_k__BackingField;
			[CompilerGenerated]
			private bool _IsSetSeekPosition_k__BackingField;
	
			// Properties
			public bool IsSeekByTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float SeekTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int SeekFrame { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool IsWaitForPlay { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool IsSetSeekPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Methods
			public void SetSeekData(int seekFrame, bool isWaitForPlay);
			public void SetSeekData(float seekTime, bool isWaitForPlay);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0
		{
			// Fields
			public string customShaderPath;
	
			// Constructors
			public __c__DisplayClass67_0();
	
			// Methods
			internal Shader _SetMovieCustomShader_b__0(MovieInfo movieInfo, bool additiveMode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_0
		{
			// Fields
			public MoviePlayerBase __4__this;
			public Vector2 dispRectSize;
			public bool isPanScan;
	
			// Constructors
			public __c__DisplayClass92_0();
	
			// Methods
			internal void _SetAdjustScreenSize_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_0
		{
			// Fields
			public MoviePlayerBase __4__this;
			public float height;
			public bool isPanScan;
	
			// Constructors
			public __c__DisplayClass93_0();
	
			// Methods
			internal void _SetAdjustScreenSize_b__0();
		}
	
		// Constructors
		protected MoviePlayerBase();
	
		// Methods
		private void Awake();
		private void Reset();
		private void SetMoviePath(string moviePath, string repeatMoviePath = "");
		public void SetMovieCustomShader(string customShaderPath);
		public void Load(string moviePath, Action loadFinishedCallback = null);
		public void Play(Action playStartCallback = null, Action playEndCallback = null, Action stoppedCallback = null);
		public void SeekByFrame(int seekFrame, bool isWaitForPlay);
		public void SeekByTime(float seekTime, bool isWaitForPlay);
		private void StartSeek();
		public void Update();
		private void UpdateLoadProcess();
		private void UpdatePlayProcess();
		private void UpdateSeekProcess();
		public void LoadRepeatMovie(string introMoviePath, string repeatMoviePath, Action loadFinishedCallback = null);
		public void LoadRepeatMovieH264(string introMoviePath, string repeatMoviePath, uint introMovieMaxPicSize, uint repeatMovieMaxPictSize, Action loadFinishedCallback = null);
		public void SkipToRepeatSection();
		public bool IsPlayingIntroSection();
		public void Stop();
		public void Pause(bool isPause);
		public void SetPlaySpeed(float speed);
		public void SetBufferingTime(float sec);
		public void SetMaxFrameDrop(CriManaMovieMaterial.MaxFrameDrop frameDrop);
		public void SetMainAudioTrackVolume(float volume);
		public void SetSubAudioTrackVolume(float volume);
		public void SetExtraAudioTrackVolume(float volume);
		public void SetAllAudioTrackVolume(float volume);
		private void InitMultiTrackAudio();
		private void InitScreenSize();
		public void SetAdjustScreenSize(Vector2 dispRectSize, bool isPanScan);
		public void SetAdjustScreenSize(float height, bool isPanScan);
		protected abstract void AdjustScreenSize(Vector2 dispRectSize, bool isPanScan);
		public uint GetSeekPositionFrame();
		public float GetSeekPositionTime();
		public uint GetDurationFrame();
		public float GetDurationTime();
		public float GetCurrentSeekRate();
		public void SetDestroyedCallback(Action destroyedCallback);
		private void OnDestroy();
		[CompilerGenerated]
		private void _Play_b__69_0();
		[CompilerGenerated]
		private void _InitScreenSize_b__91_0();
	}
}
