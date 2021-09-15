/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterAbnormalStatus
	{
		// Fields
		protected CharacterBase owner;
		[CompilerGenerated]
		private bool _isStatusColorSet_k__BackingField;
		private Dictionary<int, AbnormalStatusBase> statusDic;
		protected List<int> removeList;
		private bool _isPause;
		protected string[] abnormalLabelTbl;
		private static readonly int hitDataMax;
		public List<CharacterHitData> hitDataList;
		private CharacterHitData[] hitData;
		private AbnormalStatusMultiPlayService _multiPlayService;
		private List<KeyValuePair<int, AbnormalStatusBase>> _tmpStatusList;
	
		// Properties
		public bool isStatusColorSet { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Dictionary<int, AbnormalStatusBase> StatusDic { get; }
		public bool isPause { get; set; }
	
		// Constructors
		public CharacterAbnormalStatus();
		static CharacterAbnormalStatus();
	
		// Methods
		public void Initialize(CharacterBase owner);
		public void SetMultiPlayService(AbnormalStatusMultiPlayService multiPlayService);
		public virtual bool HasType(AbnormalStatusType type = AbnormalStatusType.NONE);
		public virtual void ClearType(AbnormalStatusType type);
		public void ReleaseKillerState(DamageCalculation.KillerState state);
		public virtual void Reset(bool isRestoreEffect = true);
		public void ResetStopAbnormal();
		private void ResetGroup(int group);
		public void SetHitData(ActionConditionElement elem, CollisionHitAttribute attr);
		public bool CheckHitData(ActionConditionElement elem, CollisionHitAttribute attr);
		public virtual bool SetAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, CharacterBase.AbnormalStatusProbabilityResult probability, bool ignoreEA = false);
		public virtual void ReadSyncData(ChangeAbnormalStatus changeAbnormalStatusEvent);
		private AbnormalStatusBase AddNewAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, int newTypeGroup, AbnormalStatusType newType);
		protected void DispText(int type, string text, int groupNo);
		public virtual void Update();
		public virtual CharacterBase GetAttacker(AbnormalStatusType type);
		public virtual int GetProbability(AbnormalStatusType type);
		public bool IsMinDurationSec(AbnormalStatusType type);
		public virtual float GetMinDurationTime(AbnormalStatusType type);
		public virtual float GetDurationTime(AbnormalStatusType type);
		public virtual void ReduceDurationTime(float time);
		public virtual void ApplyParalysisReaction();
		public virtual int GetEventProbability(AbnormalStatusType type);
		public virtual float GetDamageCoefficient(AbnormalStatusType type);
		public virtual int GetOverlapNum(AbnormalStatusType type);
		public virtual void SetActiveInterval();
		public virtual void PlayEffect();
		public virtual void StopEffect();
		private int GetTypeGroup(AbnormalStatusType type);
		private int GetTypePriority(AbnormalStatusType type);
		public int GetTypeResistGain(AbnormalStatusType type);
		protected int GetTypeDisplayPriority(AbnormalStatusType type);
		public virtual void WriteSyncData(ref List<AbnormalStatusSyncData> outResult, ref short[] outResists);
		private bool NeedsChangeMaterial(AbnormalStatusType type);
		protected void SetAbnormalStatusDirty();
		public void CopySupportStatus(AbnormalStatusBase abs);
		public virtual bool ReleaseFreezeOnCollided();
		public virtual void OnDisconnectOwner();
	}
}
