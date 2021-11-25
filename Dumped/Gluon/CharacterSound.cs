using System.Collections.Generic;
using Cute.Cri;
using UnityEngine;

namespace Gluon
{
	public class CharacterSound
	{
		private Dictionary<string, AudioPlayback> dict;

		public void Play(string key, string soundName, Vector3 position, CharacterBase chara)
		{
		}

		public void Play(string key, string soundName, Transform emitterTrans, CharacterBase chara)
		{
		}

		public void Add(string key, AudioPlayback sound)
		{
		}

		public void Remove(string key)
		{
		}

		public void Stop(string key, float fadeOutTime = 1f)
		{
		}

		public void StopAll()
		{
		}
	}
}
