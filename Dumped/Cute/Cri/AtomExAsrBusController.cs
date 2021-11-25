using System.Collections.Generic;

namespace Cute.Cri
{
	public class AtomExAsrBusController : VolumeControllerBase
	{
		public class ControlData
		{
			public string name;

			public float volume;

			public bool mute;

			public SoundGroup soundGroup;

			public ControlData(string name, float volume, bool mute, SoundGroup soundGroup)
			{
			}
		}

		private List<ControlData> controlDataList;

		public List<ControlData> ControlDataList => null;

		public override void RelateSoundGroup(SoundGroup soundGroup, string[] busNameArray)
		{
		}

		public override float GetVolume(string busName)
		{
			return default(float);
		}

		public override float GetVolume(SoundGroup soundGroup)
		{
			return default(float);
		}

		public override void SetVolume(SoundGroup soundGroup, float volume)
		{
		}

		private void UpdateVolume(SoundGroup soundGroup)
		{
		}

		public override void FadeVolume(SoundGroup soundGroup, float toVolume, float fadeTime = 0f)
		{
		}

		public override bool GetMute(SoundGroup soundGroup)
		{
			return default(bool);
		}

		public override void SetMute(SoundGroup soundGroup, bool isMute)
		{
		}

		private void UpdateMute(SoundGroup soundGroup)
		{
		}
	}
}
