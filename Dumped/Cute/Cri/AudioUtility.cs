using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;

namespace Cute.Cri
{
	public static class AudioUtility
	{
		public class VolumeFader : IUpdatable, IDisposable
		{
			public enum FadeStatus
			{
				None,
				Started,
				Doing,
				Ended,
				Completed
			}

			private float startVolume;

			private float endVolume;

			private float fadeTime;

			private Func<float> volumeGetter;

			private Action<float> volumeSetter;

			private Action startCallback;

			private Action endCallback;

			private bool isFadeOut;

			private float lastRealTime;

			private float elapsedTime;

			public FadeStatus Status
			{
				[CompilerGenerated]
				get
				{
					return default(FadeStatus);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool Pause
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float ElapsedVolume
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

			public void Dispose()
			{
			}

			public void Do(float startVolume, float endVolume, float fadeTime, Func<float> volumeGetter, Action<float> volumeSetter, [Optional] Action startCallback, [Optional] Action endCallback)
			{
			}

			public void FastUpdate()
			{
			}

			public void Complete()
			{
			}

			public void Kill()
			{
			}
		}

		public static void DelayMethod(float waitTime, Action process)
		{
		}

		private static IEnumerator DelayMethodCoroutine(float waitTime, Action process)
		{
			return null;
		}

		public static void WaitForStop(CuteAudioSource cuteAudioSource, Action process)
		{
		}

		private static IEnumerator WaitForStopCoroutine(CuteAudioSource cuteAudioSource, Action process)
		{
			return null;
		}
	}
}
