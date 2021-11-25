using System.Collections.Generic;
using Cute.Cri.Audio;
using UnityEngine;

namespace Cute.Cri
{
	public class CuteAudioSourcePool
	{
		private List<CuteAudioSource> sourceList;

		private List<PrioritySetting> prioritySettingList;

		private Transform parentTransform;

		public int Count => default(int);

		public CuteAudioSource this[int index] => null;

		public CuteAudioSourcePool(Transform transform, int sourceCountMax)
		{
		}

		public void SetSourceCountMax(int sourceCountMax)
		{
		}

		public void SetPrioritySettingList(List<PrioritySetting> prioritySettingList)
		{
		}

		public void ClearPrioritySettingList()
		{
		}

		private PrioritySetting GetPriorityGroup(CuteAudioPriority priority)
		{
			return null;
		}

		public int GetSourceIndex(RequestCueInfo info, ref PlayParameters param)
		{
			return default(int);
		}

		public int FindSourceIndex(string cueName)
		{
			return default(int);
		}

		public int FindSourceIndex(RequestCueInfo info)
		{
			return default(int);
		}

		public int FindSourceIndex(AudioPlayback playback)
		{
			return default(int);
		}
	}
}
