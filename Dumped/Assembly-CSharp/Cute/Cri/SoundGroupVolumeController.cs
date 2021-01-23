/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class SoundGroupVolumeController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private VolumeControllerBase volCtrlAtomExCategory;
		[SerializeField]
		private VolumeControllerBase volCtrlAtomExAsrBus;
		private Dictionary<ControlType, VolumeControllerBase> volCtrlDict;
		private ControlType volCtrlType;
		private bool isInitialized;
	
		// Properties
		private bool IsInitialized { get; }
	
		// Nested types
		public enum ControlType
		{
			AtomExCategory = 0,
			AtomExAsrBus = 1
		}
	
		// Constructors
		public SoundGroupVolumeController();
	
		// Methods
		public void Initialize(ControlType volCtrlType, Dictionary<SoundGroup, string[]> relateDataDict);
		public bool GetMute(SoundGroup soundGroup);
		public void SetMute(SoundGroup soundGroup, bool isMute);
		public float GetVolume(string name);
		public float GetVolume(SoundGroup soundGroup);
		public void SetVolume(SoundGroup soundGroup, float volume);
		public void FadeVolume(SoundGroup soundGroup, float toVolume, float fadeTime = 0f);
	}
}
