using System.Collections.Generic;
using UnityEngine;

namespace Cute.Cri
{
	public class SoundGroupVolumeController : MonoBehaviour
	{
		public enum ControlType
		{
			AtomExCategory,
			AtomExAsrBus
		}

		[SerializeField]
		private VolumeControllerBase volCtrlAtomExCategory;

		[SerializeField]
		private VolumeControllerBase volCtrlAtomExAsrBus;

		private Dictionary<ControlType, VolumeControllerBase> volCtrlDict;

		private ControlType volCtrlType;

		private bool isInitialized;

		private bool IsInitialized => default(bool);

		public void Initialize(ControlType volCtrlType, Dictionary<SoundGroup, string[]> relateDataDict)
		{
		}

		public bool GetMute(SoundGroup soundGroup)
		{
			return default(bool);
		}

		public void SetMute(SoundGroup soundGroup, bool isMute)
		{
		}

		public float GetVolume(string name)
		{
			return default(float);
		}

		public float GetVolume(SoundGroup soundGroup)
		{
			return default(float);
		}

		public void SetVolume(SoundGroup soundGroup, float volume)
		{
		}

		public void FadeVolume(SoundGroup soundGroup, float toVolume, float fadeTime = 0f)
		{
		}
	}
}
