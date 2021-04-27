/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri.Audio;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class AtomSourceEx : CriAtomSource
	{
		// Fields
		private Guid acbGuid;
		private int cueId;
		[CompilerGenerated]
		private CriAtomExPlayback _Playback_k__BackingField;
		private PlayParameters param;
		private MinimumCueInfo cueInfo;
		private Action stoppedCallback;
		private float elapsedOffsetTime;
		private float lastRealTime;
		private bool isPrepared;
		private bool isFadeInPlay;
		private AtomSourceExFader fader;
		[CompilerGenerated]
		private float _AtPlayStartTime_k__BackingField;
	
		// Properties
		public bool IsInUse { get; }
		public int CueId { get; set; }
		public CriAtomExPlayback Playback { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public PlayParameters Param { get; }
		public MinimumCueInfo CueInfo { get; }
		public bool IsAnyFading { get; }
		public bool IsDuringFadeStop { get; }
		public float Pan3dAngle { get; set; }
		public float AtPlayStartTime { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public AtomSourceEx();
	
		// Methods
		protected override void InternalInitialize();
		protected override void InternalFinalize();
		public CriAtomExPlayback Play(RequestCueInfo info, PlayParameters param, Action stoppedCallback = null);
		private void SetDspTimeStretchRatio();
		private bool SetCue(RequestCueInfo requestCueInfo);
		private void SetParameter();
		public void Update();
		private void UpdatePlayingStateObserver();
		public void StopPlayer(bool ignoresReleaseTime);
		public void Stop(float fadeOutTime = 0f);
		public void Pause(bool isPause, float fadeTime);
		public void SetVolume(float toVolume, float fadeTime = 0f);
		public new bool IsPaused();
		public void SetSelectorLabel(string selector, string label);
		public void SetNextBlockId(int blockId);
	}
}
