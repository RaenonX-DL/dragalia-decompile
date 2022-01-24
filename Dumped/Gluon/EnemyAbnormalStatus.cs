using System.Collections.Generic;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbnormalStatus : CharacterAbnormalStatus
	{
		private Dictionary<AbnormalStatusType, AbnormalStatusBase> _enemyAbnormals;

		private Dictionary<int, float> recoveryAbsCoolTimeDict;

		private Dictionary<AbnormalStatusType, List<AbnormalStatusSyncData>> _tmpNextAbnormalStatusDic;

		private CharacterColor.State nextColor;

		public Dictionary<AbnormalStatusType, AbnormalStatusBase> enemyAbnormals => null;

		public override bool SetAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, CharacterBase.AbnormalStatusProbabilityResult probability, bool ignoreEA = false)
		{
			return default(bool);
		}

		private AbnormalStatusBase AddNewAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, AbnormalStatusType newType, bool ignoreEA = false)
		{
			return null;
		}

		public bool EnableOverlap(AbnormalStatusType newType)
		{
			return default(bool);
		}

		public override void Reset(bool isRestoreEffect = true)
		{
		}

		public override void ClearType(AbnormalStatusType type)
		{
		}

		public override void Update()
		{
		}

		public override bool HasType(AbnormalStatusType type = AbnormalStatusType.NONE)
		{
			return default(bool);
		}

		public override CharacterBase GetAttacker(AbnormalStatusType type)
		{
			return null;
		}

		public override int GetProbability(AbnormalStatusType type)
		{
			return default(int);
		}

		public override float GetMinDurationTime(AbnormalStatusType type)
		{
			return default(float);
		}

		public override float GetDurationTime(AbnormalStatusType type)
		{
			return default(float);
		}

		public override void ReduceDurationTime(float time)
		{
		}

		public override void ApplyParalysisReaction()
		{
		}

		public override int GetEventProbability(AbnormalStatusType type)
		{
			return default(int);
		}

		public override float GetDamageCoefficient(AbnormalStatusType type)
		{
			return default(float);
		}

		public override int GetOverlapNum(AbnormalStatusType type)
		{
			return default(int);
		}

		public bool isHighestDisplayPriority(AbnormalStatusType type)
		{
			return default(bool);
		}

		public override void SetActiveInterval()
		{
		}

		public override void PlayEffect()
		{
		}

		public override void StopEffect()
		{
		}

		public override bool ReleaseFreezeOnCollided()
		{
			return default(bool);
		}

		public override bool AddDurationTime(CollisionHitAttribute attr)
		{
			return default(bool);
		}

		public override void ReadSyncData(ChangeAbnormalStatus changeAbnormalStatusEvent)
		{
		}

		public override void WriteSyncData(ref List<AbnormalStatusSyncData> outResult, ref short[] outResists)
		{
		}

		public override void OnDisconnectOwner()
		{
		}
	}
}
