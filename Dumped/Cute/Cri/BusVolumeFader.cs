using System;
using System.Runtime.CompilerServices;

namespace Cute.Cri
{
	public class BusVolumeFader : IDisposable
	{
		private readonly FaderCore fader;

		public FadeStatus Status => default(FadeStatus);

		public string BusName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public float ElapsedLevel
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

		public BusVolumeFader(string busName)
		{
		}

		public void Dispose()
		{
		}

		public void Kill()
		{
		}

		private float GetVolume()
		{
			return default(float);
		}

		private void SetVolume(float level)
		{
		}

		public void FadeVolume(float toVolume, float fadeTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void FadeVolume(float fromVolume, float toVolume, float fadeTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}
	}
}
