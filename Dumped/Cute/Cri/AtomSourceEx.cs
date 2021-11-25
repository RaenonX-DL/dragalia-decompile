using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriWare;
using Cute.Cri.Audio;

namespace Cute.Cri
{
	public class AtomSourceEx : CriAtomSource
	{
		private Guid acbGuid;

		private Action stoppedCallback;

		private float elapsedOffsetTime;

		private float lastRealTime;

		private bool isPrepared;

		private bool isFadeInPlay;

		private PlayerVolumeFader playerVolumeFader;

		public bool IsInUse => default(bool);

		public int CueId
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

		public CriAtomExPlayback Playback
		{
			[CompilerGenerated]
			get
			{
				return default(CriAtomExPlayback);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PlayParameters Param
		{
			[CompilerGenerated]
			get
			{
				return default(PlayParameters);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MinimumCueInfo CueInfo
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool IsAnyFading => default(bool);

		public bool IsDuringFadeStop => default(bool);

		public Dictionary<string, PlayerBusSendFader> PlayerBusSendFaderDict
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public float AtPlayStartTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void InternalInitialize()
		{
		}

		protected override void InternalFinalize()
		{
		}

		public CriAtomExPlayback Play(RequestCueInfo info, PlayParameters param, [Optional] Action stoppedCallback)
		{
			return default(CriAtomExPlayback);
		}

		private void SetDspTimeStretchRatio()
		{
		}

		private bool SetCue(RequestCueInfo requestCueInfo)
		{
			return default(bool);
		}

		private void SetParameter()
		{
		}

		public void Update()
		{
		}

		private void UpdatePlayingStateObserver()
		{
		}

		public void StopPlayer(bool ignoresReleaseTime)
		{
		}

		public void Stop(float fadeOutTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void Pause(bool isPause, float fadeTime)
		{
		}

		public void SetVolume(float toVolume, float fadeTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public new bool IsPaused()
		{
			return default(bool);
		}

		public void SetPlayerBusSendLevel(string busName, float toLevel, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void SetPlayerBusSendLevel(string busName, float fromLevel, float toLevel, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		private void ResetPlayerBusSendLevel()
		{
		}

		public void SetSelectorLabel(SelectorInfo selectorInfo)
		{
		}

		public void SetNextBlockId(int blockId)
		{
		}
	}
}
