using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriMana;
using Cute.Cri.Movie;
using UnityEngine;

namespace Cute.Cri
{
	public class MovieManager : MonoBehaviour
	{
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

		private static MovieManager instance;

		public int SortOrderBase
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector2 FullScreenDesignSize
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Func<bool> IsUseAssetBundle
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Func<string, string> AssetFilePathGetter
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool IsInitialized
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

		public static MovieManager Instance => null;

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		private void OnDestroy()
		{
		}

		private void Initialize()
		{
		}

		public MoviePlayerHandle CreateMoviePlayer(MoviePlayerType type, [Optional] GameObject parentObj)
		{
			return default(MoviePlayerHandle);
		}

		private bool AvailableCreatePlayer()
		{
			return default(bool);
		}

		private void DisableMoviePlayerParent()
		{
		}

		private IEnumerator DisableMoviePlayerParentCoroutine()
		{
			return null;
		}

		public Transform GetPlayerParentTransform(MoviePlayerHandle playerHandle)
		{
			return null;
		}

		public void SetPlayerParentTransform(MoviePlayerHandle playerHandle, Transform trans, bool worldPositionStays = true)
		{
		}

		public Transform GetPlayerTransform(MoviePlayerHandle playerHandle)
		{
			return null;
		}

		public Vector2 GetScreenSize(MoviePlayerHandle playerHandle)
		{
			return default(Vector2);
		}

		public void SetScreenSize(MoviePlayerHandle playerHandle, Vector2 screenSize)
		{
		}

		public void AdjustScreenSize(MoviePlayerHandle playerHandle, Vector2 dispRectSize, bool isPanScan = false)
		{
		}

		public void AdjustScreenSize(MoviePlayerHandle playerHandle, float height, bool isPanScan = false)
		{
		}

		public void SetLayer(MoviePlayerHandle playerHandle, int layer)
		{
		}

		private void SetLayer(int layer, Transform trans)
		{
		}

		public string GetSortingLayerName(MoviePlayerHandle playerHandle)
		{
			return null;
		}

		public void SetIsTargetForReycast(MoviePlayerHandle playerHandle, bool isTargetForReycast)
		{
		}

		public void SetSortingLayerName(MoviePlayerHandle playerHandle, string sortingLayerName)
		{
		}

		public int GetSortingOrder(MoviePlayerHandle playerHandle)
		{
			return default(int);
		}

		public void SetSortingOrder(MoviePlayerHandle playerHandle, int sortingOrder)
		{
		}

		public void SetPlayEndType(MoviePlayerHandle playerHandle, PlayEndType playEndType)
		{
		}

		public Material GetMovieMaterial(MoviePlayerHandle playerHandle)
		{
			return null;
		}

		public void RegisterPreinMovieFileNameList(List<string> movieFileNameList)
		{
		}

		private string GetMovieFilePath(string movieFile)
		{
			return null;
		}

		public int GetMovieFileLoadCount()
		{
			return default(int);
		}

		public void SetPrepareAfterLoading(MoviePlayerHandle playerHandle, bool isPrepareAfterLoading)
		{
		}

		public void Load(MoviePlayerHandle playerHandle, string movieFile, [Optional] Action loadFinishedCallback, string customShaderPath = "")
		{
		}

		public void SetBufferingTime(MoviePlayerHandle playerHandle, float sec)
		{
		}

		public void SetMaxFrameDrop(MoviePlayerHandle playerHandle, CriManaMovieMaterial.MaxFrameDrop frameDrop)
		{
		}

		public void Play(MoviePlayerHandle playerHandle, [Optional] Action playStartCallback, [Optional] Action playEndCallback, [Optional] Action stoppedCallback)
		{
		}

		public void LoadRepeatMovie(MoviePlayerHandle playerHandle, string introMovieFile, string repeatMovieFile, [Optional] Action loadFinishedCallback, string customShaderPath = "")
		{
		}

		public void LoadRepeatMovieH264(MoviePlayerHandle playerHandle, string introMovieFile, string repeatMovieFile, uint introMovieMaxPicSize, uint repeatMovieMaxPicSize, [Optional] Action loadFinishedCallback, string customShaderPath = "")
		{
		}

		public void SkipToRepeatSection(MoviePlayerHandle playerHandle)
		{
		}

		public bool IsPlayingIntroSection(MoviePlayerHandle playerHandle)
		{
			return default(bool);
		}

		public void SetDestroyedCallback(MoviePlayerHandle playerHandle, Action destroyedCallback)
		{
		}

		public void Stop(MoviePlayerHandle playerHandle)
		{
		}

		public void StopAll()
		{
		}

		public void Pause(MoviePlayerHandle playerHandle, bool isPause)
		{
		}

		public void PauseAll(bool isPause)
		{
		}

		public void SetLoop(MoviePlayerHandle playerHandle, bool isLoop)
		{
		}

		public void SetLoopAll(bool isLoop)
		{
		}

		public void SetPlaySpeed(MoviePlayerHandle playerHandle, float speed)
		{
		}

		public void SetVolume(MoviePlayerHandle playerHandle, float volume)
		{
		}

		public void SetVolumeAll(float volume)
		{
		}

		public void SetSubAudioVolume(MoviePlayerHandle playerHandle, float volume)
		{
		}

		public void SetSubAudioVolumeAll(float volume)
		{
		}

		public void SetExtraAudioVolume(MoviePlayerHandle playerHandle, float volume)
		{
		}

		public void SetExtraAudioVolumeAll(float volume)
		{
		}

		public void SetAllVolume(float volume)
		{
		}

		public uint GetSeekPositionFrame(MoviePlayerHandle playerHandle)
		{
			return default(uint);
		}

		public float GetSeekPositionTime(MoviePlayerHandle playerHandle)
		{
			return default(float);
		}

		public uint GetDurationFrame(MoviePlayerHandle playerHandle)
		{
			return default(uint);
		}

		public float GetDurationTime(MoviePlayerHandle playerHandle)
		{
			return default(float);
		}

		public float GetCurrentSeekRate(MoviePlayerHandle playerHandle)
		{
			return default(float);
		}

		public void SeekByFrame(MoviePlayerHandle playerHandle, int seekFrame, bool isWaitForPlay = false)
		{
		}

		public void SeekByTime(MoviePlayerHandle playerHandle, float seekTime, bool isWaitForPlay = false)
		{
		}

		public bool IsStopAll()
		{
			return default(bool);
		}

		public bool IsReady(MoviePlayerHandle playerHandle)
		{
			return default(bool);
		}

		public bool IsError(MoviePlayerHandle playerHandle)
		{
			return default(bool);
		}

		public bool IsPlaying(MoviePlayerHandle playerHandle)
		{
			return default(bool);
		}

		public bool IsPlaying()
		{
			return default(bool);
		}

		public void Clear(MoviePlayerHandle playerHandle)
		{
		}

		public void ClearAll()
		{
		}

		public bool IsPaused(MoviePlayerHandle playerHandle)
		{
			return default(bool);
		}

		public bool IsStopped(MoviePlayerHandle playerHandle)
		{
			return default(bool);
		}

		public bool IsExistPlayer(MoviePlayerHandle playerHandle)
		{
			return default(bool);
		}

		public MovieInfo GetMovieInfo(MoviePlayerHandle playerHandle)
		{
			return null;
		}

		public FrameInfo GetFrameInfo(MoviePlayerHandle playerHandle)
		{
			return null;
		}

		public bool IsH264Supported()
		{
			return default(bool);
		}
	}
}
