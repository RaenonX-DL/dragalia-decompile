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
	public class CuteAudioSource
	{
		// Fields
		private GameObject cuteAudioSourceObj;
		private const int AtomSourceExCount = 2;
		private List<AtomSourceEx> sourceList;
		private int usingIndex;
	
		// Properties
		public string Name { get; set; }
		public PlayParameters Param { get; }
		public string CueSheet { get; set; }
		public string CueName { get; set; }
		public int CueId { get; set; }
		public CriAtomSource.Status Status { get; }
		public uint PlaybackId { get; }
		public float AtPlayStartTime { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public CuteAudioSource __4__this;
			public PlayParameters param;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _ResumeCrossFade_b__0();
		}
	
		// Constructors
		public CuteAudioSource(Transform transform);
	
		// Methods
		public void Destroy();
		public bool IsAnyInUse();
		public bool IsSameCue(RequestCueInfo info);
		public bool IsSamePlaybackId(AudioPlayback playback);
		public bool IsDivertibleCue(RequestCueInfo info);
		public CriAtomExPlayback Play(RequestCueInfo info, PlayParameters param, Action stoppedCallback = null);
		public CriAtomExPlayback PlayCrossFade(RequestCueInfo info, PlayParameters param, Action stoppedCallback = null);
		public CriAtomExPlayback ResumeCrossFade(PlayParameters param);
		public void Stop(float fadeOutTime = 0f);
		public void Pause(bool isPause, float fadeTime);
		public bool IsPlaying();
		public bool IsPaused();
		public bool IsStopped();
		public bool IsFading();
		public float GetVolume();
		public void SetVolume(float volume, float fadeTime);
		public void SetPan3dAngle(float angle);
		public void SetAisacControl(string controlName, float controlValue);
		public void SetAisacControl(uint controlId, float controlValue);
		public void SetSelectorLabel(string selector, string label);
		public void SetNextBlockId(int blockId);
	}
}
