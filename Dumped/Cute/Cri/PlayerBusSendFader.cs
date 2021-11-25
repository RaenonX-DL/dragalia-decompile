using System;
using System.Runtime.CompilerServices;
using CriWare;

namespace Cute.Cri
{
	public class PlayerBusSendFader : IDisposable
	{
		private FaderCore fader;

		private readonly CriAtomExPlayer player;

		public FadeStatus Status => default(FadeStatus);

		public bool IsStopped => default(bool);

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

		public PlayerBusSendFader(CriAtomExPlayer player, string busName)
		{
		}

		public void Dispose()
		{
		}

		public void RestSendLevel()
		{
		}

		private float GetSendLevel()
		{
			return default(float);
		}

		private void SetSendLevel(float level)
		{
		}

		public void FadeSendLevel(float toLevel, float fadeTime, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}

		public void FadeSendLevel(float fromLevel, float toLevel, float fadeTime = 0f, FadeCurve fadeCurve = FadeCurve.Linear)
		{
		}
	}
}
