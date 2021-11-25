using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cute.Cri
{
	public class UserOptionVolumeHolder
	{
		private class VolumeData
		{
			public float volume;

			public bool mute;
		}

		private static Dictionary<SoundGroup, VolumeData> volumeDataDict;

		public static event Action<SoundGroup, float> volumeChangedCallback
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

		public static event Action<SoundGroup, bool> muteChangedCallback
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

		public static float GetVolume(SoundGroup soundGroup)
		{
			return default(float);
		}

		public static void SetVolume(SoundGroup soundGroup, float volume)
		{
		}

		public static bool GetMute(SoundGroup soundGroup)
		{
			return default(bool);
		}

		public static void SetMute(SoundGroup soundGroup, bool mute)
		{
		}
	}
}
