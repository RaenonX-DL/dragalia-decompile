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
	public class ConditionallyAbility
	{
		// Fields
		[CompilerGenerated]
		private AbilityDataElement _ade_k__BackingField;
		[CompilerGenerated]
		private AbilityConst.UnitType _ownerUnit_k__BackingField;
		[CompilerGenerated]
		private int _ownerId_k__BackingField;
		[CompilerGenerated]
		private ActivateType _type_k__BackingField;
		[CompilerGenerated]
		private int _requireCnt_k__BackingField;
		[CompilerGenerated]
		private int _activateNum_k__BackingField;
		[CompilerGenerated]
		private int _expireCnt_k__BackingField;
		[CompilerGenerated]
		private float _coolTime_k__BackingField;
		[CompilerGenerated]
		private bool _pauseCoolTime_k__BackingField;
		[CompilerGenerated]
		private bool _isAccumulation_k__BackingField;
		[CompilerGenerated]
		private bool _isRestriction_k__BackingField;
		[CompilerGenerated]
		private bool _isForceReset_k__BackingField;
		private bool _isChanged;
		private bool _isChangedForSync;
		[CompilerGenerated]
		private bool _isBuffAbility_k__BackingField;
		[CompilerGenerated]
		private Dictionary<int, float>[] _mixedBuffDict_k__BackingField;
		private List<string> causeHitOccurrenceLabels;
		private AbilityMultiPlayService _multiPlayService;
	
		// Properties
		public AbilityDataElement ade { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public AbilityConst.UnitType ownerUnit { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int ownerId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ActivateType type { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int requireCnt { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int activateNum { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int expireCnt { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float coolTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool pauseCoolTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isAccumulation { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isRestriction { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isForceReset { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isChanged { get; set; }
		public bool isBuffAbility { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Dictionary<int, float>[] mixedBuffDict { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum ActivateType
		{
			None = 0,
			Always = 1,
			Moment = 2,
			Expire = 3
		}
	
		// Constructors
		public ConditionallyAbility();
	
		// Methods
		public bool Setup(AbilityDataElement ade, AbilityConst.UnitType unitType, int unitId, AbilityMultiPlayService multiPlayService);
		public static bool IsMomentActivateType(AbilityCondition conditionType);
		public static ActivateType GetActivateType(AbilityDataElement ade);
		private void SetupHitOccurrence();
		public bool CheckHitOccurrence(CharacterBase owner, string hitLabel);
		public void Reset();
		public bool IsAchievedRequireCount(CharacterBase current, CharacterBase original);
		public void UpdateCoolTime();
		public void Update();
		public bool IsMatchConditionAlways(CharacterBase current, CharacterBase original);
		private bool IsAbilityAlwaysDirty(CharacterBase owner, AbilityDataElement ade);
		private bool IsAbilityTypeAlwaysDirty(CharacterBase owner, AbilityCondition type);
		private bool IsAbilityTypeAlwaysDirty(CharacterBase owner, AbilityConst.Type type);
		public bool IsMatchCondition(CharacterBase current, CharacterBase original);
		public int GetRecoverySpSlot(CharacterBase owner, int defaultSlot);
		private int GetAliveNumInParty(CharacterBase origin);
		public bool IsExpire();
		public void AddActivateNum(CharacterBase owner);
		public void AddExpireCount();
		private bool IsBuffAbility();
		public void WriteSyncData(AbilitySyncData outData);
		public void ReadSyncData(AbilitySyncData data);
		public int GetLoopNum();
		private void SetConditionallyAbilityDirty();
	}
}
