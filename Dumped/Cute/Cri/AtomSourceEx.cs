using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri.Audio;

namespace Cute.Cri
{
	public class AtomSourceEx : CriAtomSource
	{
		private Guid acbGuid;

		private int cueId;

		private PlayParameters param;

		private MinimumCueInfo cueInfo;

		private Action stoppedCallback;

		private float elapsedOffsetTime;

		private float lastRealTime;

		private bool isPrepared;

		private bool isFadeInPlay;

		private AtomSourceExFader fader;

		public bool IsInUse => default(bool);

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

		public PlayParameters Param => default(PlayParameters);

		public MinimumCueInfo CueInfo => null;

		public bool IsAnyFading => default(bool);

		public bool IsDuringFadeStop => default(bool);

		public float Pan3dAngle
		{
			get
			{
				return default(float);
			}
			set
			{
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
			set
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

		public void Stop(float fadeOutTime = 0f)
		{
		}

		public void Pause(bool isPause, float fadeTime)
		{
		}

		public void SetVolume(float toVolume, float fadeTime = 0f)
		{
		}

		public new bool IsPaused()
		{
			return default(bool);
		}

		public void SetSelectorLabel(string selector, string label)
		{
		}

		public void SetNextBlockId(int blockId)
		{
		}
	}
}
