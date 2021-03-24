/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public abstract class VolumeControllerBase : MonoBehaviour
	{
		// Fields
		protected AudioUtility.VolumeFader volumeFader;
	
		// Constructors
		protected VolumeControllerBase();
	
		// Methods
		private void Awake();
		public void SetActive(bool isActive);
		public abstract void RelateSoundGroup(SoundGroup soundGroup, params string[] nameArray);
		public abstract float GetVolume(string name);
		public abstract float GetVolume(SoundGroup soundGroup);
		public abstract void SetVolume(SoundGroup soundGroup, float volume);
		public abstract void FadeVolume(SoundGroup soundGroup, float toVolume, float fadeTime = 0f);
		public abstract bool GetMute(SoundGroup soundGroup);
		public abstract void SetMute(SoundGroup soundGroup, bool isMute);
		private void OnDestroy();
	}
}
