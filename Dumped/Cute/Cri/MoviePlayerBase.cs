using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriMana;
using Cute.Cri.Movie;
using UnityEngine;

namespace Cute.Cri
{
	public abstract class MoviePlayerBase : MonoBehaviour
	{
		private struct SeekControlData
		{
			public bool IsSeekByTime
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float SeekTime
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int SeekFrame
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool IsWaitForPlay
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool IsSetSeekPosition
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public void SetSeekData(int seekFrame, bool isWaitForPlay)
			{
			}

			public void SetSeekData(float seekTime, bool isWaitForPlay)
			{
			}
		}

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

		[SerializeField]
		protected abstract CriManaMovieMaterial MovieController { get; }

		protected Player Player => null;

		public Material MovieMaterial => null;

		public MovieInfo MovieInfo => null;

		public FrameInfo FrameInfo => null;

		public bool IsReady => default(bool);

		public bool IsPlaying => default(bool);

		public bool IsStopped => default(bool);

		public bool IsError => default(bool);

		public bool IsPaused => default(bool);

		public bool IsPrepareAfterLoading
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Loop
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public abstract string SortingLayerName { get; set; }

		public abstract int SortingOrder { get; set; }

		public abstract bool IsTargetForReycast { get; set; }

		public abstract Vector2 ScreenSize { get; set; }

		public PlayEndType PlayEndType
		{
			get
			{
				return default(PlayEndType);
			}
			set
			{
			}
		}

		public Transform Transform => null;

		public int FileLoadCount => default(int);

		private void Awake()
		{
		}

		private void Reset()
		{
		}

		private void SetMoviePath(string moviePath, string repeatMoviePath = "")
		{
		}

		public void SetMovieCustomShader(string customShaderPath)
		{
		}

		public void Load(string moviePath, [Optional] Action loadFinishedCallback)
		{
		}

		public void Play([Optional] Action playStartCallback, [Optional] Action playEndCallback, [Optional] Action stoppedCallback)
		{
		}

		public void SeekByFrame(int seekFrame, bool isWaitForPlay)
		{
		}

		public void SeekByTime(float seekTime, bool isWaitForPlay)
		{
		}

		private void StartSeek()
		{
		}

		public void Update()
		{
		}

		private void UpdateLoadProcess()
		{
		}

		private void UpdatePlayProcess()
		{
		}

		private void UpdateSeekProcess()
		{
		}

		public void LoadRepeatMovie(string introMoviePath, string repeatMoviePath, [Optional] Action loadFinishedCallback)
		{
		}

		public void LoadRepeatMovieH264(string introMoviePath, string repeatMoviePath, uint introMovieMaxPicSize, uint repeatMovieMaxPictSize, [Optional] Action loadFinishedCallback)
		{
		}

		public void SkipToRepeatSection()
		{
		}

		public bool IsPlayingIntroSection()
		{
			return default(bool);
		}

		public void Stop()
		{
		}

		public void Pause(bool isPause)
		{
		}

		public void SetPlaySpeed(float speed)
		{
		}

		public void SetBufferingTime(float sec)
		{
		}

		public void SetMaxFrameDrop(CriManaMovieMaterial.MaxFrameDrop frameDrop)
		{
		}

		public void SetMainAudioTrackVolume(float volume)
		{
		}

		public void SetSubAudioTrackVolume(float volume)
		{
		}

		public void SetExtraAudioTrackVolume(float volume)
		{
		}

		public void SetAllAudioTrackVolume(float volume)
		{
		}

		private void InitMultiTrackAudio()
		{
		}

		private void InitScreenSize()
		{
		}

		public void SetAdjustScreenSize(Vector2 dispRectSize, bool isPanScan)
		{
		}

		public void SetAdjustScreenSize(float height, bool isPanScan)
		{
		}

		protected abstract void AdjustScreenSize(Vector2 dispRectSize, bool isPanScan);

		public uint GetSeekPositionFrame()
		{
			return default(uint);
		}

		public float GetSeekPositionTime()
		{
			return default(float);
		}

		public uint GetDurationFrame()
		{
			return default(uint);
		}

		public float GetDurationTime()
		{
			return default(float);
		}

		public float GetCurrentSeekRate()
		{
			return default(float);
		}

		public void SetDestroyedCallback(Action destroyedCallback)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
