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
	public class UserOptionVolumeHolder
	{
		// Fields
		[CompilerGenerated]
		private static Action<SoundGroup, float> volumeChangedCallback;
		[CompilerGenerated]
		private static Action<SoundGroup, bool> muteChangedCallback;
		private static Dictionary<SoundGroup, VolumeData> volumeDataDict;
	
		// Events
		public static event Action<SoundGroup, float> volumeChangedCallback {
			add;
			remove;
		}
		public static event Action<SoundGroup, bool> muteChangedCallback {
			add;
			remove;
		}
	
		// Nested types
		private class VolumeData
		{
			// Fields
			public float volume;
			public bool mute;
	
			// Constructors
			public VolumeData();
		}
	
		// Constructors
		public UserOptionVolumeHolder();
		static UserOptionVolumeHolder();
	
		// Methods
		public static float GetVolume(SoundGroup soundGroup);
		public static void SetVolume(SoundGroup soundGroup, float volume);
		public static bool GetMute(SoundGroup soundGroup);
		public static void SetMute(SoundGroup soundGroup, bool mute);
	}
}
