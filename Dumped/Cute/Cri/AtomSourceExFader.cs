using System;

namespace Cute.Cri
{
	public class AtomSourceExFader : IDisposable
	{
		private enum FaderType
		{
			OnlyFade,
			StopWithFade,
			PauseWithFade
		}

		private readonly AudioUtility.VolumeFader[] faderArray;

		private AtomSourceEx sourceEx;

		private float volumeAtFadePuaseOn;

		public bool IsAnyFading => default(bool);

		public bool IsDuringFadeStop => default(bool);

		public AtomSourceExFader(AtomSourceEx sourceEx)
		{
		}

		public void Dispose()
		{
		}

		public void Reset()
		{
		}

		private void FadeVolume(FaderType type, float fromVolume, float toVolume, float fadeTime, Action startCallback, Action endCallback)
		{
		}

		private float VolumeGetter()
		{
			return default(float);
		}

		private void VolumeSetter(float elapsedVolume)
		{
		}

		public void VolumeFade(float toVolume, float fadeTime)
		{
		}

		public void StopWithVolumeFade(float fadeTime)
		{
		}

		private void StopFadeEndCallback()
		{
		}

		public void PauseWithVolumeFade(bool isPause, float fadeTime)
		{
		}

		private void FadePauseEndCallback()
		{
		}

		private void FadeResumeEndCallback()
		{
		}

		private void FadeResumeStartCallback()
		{
		}
	}
}
