using System.Collections.Generic;
using Gluon.Master;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlPursuit : CUGCtrlBase
	{
		private class CharacterBuffTriggerReactionPursuit : CharacterBuffTriggerReactionBase
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

				public CollisionHitAttribute HitAttribute;

				public int ActionConditionId;

				public BuffExplosionDataElement BuffExplosionData;
			}

			private List<BuffRecord> _buffList;

			public override void Update()
			{
			}

			public override bool CanAcceptTrigger(ref CharacterAppendBuffTrigger trigger)
			{
				return default(bool);
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

			private void PlayEffect(CharacterBase target, CharacterBase appender, string effectName, int effectTrigger)
			{
			}
		}

		private CharacterBuffTriggerReactionPursuit reaction;

		private static int _nextTaskId;

		public static int CreateTaskId()
		{
			return default(int);
		}

		public static void ResetTaskId()
		{
		}

		public void Setup(EnemyCharacter enemy)
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		public static bool IsPursuitDebuff(int actionConditionId)
		{
			return default(bool);
		}
	}
}
