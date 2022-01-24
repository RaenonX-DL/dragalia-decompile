using System.Collections.Generic;
using Cute.Cri;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public static class InGameSound
	{
		public enum Priority
		{
			None = int.MaxValue,
			Voice_1 = 1,
			Voice_2 = 2,
			Voice_3 = 3,
			Voice_4 = 4,
			Voice_5 = 5,
			Voice_6 = 6,
			Voice_7 = 7,
			SE_1 = 1,
			SE_2 = 2,
			SE_3 = 3,
			SE_4 = 4,
			SE_5 = 5,
			SE_6 = 6
		}

		private static HashSet<string> registeredGroups;

		private static List<string> loadedGroups;

		private static CharacterBase skipPlayVoiceChara;

		private static Dictionary<string, string> replacedCueNameDic;

		public static void Clear()
		{
		}

		public static void RegisterLoadGroup(string soundGroupName)
		{
		}

		public static void LoadGroups()
		{
		}

		public static void ReleaseGroup()
		{
		}

		public static AudioPlayback Play(string cueName, Priority priority = Priority.None)
		{
			return default(AudioPlayback);
		}

		public static AudioPlayback Play(string cueName, Vector3 pos, Priority priority = Priority.None)
		{
			return default(AudioPlayback);
		}

		public static AudioPlayback Play(CharacterBase caster, string cueName, Vector3 pos, Priority priority = Priority.None)
		{
			return default(AudioPlayback);
		}

		public static AudioPlayback Play(CharacterBase caster, string cueName, Transform emitterTrans, Priority priority = Priority.None)
		{
			return default(AudioPlayback);
		}

		public static void Stop(AudioPlayback playBack, float fadeOutSec = 1f)
		{
		}

		public static void StopAll(SoundGroup soundGroup, float fadeOutSec = 1f)
		{
		}

		public static void PauseAll(SoundGroup soundGroup, bool isPause, float fadeOutSec = 1f)
		{
		}

		public static bool IsPlaying(AudioPlayback playBack)
		{
			return default(bool);
		}

		public static bool IsPlaying(string cueName)
		{
			return default(bool);
		}

		public static void RegisterSkipPlayVoiceChara(CharacterBase chara)
		{
		}

		private static bool IsOther(CharacterBase chara)
		{
			return default(bool);
		}

		private static float GetTimeStretchRatio(string cueName)
		{
			return default(float);
		}

		public static void RegisterReplacedCueName(string from, string to)
		{
		}

		public static void SetupReplacedCueName(QuestDataElement qde)
		{
		}

		public static void SetSoloPlayCueName(string[] cueNames)
		{
		}

		public static void SetSoloPlayForBGM(bool includeButtonSE)
		{
		}
	}
}
