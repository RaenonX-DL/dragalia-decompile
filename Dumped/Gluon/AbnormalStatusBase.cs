using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class AbnormalStatusBase
	{
		public enum DurationType
		{
			None,
			Time,
			Num,
			Both,
			UntilDead
		}

		public static readonly float perfectResistRate;

		protected const string effectKey = "abnormalStatus";

		public AbnormalStatusType type
		{
			[CompilerGenerated]
			get
			{
				return default(AbnormalStatusType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected CharacterBase owner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CharacterBase attacker
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ActionConditionElement data
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DurationType durationType
		{
			[CompilerGenerated]
			get
			{
				return default(DurationType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int durationNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual float durationTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual float lifeTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float minDurationTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float intervalTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool isActiveInterval
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

		public CharacterColor.State colorState
		{
			[CompilerGenerated]
			get
			{
				return default(CharacterColor.State);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected string effectName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected string cueName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int DataId => default(int);

		public float baseSlipDamage
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float abilityRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual void Setup(CharacterBase chara, CollisionHitAttribute attr, ActionConditionElement elem, bool overrideEffect)
		{
		}

		public void SetupAttacker(CharacterBase attacker)
		{
		}

		public virtual void Exit()
		{
		}

		public virtual void OnOverwrite(float sec, int num, float lifeSec, CharacterBase attacker)
		{
		}

		public virtual bool Update()
		{
			return default(bool);
		}

		protected void UpdateInterval()
		{
		}

		protected bool CheckPlayEffect()
		{
			return default(bool);
		}

		public virtual void PlayEffect([Optional] GameObject node)
		{
		}

		public void StopEffect()
		{
		}

		protected void PlaySE()
		{
		}

		protected virtual void OnEventInterval()
		{
		}

		protected float CalcSlipDamage(CollisionHitAttribute attr, ActionConditionElement elem)
		{
			return default(float);
		}

		public virtual int BuildSlipDamage()
		{
			return default(int);
		}

		public int GetProbability()
		{
			return default(int);
		}

		public void ResetDurationTime()
		{
		}

		public void ResetIntervalTime()
		{
		}

		public void ReduceDurationTime(float time)
		{
		}

		public void ReduceDurationNum(int num = 1)
		{
		}

		public int GetEventProbability()
		{
			return default(int);
		}

		public float GetDamageCoefficient()
		{
			return default(float);
		}

		protected float GetExtention(AbnormalStatusType type, CharacterBase from, int actionId)
		{
			return default(float);
		}

		public void SetActiveInterval()
		{
		}

		public virtual bool ReleaseFreezeOnCollided()
		{
			return default(bool);
		}

		protected void ChangeVisual(bool overrideEffect)
		{
		}

		public virtual int GetOverlapNum()
		{
			return default(int);
		}

		public virtual void Addition(CollisionHitAttribute attr, ActionConditionElement elem)
		{
		}

		public virtual void GetShortestDurationTime(out float duration, out float life)
		{
		}

		public virtual void AddDurationTime(float time)
		{
		}

		protected float GetDeltaTime()
		{
			return default(float);
		}

		public virtual void OnDisconnectOwner()
		{
		}
	}
}
