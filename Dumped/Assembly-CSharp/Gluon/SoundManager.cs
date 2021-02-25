/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Cri.Audio;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SoundManager : SingletonMonoBehaviour<Gluon.SoundManager>
	{
		// Fields
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
		[CompilerGenerated]
		private AudioPlayback _LastBgmPlayback_k__BackingField;
		private bool _isSoloPlay;
		private Dictionary<SoundGroup, List<string>> _soloPlayCueNameDict;
		private InteractiveBgmController _interactiveBgmController;
		public ReplaceCueName cueNameReplacer;
		private readonly List<PrioritySetting> sePriorityList;
		private readonly List<PrioritySetting> voicePriorityList;
		private const float GimmickSeDistanceLimit = 50f;
		private const float GimmickSeInteriorDistance = 16f;
		[CompilerGenerated]
		private bool _IsInitialized_k__BackingField;
		private const float AngleRange = 30f;
		private readonly List<PrioritySetting> sePriorityList_Apr2019;
		private readonly List<PrioritySetting> voicePriorityList_Apr2019;
		private readonly Dictionary<string, int> prioLevelList;
		private Dictionary<string, BgmStopInfo> bgmStopInfoDict;
	
		// Properties
		public static bool hasInstance { get; }
		public AudioPlayback LastBgmPlayback { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private string RawAssetRootFullPath { get; }
		public static string LocalizedSoundParentPath { get; }
		public bool IsInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool MuteVocal { get; set; }
		public VocalTrack VocalTrack { get; set; }
	
		// Nested types
		public struct FadeParams
		{
			// Fields
			[CompilerGenerated]
			private float _FadeOutTime_k__BackingField;
			[CompilerGenerated]
			private float _FadeInTime_k__BackingField;
			[CompilerGenerated]
			private float _OffsetTime_k__BackingField;
	
			// Properties
			public float FadeOutTime { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float FadeInTime { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float OffsetTime { [CompilerGenerated] get; [CompilerGenerated] set; }
			public static FadeParams DisableFade { get; }
		}
	
		public class CriAtomCueSheetCompare : IEqualityComparer<CriAtomCueSheet>
		{
			// Constructors
			public CriAtomCueSheetCompare();
	
			// Methods
			public bool Equals(CriAtomCueSheet cueSheet1, CriAtomCueSheet cueSheet2);
			public int GetHashCode(CriAtomCueSheet cueSheet);
		}
	
		public delegate void ReplaceCueName(ref string cueName);
	
		private static class PreferFirstDecision
		{
			// Fields
			private static readonly List<string> preferFirstList;
	
			// Constructors
			static PreferFirstDecision();
	
			// Methods
			public static void SetCuteAudioPriority(SoundGroup group, string cueName, int prioLevel, ref PlayParameters param);
		}
	
		private struct CrossFadeParam
		{
			// Fields
			public float fadeOutTime;
			public float fadeInTime;
			public float offsetTime;
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass3_0
			{
				// Fields
				public string cueName;
	
				// Constructors
				public __c__DisplayClass3_0();
	
				// Methods
				internal bool _GetCrossFadeParam_b__0(CrossFadeBGMElement item);
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Func<CrossFadeBGMElement, bool> __9__3_1;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal bool _GetCrossFadeParam_b__3_1(CrossFadeBGMElement item);
			}
	
			// Methods
			public static CrossFadeParam GetCrossFadeParam(string cueName, AudioPlayback lastBgmPlayback);
		}
	
		public struct VoiceSubFolderDecision
		{
			// Fields
			private const string subFolderInGame = "InGame";
			private const string subFolderOutGame = "OutGame";
			private const string subFolderStory = "Story";
			private const string subFolderSummonTop = "SummonTop";
			private const string subFolderOther = "Other";
			private static readonly string[,] table;
	
			// Constructors
			static VoiceSubFolderDecision();
	
			// Methods
			public static string GetSubFolderName(string cueSheetName);
		}
	
		private struct BgmStopInfo
		{
			// Fields
			[CompilerGenerated]
			private long _StopTime_k__BackingField;
			[CompilerGenerated]
			private bool _IsPositionResumeGuard_k__BackingField;
	
			// Properties
			public long StopTime { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool IsPositionResumeGuard { [CompilerGenerated] get; [CompilerGenerated] set; }
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__37_0;
			public static Func<float, float> __9__37_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Awake_b__37_0();
			internal float _Awake_b__37_1(float timeStretchRatio);
		}
	
		[CompilerGenerated]
		private sealed class _RemoveCueSheetCoroutine_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string cueSheetName;
			public SoundManager __4__this;
			public float waitTime;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RemoveCueSheetCoroutine_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _RemoveCueSheetCoroutine_d__44 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float waitTime;
			public SoundGroup group;
			public SoundManager __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RemoveCueSheetCoroutine_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public string cueSheetName;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal bool _IsLoadedGroup_b__0(string item);
		}
	
		// Constructors
		public SoundManager();
		static SoundManager();
	
		// Methods
		protected override void Awake();
		private string GetSoundFilePath(string basePath);
		public void LoadGroup();
		public void LoadGroup(string cueSheetName);
		public void ReleaseGroup(string cueSheetName, float waitTime = 0.5f);
		[IteratorStateMachine]
		private IEnumerator RemoveCueSheetCoroutine(string cueSheetName, float waitTime);
		public void ReleaseGroup(SoundGroup group, float waitTime = 0.5f);
		[IteratorStateMachine]
		private IEnumerator RemoveCueSheetCoroutine(SoundGroup group, float waitTime);
		public int GetBgmCueSheetCount();
		public bool IsLoadedGroup(string cueSheetName);
		private CriAtomCueSheet GetLoadedCueSheet(string cueSheetName);
		private string GetCueSheetName(string cueName);
		public bool IsLoadedCueSheet(string cueName);
		public void RegisterLoadGroupName(string groupName);
		public void ClearLoadGroupName();
		public static string ConvertSoundGroupName(string soundName);
		public static SoundGroup CueSheetNameToCategory(string cueSheetName);
		private SoundGroup CueNameToCategory(string cueSheetName);
		public AudioPlayback Play(string cueName, float volume = 1f, bool isLoop = false, int prioLevel = 2147483647, Action playEndCallback = null, FadeParams? fadeParams = default, float timeStretchRatio = 1f);
		public AudioPlayback Play(string cueName, Vector3 emitterPos, float volume = 1f, bool isLoop = false, int prioLevel = 2147483647, float timeStretchRatio = 1f);
		public AudioPlayback Play(string cueName, Transform emitterTrans, bool isHoming = false, float volume = 1f, bool isLoop = false, int prioLevel = 2147483647, float timeStretchRatio = 1f);
		private AudioPlayback Play(string cueName, PlayParameters param, int prioLevel = 2147483647, Action playEndCallback = null, FadeParams? fadeParams = default);
		private bool CheckDistanceLimit(string cueName, PlayParameters param, float distanceLimit);
		public void Stop(SoundGroup soundGroup, float fadeOutTime = 1f);
		public void Stop(AudioPlayback playback, float fadeOutTime = 1f);
		public void StopAll(SoundGroup soundGroup, float fadeOutTime = 1f);
		public void Pause(AudioPlayback playback, bool isPause, float fadeTime = 0f);
		public void PauseAll(SoundGroup soundGroup, bool isPause, float fadeTime = 0f);
		public bool IsPlaying(AudioPlayback playback);
		public bool IsPlaying(string cueName);
		public bool IsFading(AudioPlayback playback);
		public void SetSourceVolume(AudioPlayback playback, float volume, float fadeTime = 0f);
		public void SetSourceVolume(float volume, float fadeTime = 0f, params string[] cueNames);
		public void SetSoloPlayCueName(params string[] cueNames);
		public void ClearSoloPlayCueName();
		private bool IsSoloCue(SoundGroup soundGroup, string cueName);
		public bool GetCategoryMute(SoundGroup soundGroup);
		public void SetCategoryMute(SoundGroup soundGroup, bool isMute);
		public float GetCategoryVolume(SoundGroup soundGroup);
		public void SetCategoryVolume(SoundGroup soundGroup, float volume);
		private void LoadBgmCueSheet(string cueName);
		private AudioPlayback PlayBgm(string cueName, PlayParameters param, Action playEndCallback = null, bool isInteractive = false, FadeParams? fadeParams = default);
		private AudioPlayback PlayCrossFadeBgm(RequestCueInfo info, PlayParameters param);
		public void SetVolumeLastPlayingBgm(float volume, float fadeTime = 1f);
		public AudioPlayback PlayInteractiveBgm(string cueName, Action transitionStartCallback);
		public InteractiveBgmController.TransitionInfo TransitionInteractiveBgm(AudioPlayback playback);
		public InteractiveBgmController.TransitionInfo GetTransitionInfo();
		public void SetTransitionStartCallback(Action transitionStartCallback);
		public void RemoveTransitionStartCallback(Action transitionStartCallback);
		public void ClearAllTransitionCallbacks();
		public void SetBeatActionCallback(Action beatActionCallback);
		public void RemoveBeatActionCallback(Action beatActionCallback);
		public void ClearAllBeatActionCallbacks();
		public void SetBlockId(int blockIndex);
		public float GetVoiceOutPutRaito();
		public void EnableDspBusEq(bool isEnabled);
		public float GetUserOptionVolume(SoundGroup soundGroup);
		public void SetUserOptionVolume(SoundGroup soundGroup, float volume);
		public bool GetUserOptionMute(SoundGroup soundGroup);
		public void SetUserOptionMute(SoundGroup soundGroup, bool isMute);
		private void Update();
		protected override void OnDestroy();
		public void SetPriorityList_Apr2019();
		public void SetPriorityList();
		public int GetPriorityLevel(string cueName);
		public AudioPlayback Play2d(string cueName, float stereoPan = 0f, float volume = 1f);
		public AudioPlayback PlayBgm_Apr2019(string cueName, bool isPositionResume = false);
		public void StopBgm_Apr2019(AudioPlayback playback, float fadeOutTime, bool isPositionResumeGuard = false);
		public void Pause_Apr2019(params string[] notPauseCueNames);
		public void Resume_Apr2019();
	}
}
