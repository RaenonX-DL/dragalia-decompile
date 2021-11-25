using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CriWare;
using Cute.Cri.Audio;
using UnityEngine;

namespace Cute.Cri
{
	public class CuteAudioSource
	{
		private GameObject cuteAudioSourceObj;

		private const int AtomSourceExCount = 2;

		private List<AtomSourceEx> sourceList;

		private int usingIndex;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PlayParameters Param => default(PlayParameters);

		public string CueSheet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CueName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int CueId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public CriAtomSource.Status Status => default(CriAtomSource.Status);

		public uint PlaybackId => default(uint);

		public float AtPlayStartTime => default(float);

		public CuteAudioSource(Transform transform)
		{
		}

		public void Destroy()
		{
		}

		public bool IsAnyInUse()
		{
			return default(bool);
		}

		public bool IsSameCue(RequestCueInfo info)
		{
			return default(bool);
		}

		public bool IsSamePlaybackId(AudioPlayback playback)
		{
			return default(bool);
		}

		public bool IsDivertibleCue(RequestCueInfo info)
		{
			return default(bool);
		}

		public CriAtomExPlayback Play(RequestCueInfo info, PlayParameters param, [Optional] Action stoppedCallback)
		{
			return default(CriAtomExPlayback);
		}

		public CriAtomExPlayback PlayCrossFade(RequestCueInfo info, PlayParameters param, [Optional] Action stoppedCallback)
		{
			return default(CriAtomExPlayback);
		}

		public CriAtomExPlayback ResumeCrossFade(PlayParameters param)
		{
			return default(CriAtomExPlayback);
		}

		public void Stop(float fadeOutTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void Pause(bool isPause, float fadeTime)
		{
		}

		public bool IsPlaying()
		{
			return default(bool);
		}

		public bool IsPaused()
		{
			return default(bool);
		}

		public bool IsStopped()
		{
			return default(bool);
		}

		public bool IsFading()
		{
			return default(bool);
		}

		public float GetVolume()
		{
			return default(float);
		}

		public void SetVolume(float volume, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetPan3dAngle(float angle)
		{
		}

		public void SetPlayerAisacControl(string controlName, float controlValue)
		{
		}

		public void SetPlayerAisacControl(uint controlId, float controlValue)
		{
		}

		public void SetPlayerBusSendLevel(string busName, float toLevel, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetPlayerBusSendLevel(string busName, float fromLevel, float toLevel, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetSelectorLabel(SelectorInfo selectorInfo)
		{
		}

		public void SetNextBlockId(int blockId)
		{
		}

		public long GetTimeSyncedWithAudio()
		{
			return default(long);
		}
	}
}
