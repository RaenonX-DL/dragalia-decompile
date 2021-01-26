/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AbnormalStatusBase
	{
		// Fields
		public static readonly float perfectResistRate;
		[CompilerGenerated]
		private AbnormalStatusType _type_k__BackingField;
		[CompilerGenerated]
		private CharacterBase _owner_k__BackingField;
		[CompilerGenerated]
		private CharacterBase _attacker_k__BackingField;
		[CompilerGenerated]
		private ActionConditionElement _data_k__BackingField;
		[CompilerGenerated]
		private DurationType _durationType_k__BackingField;
		[CompilerGenerated]
		private int _durationNum_k__BackingField;
		[CompilerGenerated]
		private float _durationTime_k__BackingField;
		[CompilerGenerated]
		private float _lifeTime_k__BackingField;
		[CompilerGenerated]
		private float _minDurationTime_k__BackingField;
		[CompilerGenerated]
		private float _intervalTime_k__BackingField;
		[CompilerGenerated]
		private bool _isActiveInterval_k__BackingField;
		[CompilerGenerated]
		private CharacterColor.State _colorState_k__BackingField;
		protected const string effectKey = "abnormalStatus";
		[CompilerGenerated]
		private string _effectName_k__BackingField;
		[CompilerGenerated]
		private string _cueName_k__BackingField;
		[CompilerGenerated]
		private float _baseSlipDamage_k__BackingField;
		[CompilerGenerated]
		private float _abilityRate_k__BackingField;
	
		// Properties
		public AbnormalStatusType type { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected CharacterBase owner { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterBase attacker { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ActionConditionElement data { [CompilerGenerated] get; [CompilerGenerated] set; }
		public DurationType durationType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int durationNum { [CompilerGenerated] get; [CompilerGenerated] set; }
		public virtual float durationTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public virtual float lifeTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float minDurationTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float intervalTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected bool isActiveInterval { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterColor.State colorState { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		protected string effectName { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected string cueName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int DataId { get; }
		public float baseSlipDamage { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float abilityRate { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		public enum DurationType
		{
			None = 0,
			Time = 1,
			Num = 2,
			Both = 3,
			UntilDead = 4
		}
	
		// Constructors
		public AbnormalStatusBase();
		static AbnormalStatusBase();
	
		// Methods
		public virtual void Setup(CharacterBase chara, CollisionHitAttribute attr, ActionConditionElement elem, bool overrideEffect);
		public void SetupAttacker(CharacterBase attacker);
		public virtual void Exit();
		public virtual void OnOverwrite(float sec, int num, float lifeSec, CharacterBase attacker);
		public virtual bool Update();
		protected void UpdateInterval();
		protected bool CheckPlayEffect();
		public virtual void PlayEffect();
		public void StopEffect();
		protected void PlaySE();
		protected virtual void OnEventInterval();
		protected float CalcSlipDamage(CollisionHitAttribute attr, ActionConditionElement elem);
		public virtual int BuildSlipDamage();
		public int GetProbability();
		public void ResetDurationTime();
		public void ResetIntervalTime();
		public void ReduceDurationTime(float time);
		public void ReduceDurationNum(int num = 1);
		public int GetEventProbability();
		public float GetDamageCoefficient();
		protected float GetExtention(AbnormalStatusType type, CharacterBase from, int actionId);
		public void SetActiveInterval();
		public virtual bool ReleaseFreezeOnCollided();
		protected void ChangeVisual(bool overrideEffect);
		public virtual int GetOverlapNum();
		public virtual void Addition(CollisionHitAttribute attr, ActionConditionElement elem);
		public virtual void GetShortestDurationTime(out float duration, out float life);
		protected float GetDeltaTime();
		public virtual void OnDisconnectOwner();
	}
}
