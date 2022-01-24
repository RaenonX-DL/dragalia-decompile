using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class CharacterAbnormalStatus
	{
		protected CharacterBase owner;

		private Dictionary<int, AbnormalStatusBase> statusDic;

		protected List<int> removeList;

		private bool _isPause;

		protected string[] abnormalLabelTbl;

		private static readonly int hitDataMax;

		public List<CharacterHitData> hitDataList;

		private CharacterHitData[] hitData;

		private AbnormalStatusMultiPlayService _multiPlayService;

		private List<KeyValuePair<int, AbnormalStatusBase>> _tmpStatusList;

		public bool isStatusColorSet
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Dictionary<int, AbnormalStatusBase> StatusDic => null;

		public bool isPause
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void Initialize(CharacterBase owner)
		{
		}

		public void SetMultiPlayService(AbnormalStatusMultiPlayService multiPlayService)
		{
		}

		public virtual bool HasType(AbnormalStatusType type = AbnormalStatusType.NONE)
		{
			return default(bool);
		}

		public virtual void ClearType(AbnormalStatusType type)
		{
		}

		public void ReleaseKillerState(DamageCalculation.KillerState state)
		{
		}

		public virtual void Reset(bool isRestoreEffect = true)
		{
		}

		public void ResetStopAbnormal()
		{
		}

		private void ResetGroup(int group)
		{
		}

		public void SetHitData(ActionConditionElement elem, CollisionHitAttribute attr)
		{
		}

		public bool CheckHitData(ActionConditionElement elem, CollisionHitAttribute attr)
		{
			return default(bool);
		}

		public virtual bool AddDurationTime(CollisionHitAttribute attr)
		{
			return default(bool);
		}

		public virtual bool SetAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, CharacterBase.AbnormalStatusProbabilityResult probability, bool ignoreEA = false)
		{
			return default(bool);
		}

		public virtual void ReadSyncData(ChangeAbnormalStatus changeAbnormalStatusEvent)
		{
		}

		private AbnormalStatusBase AddNewAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, int newTypeGroup, AbnormalStatusType newType)
		{
			return null;
		}

		protected void DispText(int type, string text, int groupNo)
		{
		}

		public virtual void Update()
		{
		}

		public virtual CharacterBase GetAttacker(AbnormalStatusType type)
		{
			return null;
		}

		public virtual int GetProbability(AbnormalStatusType type)
		{
			return default(int);
		}

		public bool IsMinDurationSec(AbnormalStatusType type)
		{
			return default(bool);
		}

		public virtual float GetMinDurationTime(AbnormalStatusType type)
		{
			return default(float);
		}

		public virtual float GetDurationTime(AbnormalStatusType type)
		{
			return default(float);
		}

		public virtual void ReduceDurationTime(float time)
		{
		}

		public virtual void ApplyParalysisReaction()
		{
		}

		public virtual int GetEventProbability(AbnormalStatusType type)
		{
			return default(int);
		}

		public virtual float GetDamageCoefficient(AbnormalStatusType type)
		{
			return default(float);
		}

		public virtual int GetOverlapNum(AbnormalStatusType type)
		{
			return default(int);
		}

		public virtual void SetActiveInterval()
		{
		}

		public virtual void PlayEffect()
		{
		}

		public virtual void StopEffect()
		{
		}

		private int GetTypeGroup(AbnormalStatusType type)
		{
			return default(int);
		}

		private int GetTypePriority(AbnormalStatusType type)
		{
			return default(int);
		}

		public int GetTypeResistGain(AbnormalStatusType type)
		{
			return default(int);
		}

		protected int GetTypeDisplayPriority(AbnormalStatusType type)
		{
			return default(int);
		}

		public virtual void WriteSyncData(ref List<AbnormalStatusSyncData> outResult, ref short[] outResists)
		{
		}

		private bool NeedsChangeMaterial(AbnormalStatusType type)
		{
			return default(bool);
		}

		protected void SetAbnormalStatusDirty()
		{
		}

		public void CopySupportStatus(AbnormalStatusBase abs)
		{
		}

		public virtual bool ReleaseFreezeOnCollided()
		{
			return default(bool);
		}

		public virtual void OnDisconnectOwner()
		{
		}
	}
}
