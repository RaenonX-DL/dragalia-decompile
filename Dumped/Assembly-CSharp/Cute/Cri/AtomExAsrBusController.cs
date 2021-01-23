/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class AtomExAsrBusController : VolumeControllerBase
	{
		// Fields
		private List<ControlData> controlDataList;
	
		// Properties
		public List<ControlData> ControlDataList { get; }
	
		// Nested types
		public class ControlData
		{
			// Fields
			public string name;
			public float volume;
			public bool mute;
			public SoundGroup soundGroup;
	
			// Constructors
			public ControlData(string name, float volume, bool mute, SoundGroup soundGroup);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public AtomExAsrBusController __4__this;
			public SoundGroup soundGroup;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal float _FadeVolume_b__0();
			internal void _FadeVolume_b__1(float volume);
		}
	
		// Constructors
		public AtomExAsrBusController();
	
		// Methods
		public override void RelateSoundGroup(SoundGroup soundGroup, params string[] busNameArray);
		public override float GetVolume(string busName);
		public override float GetVolume(SoundGroup soundGroup);
		public override void SetVolume(SoundGroup soundGroup, float volume);
		private void UpdateVolume(SoundGroup soundGroup);
		public override void FadeVolume(SoundGroup soundGroup, float toVolume, float fadeTime = 0f);
		public override bool GetMute(SoundGroup soundGroup);
		public override void SetMute(SoundGroup soundGroup, bool isMute);
		private void UpdateMute(SoundGroup soundGroup);
	}
}
