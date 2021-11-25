using UnityEngine;

namespace Cute.Cri
{
	public abstract class VolumeControllerBase : MonoBehaviour
	{
		protected AudioUtility.VolumeFader volumeFader;

		private void Awake()
		{
		}

		public void SetActive(bool isActive)
		{
		}

		public abstract void RelateSoundGroup(SoundGroup soundGroup, string[] nameArray);

		public abstract float GetVolume(string name);

		public abstract float GetVolume(SoundGroup soundGroup);

		public abstract void SetVolume(SoundGroup soundGroup, float volume);

		public abstract void FadeVolume(SoundGroup soundGroup, float toVolume, float fadeTime = 0f);

		public abstract bool GetMute(SoundGroup soundGroup);

		public abstract void SetMute(SoundGroup soundGroup, bool isMute);

		private void OnDestroy()
		{
		}
	}
}
