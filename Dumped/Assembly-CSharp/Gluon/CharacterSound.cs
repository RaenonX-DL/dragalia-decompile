/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterSound
	{
		// Fields
		private Dictionary<string, AudioPlayback> dict;
	
		// Constructors
		public CharacterSound();
	
		// Methods
		public void Play(string key, string soundName, Vector3 position, CharacterBase chara);
		public void Play(string key, string soundName, Transform emitterTrans, CharacterBase chara);
		public void Add(string key, AudioPlayback sound);
		public void Remove(string key);
		public void Stop(string key, float fadeOutTime = 1f);
		public void StopAll();
	}
}
