using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri;
using Cute.Cri.Movie;
using UnityEngine;

namespace Gluon
{
	public class MovieManager : MonoBehaviour
	{
		[Flags]
		public enum MovieCategory
		{
			CutIn = 0x1,
			Other = 0x2,
			All = -1
		}

		private class MovieData
		{
			public MoviePlayerHandle handle;

			public MovieCategory category;

			public float playSpeed;
		}

		private class TrackParam
		{
			public float Volume
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool Mute
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
		}

		private const int SORT_ORDER_BASE = 1;

		private List<string> preinMovieFileList;

		private Dictionary<string, MovieData> _moviePlayerDic;

		private readonly Dictionary<int, TrackParam> _trackParamDict;

		private static MovieManager _instance;

		private string RawAssetRootFullPath => null;

		public static MovieManager instance => null;

		public float GetVolume(int trackNo)
		{
			return default(float);
		}

		public void SetVolume(int trackNo, float volume)
		{
		}

		public void SetPlaySpeed(MovieCategory category, float playSpeed)
		{
		}

		public Material GetMovieMaterial(MoviePlayerHandle handle)
		{
			return null;
		}

		public bool GetMute(int trackNo)
		{
			return default(bool);
		}

		public void SetMute(int trackNo, bool mute)
		{
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		public void Awake()
		{
		}

		private MoviePlayerHandle Create(GameObject parentObject, MoviePlayerType playerType = MoviePlayerType.ForUI)
		{
			return default(MoviePlayerHandle);
		}

		public MoviePlayerHandle CreatePlayer(string movieFile, GameObject parentObject, MovieCategory category = MovieCategory.Other, MoviePlayerType playerType = MoviePlayerType.ForUI)
		{
			return default(MoviePlayerHandle);
		}

		public MoviePlayerHandle CreatePlayerWithSkipButton(string movieFile, MovieCategory category = MovieCategory.Other, [Optional] GameObject parentObject)
		{
			return default(MoviePlayerHandle);
		}

		private GameObject CreateBackgroundLayer(MoviePlayerHandle playerHandle)
		{
			return null;
		}

		public void SetPlayEndType(MoviePlayerHandle playerHandle, PlayEndType playEndType)
		{
		}

		public void SetPlayerParentTransform(MoviePlayerHandle playerHandle, Transform parent, bool worldPositionStays = true)
		{
		}

		public float GetDurationTime(MoviePlayerHandle playerHandle)
		{
			return default(float);
		}

		public void SetRaycastTarget(MoviePlayerHandle playerHandle, bool enableRaycastTarget)
		{
		}

		public void Play(MoviePlayerHandle playerHandle, bool isLoop = false, [Optional] Action playStartCallback, [Optional] Action playEndCallback, [Optional] Action stoppedCallback, float playSpeed = 1f)
		{
		}

		private void ApplyVolume(MoviePlayerHandle playerHandle)
		{
		}

		public bool IsPlaying(MoviePlayerHandle playerHandle)
		{
			return default(bool);
		}

		public bool IsPlaying()
		{
			return default(bool);
		}

		public void Pause(MoviePlayerHandle playerHandle, bool isPause)
		{
		}

		public bool IsPaused(MoviePlayerHandle playerHandle)
		{
			return default(bool);
		}

		public void Stop(MoviePlayerHandle playerHandle)
		{
		}

		public void Rewind(MoviePlayerHandle playerHandle, bool isWaitForPlay)
		{
		}

		public void Clear(MoviePlayerHandle playerHandle)
		{
		}

		public void Clear(MovieCategory category)
		{
		}

		public void ClearAll()
		{
		}

		public void AdjustScreenSize(MoviePlayerHandle playerHandle, Vector2 screenSize, bool isPanScan = false)
		{
		}
	}
}
