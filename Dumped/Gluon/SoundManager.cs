using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriWare;
using Cute.Cri;
using Cute.Cri.Audio;
using UnityEngine;

namespace Gluon
{
	public class SoundManager : SingletonMonoBehaviour<SoundManager>
	{
		public struct FadeParams
		{
			public float FadeOutTime
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

			public float FadeInTime
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

			public float OffsetTime
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

			public static FadeParams DisableFade => default(FadeParams);
		}

		public class CriAtomCueSheetCompare : IEqualityComparer<CriAtomCueSheet>
		{
			public bool Equals(CriAtomCueSheet cueSheet1, CriAtomCueSheet cueSheet2)
			{
				return default(bool);
			}

			public int GetHashCode(CriAtomCueSheet cueSheet)
			{
				return default(int);
			}
		}

		public delegate void ReplaceCueName(ref string cueName);

		private static class PreferFirstDecision
		{
			private static readonly List<string> preferFirstList;

			public static void SetCuteAudioPriority(SoundGroup group, string cueName, int prioLevel, ref PlayParameters param)
			{
			}
		}

		private struct CrossFadeParam
		{
			public float fadeOutTime;

			public float fadeInTime;

			public float offsetTime;

			public static CrossFadeParam GetCrossFadeParam(string cueName, AudioPlayback lastBgmPlayback)
			{
				return default(CrossFadeParam);
			}
		}

		public struct VoiceSubFolderDecision
		{
			private const string subFolderInGame = "InGame";

			private const string subFolderOutGame = "OutGame";

			private const string subFolderStory = "Story";

			private const string subFolderSummonTop = "SummonTop";

			private const string subFolderOther = "Other";

			private static readonly string[,] table;

			public static string GetSubFolderName(string cueSheetName)
			{
				return null;
			}
		}

