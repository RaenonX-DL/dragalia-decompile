using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class CharacterEffect
	{
		private Dictionary<string, EffectObject> dict;

		private List<int> coexistAuraGroups;

		private const string deleteWithActionKeyPrefix = "DeleteWithAction_{0}_";

		private const string deleteWithSkillKeyPrefix = "DeleteWithSkill_";

		public bool isStopOnDeadState
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Play(string key, string effectName, GameObject go, Vector3 offset, Vector3 scale, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE, int trigger = 0, [Optional] CommonObjectStatus owner, int auraGroup = 0)
		{
		}

		public void Add(string key, EffectObject effectObject, bool isOverwrite = false)
		{
		}

		public void Remove(string key)
		{
		}

		public EffectObject IsPlaying(string key)
		{
			return null;
		}

		public void KickTrigger(string key, EffectManager.TriggerType type)
		{
		}

		public void KickTrigger(string key, int trig)
		{
		}

		private void KickTriggerByPrefix(string prefix, EffectManager.TriggerType type)
		{
		}

		public void DeleteEffectForActionFinish(int actionId)
		{
		}

		public void DeleteEffectForSkillFinish()
		{
		}

		public void Stop(string key)
		{
		}

		public void StopByPrefix(string prefix)
		{
		}

		public void StopAll()
		{
		}

		public void SetScale(string key, Vector3 scale)
		{
		}

		public void SetAttackSpeedScale(float scale)
		{
		}

		public void SetFollowPositionType(string key, EffectObject.FollowPosType posType)
		{
		}

		public void SetFollowRotationType(string key, EffectObject.FollowRotType followType)
		{
		}

		private void CheckAuraGroup()
		{
		}

		private void AddAnyList(List<int> list, int groupId)
		{
		}
	}
}
