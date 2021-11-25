using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri.Audio;
using UnityEngine;

namespace Cute.Cri
{
	public abstract class AudioControllerBase : MonoBehaviour
	{
		private CuteAudioSourcePool pool;

		protected abstract int DefaultSourceCountMax { get; }

		protected abstract SoundGroup Group { get; }

		public AudioPlayback LastPlayback
		{
			[CompilerGenerated]
			get
			{
				return default(AudioPlayback);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public void Initialize()
		{
		}

		public void SetSourceCountMax(int sourceCountMax)
		{
		}

		public void SetPrioritySettingList(List<PrioritySetting> prioritySettingList)
		{
		}

		public void ClearPrioritySettingList()
		{
		}

		public AudioPlayback Play(int index, RequestCueInfo info, PlayParameters param, [Optional] Action stoppedCallback)
		{
			return default(AudioPlayback);
		}

		public AudioPlayback Play(RequestCueInfo info, PlayParameters param, [Optional] Action stoppedCallback)
		{
			return default(AudioPlayback);
		}

		public AudioPlayback PlayCrossFade(RequestCueInfo info, PlayParameters param, [Optional] Action stoppedCallback)
		{
			return default(AudioPlayback);
		}

		public AudioPlayback ResumeCrossFade(PlayParameters param)
		{
			return default(AudioPlayback);
		}

		public void Stop(AudioPlayback playback, float fadeOutTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear, [Optional] Action stoppedCallback)
		{
		}

		public void Stop(int index, float fadeOutTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear, [Optional] Action stoppedCallback)
		{
		}

		public void Stop(string cueName, float fadeOutTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear, [Optional] Action stoppedCallback)
		{
		}

		public void StopSpecifiedCueName(List<string> targetCueNameList, float fadeOutTime)
		{
		}

		public void AllStopSpecifyIgnoreCueName(List<string> ignoreCueNameList, float fadeOutTime)
		{
		}

		public void StopCueSheetName(string cueSheetName, float fadeOutTime)
		{
		}

		public void StopAll(float fadeOutTime, FadeCurve fadeCurve = FadeCurve.Linear, [Optional] Action stoppedCallback)
		{
		}

		public void Pause(AudioPlayback playback, bool isPause, float fadeTime = 0f)
		{
		}

		public void Pause(int index, bool isPause, float fadeTime = 0f)
		{
		}

		public void PauseSpecifyIgnoreCue(List<string> ignoreCueNameList, bool isPause, float fadeTime = 0f)
		{
		}

		public void PauseAll(bool isPause, float fadeTime = 0f)
		{
		}

		public bool IsPlaying(RequestCueInfo info)
		{
			return default(bool);
		}

		public bool IsPlaying(AudioPlayback playback)
		{
			return default(bool);
		}

		public bool IsPlaying(int index)
		{
			return default(bool);
		}

		public bool IsPlayingAll()
		{
			return default(bool);
		}

		public bool IsPaused(RequestCueInfo info)
		{
			return default(bool);
		}

		public bool IsPaused(AudioPlayback playback)
		{
			return default(bool);
		}

		public bool IsPaused(int index)
		{
			return default(bool);
		}

		public bool IsPausedAll()
		{
			return default(bool);
		}

		public bool IsFading(RequestCueInfo info)
		{
			return default(bool);
		}

		public bool IsFading(AudioPlayback playback)
		{
			return default(bool);
		}

		public bool IsFading(int index)
		{
			return default(bool);
		}

		public void SetPlayerBusSendLevel(int index, string busName, float toLevel, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetPlayerBusSendLevel(AudioPlayback playback, string busName, float toLevel, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetPlayerBusSendLevel(int index, string busName, float fromLevel, float toLevel, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetPlayerBusSendLevel(AudioPlayback playback, string busName, float fromLevel, float toLevel, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetSelectorLabel(int index, SelectorInfo selectorInfo)
		{
		}

		public void SetSelectorLabel(AudioPlayback playback, SelectorInfo selectorInfo)
		{
		}

		public void SetNextBlockId(AudioPlayback playback, int blockId)
		{
		}

		public void SetSourceVolume(AudioPlayback playback, float volume, float fadeTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetSourceVolume(int index, float volume, float fadeTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetSourceVolume(string cueName, float volume, float fadeTime = 0f)
		{
		}

		public void SetSpecifiedSourceVolume(List<string> targetCueNameList, float volume, float fadeTime = 0f)
		{
		}

		public void SetAllSpecifyIgnoreSourceVolume(List<string> ignoreCueNameList, float volume, float fadeTime)
		{
		}

		public void SetAllSourceVolume(float volume, float fadeTime = 0f)
		{
		}

		public float GetSourceVolume(AudioPlayback playback)
		{
			return default(float);
		}

		public float GetSourceVolume(int index)
		{
			return default(float);
		}

		public void SetPan3dAngle(int index, float angle)
		{
		}

		public void SetPan3dAngle(AudioPlayback playback, float angle)
		{
		}

		public void SetPlayerAisacControl(int index, string controlName, float controlValue)
		{
		}

		public void SetPlayerAisacControl(int index, uint controlId, float controlValue)
		{
		}

		public void SetPlayerAisacControl(AudioPlayback playback, string controlName, float controlValue)
		{
		}

		public void SetPlayerAisacControl(AudioPlayback playback, uint controlId, float controlValue)
		{
		}

		public void SetPlayerAisacControlAll(string controlName, float controlValue)
		{
		}

		public void SetPlayerAisacControlAll(uint controlId, float controlValue)
		{
		}

		public long GetTimeSyncedWithAudio(AudioPlayback playback)
		{
			return default(long);
		}

		private string CreateSoundObjName(AudioPlayback playback)
		{
			return null;
		}

		public int GetPlayingCount(int prioLevel)
		{
			return default(int);
		}
	}
}
