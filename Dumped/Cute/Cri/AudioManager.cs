using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri.Audio;
using UnityEngine;

namespace Cute.Cri
{
	public class AudioManager : MonoBehaviour
	{
		[SerializeField]
		private AudioControllerBgm audioCtrlBgm;

		[SerializeField]
		private AudioControllerSe audioCtrlSe;

		[SerializeField]
		private AudioControllerVoice audioCtrlVoice;

		private Dictionary<SoundGroup, AudioControllerBase> audioCtrlDict;

		private static AudioManager instance;

		private const string ACB_EXTENSION = ".acb";

		private const string AWB_EXTENSION = ".awb";

		private const string STR_SUBFOLDER_BGM = "b/";

		public const string STR_SUBFOLDER_SE = "s/";

		public const string STR_SUBFOLDER_VOICE = "v/";

		private List<string> preinCueSheetNameList;

		[SerializeField]
		private AudioListenerController listenerController;

		[SerializeField]
		public SoundGroupVolumeController soundGroupVolumeUpdater;

		[SerializeField]
		private bool useAnalyzedCueName;

		private int checkLatencyTryCount;

		private CriAtomExLatencyEstimator.EstimatorInfo info;

		public AudioPlayback LastBgmPlayback => default(AudioPlayback);

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

		public static AudioManager Instance => null;

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

		public bool UseAnalyzedCueName
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public long Latency => default(long);

