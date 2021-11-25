using System;
using System.Runtime.CompilerServices;

namespace Cute.Cri
{
	public class OnApplicationPauseBgmController
	{
		public static bool IsInitialized
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static event Action<bool> PauseMyselfBgmAction
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void Initialize()
		{
		}

		private static void OnApplicationPausePreProcess(bool pause)
		{
		}

		private static void OnApplicationPausePostProcess(bool pause)
		{
		}

		private static void PauseMyselfAudio(bool isPauseMyselfAudio)
		{
		}
	}
}