		private struct BgmStopInfo
		{
			public long StopTime
			{
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool IsPositionResumeGuard
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

		private static readonly List<string> preinCueSheetNameList;

		private const float SOUND_GROUP_VOLUME_FACTOR = 1.5f;

		private const int BGM_MAX_SOURCE_COUNT = 2;

		private const int SE_MAX_SOURCE_COUNT = 32;

		private const int VOICE_MAX_SOURCE_COUNT = 15;

		private const int BGM_CUESHEET_COUNT_MAX = 3;

		private static readonly Dictionary<SoundGroup, string[]> _atomExAsrBusDict;

		private Dictionary<CriAtomCueSheet, int> _cueSheetDict;

		private List<string> _removingCueSheetNameList;

		private List<string> _bgmCueSheetList;

		private List<string> _stackGroupNameList;

		private bool _isSoloPlay;

		private Dictionary<SoundGroup, List<string>> _soloPlayCueNameDict;

		private InteractiveBgmController _interactiveBgmController;

		public ReplaceCueName cueNameReplacer;

		private readonly List<PrioritySetting> sePriorityList;

		private readonly List<PrioritySetting> voicePriorityList;

		private const float GimmickSeDistanceLimit = 50f;

		private const float GimmickSeInteriorDistance = 16f;

		private const float AngleRange = 30f;

		private readonly List<PrioritySetting> sePriorityList_Apr2019;

		private readonly List<PrioritySetting> voicePriorityList_Apr2019;

		private readonly Dictionary<string, int> prioLevelList;

		private Dictionary<string, BgmStopInfo> bgmStopInfoDict;

		public static bool hasInstance => default(bool);

		public AudioPlayback LastBgmPlayback
		{
			[CompilerGenerated]
			get
			{
				return default(AudioPlayback);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private string RawAssetRootFullPath => null;

		public static string LocalizedSoundParentPath => null;

		public bool IsInitialized
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

		public bool MuteVocal
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public VocalTrack VocalTrack
		{
			get
			{
				return default(VocalTrack);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private string GetSoundFilePath(string basePath)
		{
			return null;
		}

		public void LoadGroup()
		{
		}

		public void LoadGroup(string cueSheetName)
		{
		}

		public void ReleaseGroup(string cueSheetName, float waitTime = 0.5f)
		{
		}

		private IEnumerator RemoveCueSheetCoroutine(string cueSheetName, float waitTime)
		{
			return null;
		}

		public void ReleaseGroup(SoundGroup group, float waitTime = 0.5f)
		{
		}

		private IEnumerator RemoveCueSheetCoroutine(SoundGroup group, float waitTime)
		{
			return null;
		}

		public int GetBgmCueSheetCount()
		{
			return default(int);
		}

		public bool IsLoadedGroup(string cueSheetName)
		{
			return default(bool);
		}

		private CriAtomCueSheet GetLoadedCueSheet(string cueSheetName)
		{
			return null;
		}

		private string GetCueSheetName(string cueName)
		{
			return null;
		}

		public bool IsLoadedCueSheet(string cueName)
		{
			return default(bool);
		}

		public void RegisterLoadGroupName(string groupName)
		{
		}

		public void ClearLoadGroupName()
		{
		}

		public static string ConvertSoundGroupName(string soundName)
		{
			return null;
		}

		public static SoundGroup CueSheetNameToCategory(string cueSheetName)
		{
			return default(SoundGroup);
		}

		private SoundGroup CueNameToCategory(string cueSheetName)
		{
			return default(SoundGroup);
		}

		public AudioPlayback Play(string cueName, float volume = 1f, bool isLoop = false, int prioLevel = int.MaxValue, [Optional] Action playEndCallback, [Optional] FadeParams? fadeParams, float timeStretchRatio = 1f)
		{
			return default(AudioPlayback);
		}

		public AudioPlayback Play(string cueName, Vector3 emitterPos, float volume = 1f, bool isLoop = false, int prioLevel = int.MaxValue, float timeStretchRatio = 1f)
		{
			return default(AudioPlayback);
		}

		public AudioPlayback Play(string cueName, Transform emitterTrans, bool isHoming = false, float volume = 1f, bool isLoop = false, int prioLevel = int.MaxValue, float timeStretchRatio = 1f)
		{
			return default(AudioPlayback);
		}

		private AudioPlayback Play(string cueName, PlayParameters param, int prioLevel = int.MaxValue, [Optional] Action playEndCallback, [Optional] FadeParams? fadeParams)
		{
			return default(AudioPlayback);
		}

		private bool CheckDistanceLimit(string cueName, PlayParameters param, float distanceLimit)
		{
			return default(bool);
		}

		public void Stop(SoundGroup soundGroup, float fadeOutTime = 1f)
		{
		}

		public void Stop(AudioPlayback playback, float fadeOutTime = 1f)
		{
		}

		public void StopAll(SoundGroup soundGroup, float fadeOutTime = 1f)
		{
		}

		public void Pause(AudioPlayback playback, bool isPause, float fadeTime = 0f)
		{
		}

		public void PauseAll(SoundGroup soundGroup, bool isPause, float fadeTime = 0f)
		{
		}

		public bool IsPlaying(AudioPlayback playback)
		{
			return default(bool);
		}

		public bool IsPlaying(string cueName)
		{
			return default(bool);
		}

		public bool IsFading(AudioPlayback playback)
		{
			return default(bool);
		}

		public void SetSourceVolume(AudioPlayback playback, float volume, float fadeTime = 0f)
		{
		}

		public void SetSourceVolume(float volume, float fadeTime = 0f, string[] cueNames)
		{
		}

		public void SetSoloPlayCueName(string[] cueNames)
		{
		}

		public void ClearSoloPlayCueName()
		{
		}

		private bool IsSoloCue(SoundGroup soundGroup, string cueName)
		{
			return default(bool);
		}

		public bool GetCategoryMute(SoundGroup soundGroup)
		{
			return default(bool);
		}

		public void SetCategoryMute(SoundGroup soundGroup, bool isMute)
		{
		}

		public float GetCategoryVolume(SoundGroup soundGroup)
		{
			return default(float);
		}

		public void SetCategoryVolume(SoundGroup soundGroup, float volume)
		{
		}

		private void LoadBgmCueSheet(string cueName)
		{
		}

		private AudioPlayback PlayBgm(string cueName, PlayParameters param, [Optional] Action playEndCallback, bool isInteractive = false, [Optional] FadeParams? fadeParams)
		{
			return default(AudioPlayback);
		}

		private AudioPlayback PlayCrossFadeBgm(RequestCueInfo info, PlayParameters param)
		{
			return default(AudioPlayback);
		}

		public void SetVolumeLastPlayingBgm(float volume, float fadeTime = 1f)
		{
		}

		public AudioPlayback PlayInteractiveBgm(string cueName, Action transitionStartCallback)
		{
			return default(AudioPlayback);
		}

		public InteractiveBgmController.TransitionInfo TransitionInteractiveBgm(AudioPlayback playback)
		{
			return default(InteractiveBgmController.TransitionInfo);
		}

		public InteractiveBgmController.TransitionInfo GetTransitionInfo()
		{
			return default(InteractiveBgmController.TransitionInfo);
		}

		public void SetTransitionStartCallback(Action transitionStartCallback)
		{
		}

		public void RemoveTransitionStartCallback(Action transitionStartCallback)
		{
		}

		public void ClearAllTransitionCallbacks()
		{
		}

		public void SetBeatActionCallback(Action beatActionCallback)
		{
		}

		public void RemoveBeatActionCallback(Action beatActionCallback)
		{
		}

		public void ClearAllBeatActionCallbacks()
		{
		}

		public void SetBlockId(int blockIndex)
		{
		}

		public float GetVoiceOutPutRaito()
		{
			return default(float);
		}

		public void EnableDspBusEq(bool isEnabled)
		{
		}

		public float GetUserOptionVolume(SoundGroup soundGroup)
		{
			return default(float);
		}

		public void SetUserOptionVolume(SoundGroup soundGroup, float volume)
		{
		}

		public bool GetUserOptionMute(SoundGroup soundGroup)
		{
			return default(bool);
		}

		public void SetUserOptionMute(SoundGroup soundGroup, bool isMute)
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void SetPriorityList_Apr2019()
		{
		}

		public void SetPriorityList()
		{
		}

		public int GetPriorityLevel(string cueName)
		{
			return default(int);
		}

		public AudioPlayback Play2d(string cueName, float stereoPan = 0f, float volume = 1f)
		{
			return default(AudioPlayback);
		}

		public AudioPlayback PlayBgm_Apr2019(string cueName, bool isPositionResume = false)
		{
			return default(AudioPlayback);
		}

		public void StopBgm_Apr2019(AudioPlayback playback, float fadeOutTime, bool isPositionResumeGuard = false)
		{
		}

		public void Pause_Apr2019(string[] notPauseCueNames)
		{
		}

		public void Resume_Apr2019()
		{
		}
	}
}
