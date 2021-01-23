/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri.Audio;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class AudioManager : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private AudioControllerBgm audioCtrlBgm;
		[SerializeField]
		private AudioControllerSe audioCtrlSe;
		[SerializeField]
		private AudioControllerVoice audioCtrlVoice;
		private Dictionary<SoundGroup, AudioControllerBase> audioCtrlDict;
		[CompilerGenerated]
		private static bool _IsInitialized_k__BackingField;
		private static AudioManager instance;
		private const string ACB_EXTENSION = ".acb";
		private const string AWB_EXTENSION = ".awb";
		private const string STR_SUBFOLDER_BGM = "b/";
		public const string STR_SUBFOLDER_SE = "s/";
		public const string STR_SUBFOLDER_VOICE = "v/";
		[CompilerGenerated]
		private Func<bool> _IsUseAssetBundle_k__BackingField;
		[CompilerGenerated]
		private Func<string, string> _AssetFilePathGetter_k__BackingField;
		private List<string> preinCueSheetNameList;
		[SerializeField]
		private AudioListenerController listenerController;
		[SerializeField]
		public SoundGroupVolumeController soundGroupVolumeUpdater;
		[SerializeField]
		private bool useAnalyzedCueName;
		[CompilerGenerated]
		private LatencyCheckState _LatencyCheckState_k__BackingField;
		private int checkLatencyTryCount;
		private CriAtomExLatencyEstimator.EstimatorInfo info;
	
		// Properties
		public AudioPlayback LastBgmPlayback { get; }
		public static bool IsInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static AudioManager Instance { get; }
		public Func<bool> IsUseAssetBundle { [CompilerGenerated] private get; [CompilerGenerated] set; }
		public Func<string, string> AssetFilePathGetter { [CompilerGenerated] private get; [CompilerGenerated] set; }
		public bool UseAnalyzedCueName { get; set; }
		public long Latency { get; }
		public LatencyCheckState LatencyCheckState { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CheckLatencyCoroutine_d__117 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AudioManager __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckLatencyCoroutine_d__117(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public AudioManager();
		static AudioManager();
	
		// Methods
		public static bool IsInstanceEmpty();
		private void OnDestroy();
		private void Awake();
		public void SetSourceCountMax(SoundGroup group, int sourceCountMax);
		public void SetPrioritySettingList(SoundGroup group, List<PrioritySetting> prioritySettingList);
		public AudioPlayback Play(SoundGroup group, RequestCueInfo info, PlayParameters param = default, Action stoppedCallback = null);
		public AudioPlayback Play(SoundGroup group, int index, RequestCueInfo info, PlayParameters param = default, Action stoppedCallback = null);
		public AudioPlayback PlayCrossFade(SoundGroup group, RequestCueInfo info, PlayParameters param = default, Action stoppedCallback = null);
		public AudioPlayback ResumeCrossFade(SoundGroup group, PlayParameters param = default);
		public AudioPlayback PlayActionCue(AudioPlayback playback, RequestCueInfo info);
		public void Stop(AudioPlayback playback, float fadeOutTime = 0f, Action stoppedCallback = null);
		public void Stop(SoundGroup group, string cueName, float fadeOutTime = 0f, Action stoppedCallback = null);
		public void Stop(SoundGroup group, int index, float fadeOutTime = 0f, Action stoppedCallback = null);
		public void StopSpecifiedCueName(SoundGroup group, List<string> targetCueNameList, float fadeOutTime = 0f);
		public void StopAllSpecifiedIgnoreCueName(SoundGroup group, List<string> ignoreCueNameList, float fadeOutTime = 0f);
		public void StopCueSheetName(SoundGroup group, string cueSheetName, float fadeOutTime);
		public void StopAll(SoundGroup group, float fadeOutTime = 0f, Action stoppedCallback = null);
		public void Pause(SoundGroup group, int index, bool isPause, float fadeTime = 0f);
		public void Pause(AudioPlayback playback, bool isPause, float fadeTime = 0f);
		public void PauseAll(SoundGroup group, bool isPause, float fadeTime = 0f);
		public void PauseSpecifyIgnoreCue(SoundGroup group, List<string> ignoreCueNameList, bool isPause, float fadeTime = 0f);
		public bool IsPlaying(SoundGroup group, int index);
		public bool IsPlaying(SoundGroup group, RequestCueInfo info);
		public bool IsPlaying(AudioPlayback playback);
		public bool IsPlayingAll(SoundGroup group);
		public bool IsPaused(SoundGroup group, int index);
		public bool IsPaused(SoundGroup group, RequestCueInfo info);
		public bool IsPaused(AudioPlayback playback);
		public bool IsPausedAll(SoundGroup group);
		public bool IsFading(SoundGroup group, int index);
		public bool IsFading(SoundGroup group, RequestCueInfo info);
		public bool IsFading(AudioPlayback playback);
		public void SetSourceVolume(AudioPlayback playback, float volume, float fadeTime = 0f);
		public void SetSourceVolume(SoundGroup group, int index, float volume, float fadeTime = 0f);
		public void SetSourceVolume(SoundGroup group, string cueName, float volume, float fadeTime = 0f);
		public void SetAllSourceVolume(SoundGroup group, float volume, float fadeTime = 0f);
		public void SetSpecifiedSourceVolume(SoundGroup group, List<string> targetCueNameList, float volume, float fadeTime = 0f);
		public void SetAllSpecifyIgnoreSourceVolume(SoundGroup group, List<string> ignoreCueNameList, float volume, float fadeTime = 0f);
		public float GetSourceVolume(AudioPlayback playback);
		public void SetSelectorLabel(SoundGroup group, int index, string selector, string label);
		public void SetNextBlockId(AudioPlayback playback, int blockId);
		public void SetPan2d(SoundGroup group, int index, float angleRatio, float angleRange = 30f);
		public void SetAisacControl(string categoryName, string controlName, float controlValue);
		public void SetAisacControl(SoundGroup group, int index, string controlName, float controlValue);
		public void SetAisacControl(SoundGroup group, int index, uint controlId, float controlValue);
		public void SetAisacControlAll(SoundGroup group, string controlName, float controlValue);
		public void SetAisacControlAll(SoundGroup group, uint controlId, float controlValue);
		public void StopAllSoundGroup(float fadeOutTime = 0f);
		public void PauseAllSoundGroup(bool isPause, float fadeOutTime = 0f);
		public static string GetSubFolderPath(SoundGroup group);
		public void RegisterPreinCueSheetNameList(List<string> cueSheetNameList);
		private void GetSoundFilePath(string cueSheetName, string subFolderPath, out string acbFilePath, out string awbFilePath);
		public CriAtomCueSheet AddCueSheet(SoundGroup group, string cueSheetName);
		public CriAtomCueSheet AddCueSheet(string cueSheetName, string subFolderPath);
		public CriAtomCueSheet AddCueSheet(string cueSheetName, string acbFilePath, string awbFilePath);
		public void RemoveCueSheet(string cueSheetName);
		public void RemoveCueSheet(List<string> cueSheetNameList);
		public bool IsAvailableCueSheet(string cueName);
		public List<string> GetAddedCueSheetNameList();
		public int GetAddedCueSheetNameListCount();
		public void Enable3dListener(bool isEnable);
		public void SetListenerLerpValue(float listenerLerpValue);
		public void Update3dListenerPos(Transform cameraTrans, Transform playerTrans);
		public Vector3 Get3dListenerPos();
		public void Set3dListenerPos(Vector3 listenerPos);
		public Quaternion Get3dListenerRot();
		public void Set3dListenerRot(Quaternion listenerRot);
		public void InitializeSoundTypeVolumeUpdater(SoundGroupVolumeController.ControlType volumeControllerType, Dictionary<SoundGroup, string[]> relateDataDict);
		public bool GetSoundGroupMute(SoundGroup group);
		public void SetSoundGroupMute(SoundGroup group, bool isMute);
		public float GetSoundGroupVolume(string name);
		public float GetSoundGroupVolume(SoundGroup group);
		public void SetSoundGroupVolume(SoundGroup group, float volume);
		public void FadeSoundGroupVolume(SoundGroup group, float toVolume, float fadeTime = 0f);
		public int GetPlayingCount(SoundGroup group, int prioLevel);
		public void CheckLatency();
		[IteratorStateMachine]
		private IEnumerator CheckLatencyCoroutine();
	}
}
