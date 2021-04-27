/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri.Audio;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public abstract class AudioControllerBase : MonoBehaviour
	{
		// Fields
		private CuteAudioSourcePool pool;
		[CompilerGenerated]
		private AudioPlayback _LastPlayback_k__BackingField;
	
		// Properties
		protected abstract int DefaultSourceCountMax { get; }
		protected abstract SoundGroup Group { get; }
		public AudioPlayback LastPlayback { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public Action stoppedCallback;
			public AudioControllerBase __4__this;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _Stop_b__0();
		}
	
		// Constructors
		protected AudioControllerBase();
	
		// Methods
		public void Initialize();
		public void SetSourceCountMax(int sourceCountMax);
		public void SetPrioritySettingList(List<PrioritySetting> prioritySettingList);
		public void ClearPrioritySettingList();
		public AudioPlayback Play(int index, RequestCueInfo info, PlayParameters param, Action stoppedCallback = null);
		public AudioPlayback Play(RequestCueInfo info, PlayParameters param, Action stoppedCallback = null);
		public AudioPlayback PlayCrossFade(RequestCueInfo info, PlayParameters param, Action stoppedCallback = null);
		public AudioPlayback ResumeCrossFade(PlayParameters param);
		public void Stop(AudioPlayback playback, float fadeOutTime = 0f, Action stoppedCallback = null);
		public void Stop(int index, float fadeOutTime = 0f, Action stoppedCallback = null);
		public void Stop(string cueName, float fadeOutTime = 0f, Action stoppedCallback = null);
		public void StopSpecifiedCueName(List<string> targetCueNameList, float fadeOutTime);
		public void AllStopSpecifyIgnoreCueName(List<string> ignoreCueNameList, float fadeOutTime);
		public void StopCueSheetName(string cueSheetName, float fadeOutTime);
		public void StopAll(float fadeOutTime, Action stoppedCallback = null);
		public void Pause(AudioPlayback playback, bool isPause, float fadeTime = 0f);
		public void Pause(int index, bool isPause, float fadeTime = 0f);
		public void PauseSpecifyIgnoreCue(List<string> ignoreCueNameList, bool isPause, float fadeTime = 0f);
		public void PauseAll(bool isPause, float fadeTime = 0f);
		public bool IsPlaying(RequestCueInfo info);
		public bool IsPlaying(AudioPlayback playback);
		public bool IsPlaying(int index);
		public bool IsPlayingAll();
		public bool IsPaused(RequestCueInfo info);
		public bool IsPaused(AudioPlayback playback);
		public bool IsPaused(int index);
		public bool IsPausedAll();
		public bool IsFading(RequestCueInfo info);
		public bool IsFading(AudioPlayback playback);
		public bool IsFading(int index);
		public void SetSelectorLabel(int index, string selector, string label);
		public void SetNextBlockId(AudioPlayback playback, int blockId);
		public void SetSourceVolume(AudioPlayback playback, float volume, float fadeTime = 0f);
		public void SetSourceVolume(int index, float volume, float fadeTime = 0f);
		public void SetSourceVolume(string cueName, float volume, float fadeTime = 0f);
		public void SetSpecifiedSourceVolume(List<string> targetCueNameList, float volume, float fadeTime = 0f);
		public void SetAllSpecifyIgnoreSourceVolume(List<string> ignoreCueNameList, float volume, float fadeTime);
		public void SetAllSourceVolume(float volume, float fadeTime = 0f);
		public float GetSourceVolume(AudioPlayback playback);
		public float GetSourceVolume(int index);
		public void SetPan3dAngle(int index, float angle);
		public void SetAisacControl(int index, string controlName, float controlValue);
		public void SetAisacControl(int index, uint controlId, float controlValue);
		public void SetAisacControlAll(string controlName, float controlValue);
		public void SetAisacControlAll(uint controlId, float controlValue);
		private string CreateSoundObjName(AudioPlayback playback);
		public int GetPlayingCount(int prioLevel);
	}
}
