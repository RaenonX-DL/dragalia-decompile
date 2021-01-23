/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbnormalStatus : CharacterAbnormalStatus
	{
		// Fields
		private Dictionary<AbnormalStatusType, AbnormalStatusBase> _enemyAbnormals;
		private Dictionary<AbnormalStatusType, List<AbnormalStatusSyncData>> _tmpNextAbnormalStatusDic;
		private CharacterColor.State nextColor;
	
		// Properties
		public Dictionary<AbnormalStatusType, AbnormalStatusBase> enemyAbnormals { get; }
	
		// Constructors
		public EnemyAbnormalStatus();
	
		// Methods
		public override bool SetAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, float dbgEnchant, bool ignoreEA = false);
		private AbnormalStatusBase AddNewAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, AbnormalStatusType newType, bool ignoreEA = false);
		public bool EnableOverlap(AbnormalStatusType newType);
		public override void Reset(bool isRestoreEffect = true);
		public override void ClearType(AbnormalStatusType type);
		public override void Update();
		public override bool HasType(AbnormalStatusType type = AbnormalStatusType.NONE);
		public override CharacterBase GetAttacker(AbnormalStatusType type);
		public override int GetProbability(AbnormalStatusType type);
		public override float GetMinDurationTime(AbnormalStatusType type);
		public override float GetDurationTime(AbnormalStatusType type);
		public override void ReduceDurationTime(float time);
		public override void ApplyParalysisReaction();
		public override int GetEventProbability(AbnormalStatusType type);
		public override float GetDamageCoefficient(AbnormalStatusType type);
		public override int GetOverlapNum(AbnormalStatusType type);
		public bool isHighestDisplayPriority(AbnormalStatusType type);
		public override void SetActiveInterval();
		public override void PlayEffect();
		public override void StopEffect();
		public override bool ReleaseFreezeOnCollided();
		public override void ReadSyncData(ChangeAbnormalStatus changeAbnormalStatusEvent);
		public override void WriteSyncData(ref List<AbnormalStatusSyncData> outResult, ref byte[] outResists);
		public override void OnDisconnectOwner();
	}
}
