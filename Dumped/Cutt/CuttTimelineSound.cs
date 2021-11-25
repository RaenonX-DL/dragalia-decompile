using Cute.Cri;
using UnityEngine;

namespace Cutt
{
	public class CuttTimelineSound
	{
		private CuttTimelineKeySoundDataList _keys;

		private CuttTimelineControl _timelineControl;

		private GameObject soundObject;

		private AudioPlayback playback;

		private int lastPlayFrame;

		private bool isEndStop;

		private int endStopFadeFrame;

		private const float stopAllTime = 0.5f;

		private int ignoreSkipEventFrame;

		public void Initialize(CuttTimelineKeySoundDataList keys, CuttTimelineControl timelineControl)
		{
		}

		public void Reset(int resetFrame)
		{
		}

		public void Stop(int fadeFrame, bool stopStoryVoice = false)
		{
		}

		private void Stop(bool stopStoryVoice = false)
		{
		}

		public static void StopAll()
		{
		}

		public void AlterUpdate(float currentTime, float targetFps, int currentFrame)
		{
		}

		private bool IsVoice(string cueName)
		{
			return default(bool);
		}

		private void SetStoryAudioPlayback(AudioPlayback audioPlayback, string cueName)
		{
		}

		private string GetReplaceSoundLabel(string label)
		{
			return null;
		}
	}
}
