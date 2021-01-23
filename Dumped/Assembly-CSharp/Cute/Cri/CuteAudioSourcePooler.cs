/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cute.Cri.Audio;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class CuteAudioSourcePooler
	{
		// Fields
		private List<CuteAudioSource> sourceList;
		private List<PrioritySetting> prioritySettingList;
		private Transform parentTransform;
	
		// Properties
		public int Count { get; }
		public CuteAudioSource this[int index] { get => default; }
	
		// Constructors
		public CuteAudioSourcePooler(Transform transform, int sourceCountMax);
	
		// Methods
		public void SetSourceCountMax(int sourceCountMax);
		public void SetPrioritySettingList(List<PrioritySetting> prioritySettingList);
		private PrioritySetting GetPriorityGroup(CuteAudioPriority priority);
		public int GetSourceIndex(RequestCueInfo info, ref PlayParameters param);
		public int FindSourceIndex(string cueName);
		public int FindSourceIndex(RequestCueInfo info);
		public int FindSourceIndex(AudioPlayback playback);
	}
}
