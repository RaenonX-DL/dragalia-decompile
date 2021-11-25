using System;
using System.Collections.Generic;
using CriWare;
using UnityEngine;

namespace Cute.Cri
{
	public class TimeStretchController : MonoBehaviour
	{
		private const uint MemoryVoicePoolId = 100u;

		private const uint StreamingVoicePoolId = 101u;

		private const int MaxChannels = 2;

		private const int MaxSamplingRate = 96000;

		private CriAtomExVoicePool memoryVoicePool;

		private CriAtomExVoicePool streamingVoicePool;

		private List<Guid> timeStretchPlayerList;

		private string aisacName;

		private Func<float, float> aisacValueSetter;

		private static TimeStretchController instance;

		public static TimeStretchController Instance => null;

		public void SetAisacSetting(string name, Func<float, float> setter)
		{
		}

		public void Create(int memoryVoiceNum, int streamingVoiceNum)
		{
		}

		public void EnableTimeStretch(CriAtomExPlayer player, bool isStreamingFlag, float timeStretchRatio)
		{
		}

		public void DisableTimeStretch(CriAtomExPlayer player)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
