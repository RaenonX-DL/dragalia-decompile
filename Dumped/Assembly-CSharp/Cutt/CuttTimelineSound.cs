/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineSound
	{
		// Fields
		private CuttTimelineKeySoundDataList _keys;
		private CuttTimelineControl _timelineControl;
		private GameObject soundObject;
		private AudioPlayback playback;
		private int lastPlayFrame;
		private bool isEndStop;
		private int endStopFadeFrame;
		private const float stopAllTime = 0.5f;
	
		// Constructors
		public CuttTimelineSound();
	
		// Methods
		public void Initialize(CuttTimelineKeySoundDataList keys, CuttTimelineControl timelineControl);
		public void Reset();
		public void Stop(int fadeFrame, bool stopStoryVoice = false);
		private void Stop(bool stopStoryVoice = false);
		public static void StopAll();
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
		private bool IsVoice(string cueName);
		private void SetStoryAudioPlayback(AudioPlayback audioPlayback, string cueName);
		private string GetReplaceSoundLabel(string label);
	}
}
