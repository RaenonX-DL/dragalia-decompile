/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class AtomSourceExFader : IDisposable
	{
		// Fields
		private readonly AudioUtility.VolumeFader[] faderArray;
		private AtomSourceEx sourceEx;
		private float volumeAtFadePuaseOn;
	
		// Properties
		public bool IsAnyFading { get; }
		public bool IsDuringFadeStop { get; }
	
		// Nested types
		private enum FaderType
		{
			OnlyFade = 0,
			StopWithFade = 1,
			PauseWithFade = 2
		}
	
		// Constructors
		public AtomSourceExFader(AtomSourceEx sourceEx);
	
		// Methods
		public void Dispose();
		public void Reset();
		private void FadeVolume(FaderType type, float fromVolume, float toVolume, float fadeTime, Action startCallback, Action endCallback);
		private float VolumeGetter();
		private void VolumeSetter(float elapsedVolume);
		public void VolumeFade(float toVolume, float fadeTime);
		public void StopWithVolumeFade(float fadeTime);
		private void StopFadeEndCallback();
		public void PauseWithVolumeFade(bool isPause, float fadeTime);
		private void FadePauseEndCallback();
		private void FadeResumeEndCallback();
		private void FadeResumeStartCallback();
	}
}
