using System;
using System.Collections;

namespace Cute.Cri
{
	public static class AudioUtility
	{
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
