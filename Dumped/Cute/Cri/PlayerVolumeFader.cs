using System;

namespace Cute.Cri
{
	public class PlayerVolumeFader : IDisposable
	{
		private enum FaderType
		{
			OnlyFade,
			StopWithFade,
			PauseWithFade
		}

		private readonly FaderCore[] faderArray;

		private readonly AtomSourceEx sourceEx;

		private float volumeAtFadePuaseOn;

		public bool IsAnyFading => default(bool);

		public bool IsDuringFadeStop => default(bool);

		public PlayerVolumeFader(AtomSourceEx sourceEx)
		{
		}

		public void Dispose()
		{
		}

		public void Reset()
		{
		}

		private void FadeVolume(FaderType type, float fromVolume, float toVolume, float fadeTime, Action startCallback, Action endCallback, FadeCurve fadeCurve)
		{
		}

		private float VolumeGetter()
		{
			return default(float);
		}

		private void VolumeSetter(float elapsedVolume)
		{
		}

		public void VolumeFade(float toVolume, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void StopWithVolumeFade(float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		private void StopFadeEndCallback()
		{
		}

		public void PauseWithVolumeFade(bool isPause, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
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
