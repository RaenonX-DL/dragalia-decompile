/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class TimeStretchController : MonoBehaviour
	{
		// Fields
		private const uint MemoryVoicePoolId = 100;
		private const uint StreamingVoicePoolId = 101;
		private const int MaxChannels = 2;
		private const int MaxSamplingRate = 96000;
		private CriAtomExVoicePool memoryVoicePool;
		private CriAtomExVoicePool streamingVoicePool;
		private List<Guid> timeStretchPlayerList;
		private string aisacName;
		private Func<float, float> aisacValueSetter;
		private static TimeStretchController instance;
	
		// Properties
		public static TimeStretchController Instance { get; }
	
		// Constructors
		public TimeStretchController();
		static TimeStretchController();
	
		// Methods
		public void SetAisacSetting(string name, Func<float, float> setter);
		public void Create(int memoryVoiceNum, int streamingVoiceNum);
		public void EnableTimeStretch(CriAtomExPlayer player, bool isStreamingFlag, float timeStretchRatio);
		public void DisableTimeStretch(CriAtomExPlayer player);
		private void OnDestroy();
	}
}
