/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterEffect
	{
		// Fields
		private Dictionary<string, EffectObject> dict;
		private List<int> coexistAuraGroups;
		[CompilerGenerated]
		private bool _isStopOnDeadState_k__BackingField;
		private const string deleteWithActionKeyPrefix = "DeleteWithAction_{0}_";
	
		// Properties
		public bool isStopOnDeadState { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public CharacterEffect();
	
		// Methods
		public void Play(string key, string effectName, GameObject go, Vector3 offset, Vector3 scale, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE, int trigger = 0, CommonObjectStatus owner = null, int auraGroup = 0);
		public void Add(string key, EffectObject effectObject);
		public void Remove(string key);
		public EffectObject IsPlaying(string key);
		public void KickTrigger(string key, EffectManager.TriggerType type);
		public void KickTrigger(string key, int trig);
		public void DeleteEffectForActionFinish(int actionId);
		public void Stop(string key);
		public void StopByPrefix(string prefix);
		public void StopAll();
		public void SetScale(string key, Vector3 scale);
		public void SetFollowPositionType(string key, EffectObject.FollowPosType posType);
		public void SetFollowRotationType(string key, EffectObject.FollowRotType followType);
		private void CheckAuraGroup();
		private void AddAnyList(List<int> list, int groupId);
	}
}
