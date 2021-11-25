using System.Collections.Generic;

namespace Gluon
{
	public class ActionHitRecord
	{
		private bool _isHitTargetRecording;

		private int _targetActionId;

		private List<CharacterBase> _actionHitOrGuardedTargetRecordList;

		private List<CharacterBase> _actionHitTargetRecordList;

		private int _hitOrGuardedTargetHitCounter;

		private CharacterBuffType _hitRecordTargetBuffType;

		public void BeginRecordTarget(int actionId, CharacterBuffType hitRecordTargetBuffType)
		{
		}

		public void EndRecordTarget()
		{
		}

		public void Clear()
		{
		}

		public bool IsContainsInTargetRecord(CharacterBase target, CollisionHitAttribute hitAttr)
		{
			return default(bool);
		}

		public void OnGuarded(CharacterBase target, CollisionHitAttribute hitAttr)
		{
		}

		public void OnHit(CharacterBase target, CollisionHitAttribute hitAttr)
		{
		}

		public static bool IsRecordTargetGroup(ActionTargetGroup targetGroup)
		{
			return default(bool);
		}

		public int GetHitOrGuardedTargetNum()
		{
			return default(int);
		}

		public int GetHitOrGuardedHitCounterNum()
		{
			return default(int);
		}

		public void AddHitOrGuardedTargetNumCounter(int addCount, CollisionHitAttribute httr)
		{
		}
	}
}
