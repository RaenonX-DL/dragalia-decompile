/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class InGameSound
	{
		// Fields
		private static HashSet<string> registeredGroups;
		private static List<string> loadedGroups;
		private static CharacterBase skipPlayVoiceChara;
		private static Dictionary<string, string> replacedCueNameDic;
	
		// Nested types
		public enum Priority
		{
			Voice_1 = 1,
			SE_1 = 1,
			Voice_2 = 2,
			SE_2 = 2,
			Voice_3 = 3,
			SE_3 = 3,
			Voice_4 = 4,
			SE_4 = 4,
			Voice_5 = 5,
			SE_5 = 5,
			Voice_6 = 6,
			SE_6 = 6,
			Voice_7 = 7,
			None = 2147483647
		}
	
		// Constructors
		static InGameSound();
	
		// Methods
		public static void Clear();
		public static void RegisterLoadGroup(string soundGroupName);
		public static void LoadGroups();
		public static void ReleaseGroup();
		public static AudioPlayback Play(string cueName, Priority priority = Priority.None);
		public static AudioPlayback Play(string cueName, Vector3 pos, Priority priority = Priority.None);
		public static AudioPlayback Play(CharacterBase caster, string cueName, Vector3 pos, Priority priority = Priority.None);
		public static AudioPlayback Play(CharacterBase caster, string cueName, Transform emitterTrans, Priority priority = Priority.None);
		public static void Stop(AudioPlayback playBack, float fadeOutSec = 1f);
		public static void StopAll(SoundGroup soundGroup, float fadeOutSec = 1f);
		public static void PauseAll(SoundGroup soundGroup, bool isPause, float fadeOutSec = 1f);
		public static bool IsPlaying(AudioPlayback playBack);
		public static bool IsPlaying(string cueName);
		public static void RegisterSkipPlayVoiceChara(CharacterBase chara);
		private static bool IsOther(CharacterBase chara);
		private static float GetTimeStretchRatio(string cueName);
		public static void RegisterReplacedCueName(string from, string to);
		public static void SetupReplacedCueName(QuestDataElement qde);
		public static void SetSoloPlayCueName(string[] cueNames);
	}
}
