using System.Collections.Generic;
using Gluon.ActionData;

namespace Gluon
{
	public class CharacterBuffTriggerReactionBomb : CharacterBuffTriggerReactionBase
	{
		private class BuffRecord
		{
			public enum States
			{
				WaitForRemove,
				Reserved
			}

			public States State;

			public CharacterBuff.BuffUnion TargetBuff;

			public int Damage;

			public CharacterBase TargetChara;

			public CharacterBase BuffAppender;
		}

		private ActionContainer _container;

		private RemoveBuffTriggerBombData _partsData;

		private CollisionHitAttribute _hitAttribute;

		private List<BuffRecord> _buffList;

		public CharacterBuffTriggerReactionBomb(int actionId, int skillId, string convertedHitAttrLabel, ActionContainer container, RemoveBuffTriggerBombData partsData)
		{
		}

		public override void Update()
		{
		}

		public override void OnAppendBuff(ref CharacterAppendBuffTrigger trigger)
		{
		}

		public override bool CanAcceptTrigger(ref CharacterRemoveBuffTrigger trigger)
		{
			return default(bool);
		}

		public override void OnRemoveBuff(ref CharacterRemoveBuffTrigger trigger)
		{
		}

		private void ExecRemoveBuffExtraDamage(BuffRecord record)
		{
		}

		private void PlayEffect(CharacterBase target, CharacterBase appender, string effectName)
		{
		}
	}
}