		public LatencyCheckState LatencyCheckState
		{
			[CompilerGenerated]
			get
			{
				return default(LatencyCheckState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		private void OnDestroy()
		{
		}

		private void Awake()
		{
		}

		public void SetSourceCountMax(SoundGroup group, int sourceCountMax)
		{
		}

		public void SetPrioritySettingList(SoundGroup group, List<PrioritySetting> prioritySettingList)
		{
		}

		public void ClearPrioritySettingList(SoundGroup group)
		{
		}

		public AudioPlayback Play(SoundGroup group, RequestCueInfo info, [Optional] PlayParameters param, [Optional] Action stoppedCallback)
		{
			return default(AudioPlayback);
		}

		public AudioPlayback Play(SoundGroup group, int index, RequestCueInfo info, [Optional] PlayParameters param, [Optional] Action stoppedCallback)
		{
			return default(AudioPlayback);
		}

		public AudioPlayback PlayCrossFade(SoundGroup group, RequestCueInfo info, [Optional] PlayParameters param, [Optional] Action stoppedCallback)
		{
			return default(AudioPlayback);
		}

		public AudioPlayback ResumeCrossFade(SoundGroup group, [Optional] PlayParameters param)
		{
			return default(AudioPlayback);
		}

		public AudioPlayback PlayActionCue(AudioPlayback playback, RequestCueInfo info)
		{
			return default(AudioPlayback);
		}

		public void Stop(AudioPlayback playback, float fadeOutTime = 0f, [Optional] Action stoppedCallback)
		{
		}

		public void Stop(SoundGroup group, string cueName, float fadeOutTime = 0f, [Optional] Action stoppedCallback)
		{
		}

		public void Stop(SoundGroup group, int index, float fadeOutTime = 0f, [Optional] Action stoppedCallback)
		{
		}

		public void StopSpecifiedCueName(SoundGroup group, List<string> targetCueNameList, float fadeOutTime = 0f)
		{
		}

		public void StopAllSpecifiedIgnoreCueName(SoundGroup group, List<string> ignoreCueNameList, float fadeOutTime = 0f)
		{
		}

		public void StopCueSheetName(SoundGroup group, string cueSheetName, float fadeOutTime)
		{
		}

		public void StopAll(SoundGroup group, float fadeOutTime = 0f, [Optional] Action stoppedCallback)
		{
		}

		public void Pause(SoundGroup group, int index, bool isPause, float fadeTime = 0f)
		{
		}

		public void Pause(AudioPlayback playback, bool isPause, float fadeTime = 0f)
		{
		}

		public void PauseAll(SoundGroup group, bool isPause, float fadeTime = 0f)
		{
		}

		public void PauseSpecifyIgnoreCue(SoundGroup group, List<string> ignoreCueNameList, bool isPause, float fadeTime = 0f)
		{
		}

		public bool IsPlaying(SoundGroup group, int index)
		{
			return default(bool);
		}

		public bool IsPlaying(SoundGroup group, RequestCueInfo info)
		{
			return default(bool);
		}

		public bool IsPlaying(AudioPlayback playback)
		{
			return default(bool);
		}

		public bool IsPlayingAll(SoundGroup group)
		{
			return default(bool);
		}

		public bool IsPaused(SoundGroup group, int index)
		{
			return default(bool);
		}

		public bool IsPaused(SoundGroup group, RequestCueInfo info)
		{
			return default(bool);
		}

		public bool IsPaused(AudioPlayback playback)
		{
			return default(bool);
		}

		public bool IsPausedAll(SoundGroup group)
		{
			return default(bool);
		}

		public bool IsFading(SoundGroup group, int index)
		{
			return default(bool);
		}

		public bool IsFading(SoundGroup group, RequestCueInfo info)
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

		public void SetSourceVolume(SoundGroup group, int index, float volume, float fadeTime = 0f)
		{
		}

		public void SetSourceVolume(SoundGroup group, string cueName, float volume, float fadeTime = 0f)
		{
		}

		public void SetAllSourceVolume(SoundGroup group, float volume, float fadeTime = 0f)
		{
		}

		public void SetSpecifiedSourceVolume(SoundGroup group, List<string> targetCueNameList, float volume, float fadeTime = 0f)
		{
		}

		public void SetAllSpecifyIgnoreSourceVolume(SoundGroup group, List<string> ignoreCueNameList, float volume, float fadeTime = 0f)
		{
		}

		public float GetSourceVolume(AudioPlayback playback)
		{
			return default(float);
		}

		public void SetSelectorLabel(SoundGroup group, int index, string selector, string label)
		{
		}

		public void SetNextBlockId(AudioPlayback playback, int blockId)
		{
		}

		public void SetPan2d(SoundGroup group, int index, float angleRatio, float angleRange = 30f)
		{
		}

		public void SetAisacControl(string categoryName, string controlName, float controlValue)
		{
		}

		public void SetAisacControl(SoundGroup group, int index, string controlName, float controlValue)
		{
		}

		public void SetAisacControl(SoundGroup group, int index, uint controlId, float controlValue)
		{
		}

		public void SetAisacControlAll(SoundGroup group, string controlName, float controlValue)
		{
		}

		public void SetAisacControlAll(SoundGroup group, uint controlId, float controlValue)
		{
		}

		public void StopAllSoundGroup(float fadeOutTime = 0f)
		{
		}

		public void PauseAllSoundGroup(bool isPause, float fadeOutTime = 0f)
		{
		}

		public static string GetSubFolderPath(SoundGroup group)
		{
			return null;
		}

		public void RegisterPreinCueSheetNameList(List<string> cueSheetNameList)
		{
		}

		private void GetSoundFilePath(string cueSheetName, string subFolderPath, out string acbFilePath, out string awbFilePath)
		{
		}

		public CriAtomCueSheet AddCueSheet(SoundGroup group, string cueSheetName)
		{
			return null;
		}

		public CriAtomCueSheet AddCueSheet(string cueSheetName, string subFolderPath)
		{
			return null;
		}

		public CriAtomCueSheet AddCueSheet(string cueSheetName, string acbFilePath, string awbFilePath)
		{
			return null;
		}

		public void RemoveCueSheet(string cueSheetName)
		{
		}

		public void RemoveCueSheet(List<string> cueSheetNameList)
		{
		}

		public bool IsAvailableCueSheet(string cueName)
		{
			return default(bool);
		}

		public List<string> GetAddedCueSheetNameList()
		{
			return null;
		}

		public int GetAddedCueSheetNameListCount()
		{
			return default(int);
		}

		public void Enable3dListener(bool isEnable)
		{
		}

		public void SetListenerLerpValue(float listenerLerpValue)
		{
		}

		public void Update3dListenerPos(Transform cameraTrans, Transform playerTrans)
		{
		}

		public Vector3 Get3dListenerPos()
		{
			return default(Vector3);
		}

		public void Set3dListenerPos(Vector3 listenerPos)
		{
		}

		public Quaternion Get3dListenerRot()
		{
			return default(Quaternion);
		}

		public void Set3dListenerRot(Quaternion listenerRot)
		{
		}

		public void InitializeSoundTypeVolumeUpdater(SoundGroupVolumeController.ControlType volumeControllerType, Dictionary<SoundGroup, string[]> relateDataDict)
		{
		}

		public bool GetSoundGroupMute(SoundGroup group)
		{
			return default(bool);
		}

		public void SetSoundGroupMute(SoundGroup group, bool isMute)
		{
		}

		public float GetSoundGroupVolume(string name)
		{
			return default(float);
		}

		public float GetSoundGroupVolume(SoundGroup group)
		{
			return default(float);
		}

		public void SetSoundGroupVolume(SoundGroup group, float volume)
		{
		}

		public void FadeSoundGroupVolume(SoundGroup group, float toVolume, float fadeTime = 0f)
		{
		}

		public int GetPlayingCount(SoundGroup group, int prioLevel)
		{
			return default(int);
		}

		public void CheckLatency()
		{
		}

		private IEnumerator CheckLatencyCoroutine()
		{
			return null;
		}
	}
}
