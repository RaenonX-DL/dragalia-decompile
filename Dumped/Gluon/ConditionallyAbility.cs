using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class ConditionallyAbility
	{
		public enum ActivateType
		{
			None,
			Always,
			Moment,
			Expire
		}

		private bool _isChanged;

		private bool _isChangedForSync;

		private List<string> causeHitOccurrenceLabels;

		private AbilityMultiPlayService _multiPlayService;

		public AbilityDataElement ade
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

		public AbilityConst.UnitType ownerUnit
		{
			[CompilerGenerated]
			get
			{
				return default(AbilityConst.UnitType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int ownerId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ActivateType type
		{
			[CompilerGenerated]
			get
			{
				return default(ActivateType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int requireCnt
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int activateNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int expireCnt
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float coolTime
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

		public bool pauseCoolTime
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

		public bool triggerCoolTime
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

		public bool isAccumulation
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isRestriction
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isForceReset
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

		public bool isChanged
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isBuffAbility
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Dictionary<int, float>[] mixedBuffDict
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

		public bool Setup(AbilityDataElement ade, AbilityConst.UnitType unitType, int unitId, AbilityMultiPlayService multiPlayService)
		{
			return default(bool);
		}

		public static bool IsMomentActivateType(AbilityCondition conditionType)
		{
			return default(bool);
		}

		public static ActivateType GetActivateType(AbilityDataElement ade)
		{
			return default(ActivateType);
		}

		private void SetupHitOccurrence()
		{
		}

		public bool CheckHitOccurrence(CharacterBase owner, string hitLabel)
		{
			return default(bool);
		}

		public void Reset()
		{
		}

		public bool IsAchievedRequireCount(CharacterBase current, CharacterBase original, RemoveBuffReason buffDisappearedReason)
		{
			return default(bool);
		}

		public void UpdateCoolTime()
		{
		}

		public void Update()
		{
		}

		public bool IsMatchConditionAlways(CharacterBase current, CharacterBase original)
		{
			return default(bool);
		}

		private bool IsAbilityAlwaysDirty(CharacterBase owner, AbilityDataElement ade)
		{
			return default(bool);
		}

		private bool IsAbilityTypeAlwaysDirty(CharacterBase owner, AbilityCondition type)
		{
			return default(bool);
		}

		private bool IsAbilityTypeAlwaysDirty(CharacterBase owner, AbilityConst.Type type)
		{
			return default(bool);
		}

		public bool IsMatchCondition(CharacterBase current, CharacterBase original, RemoveBuffReason buffDisapperedReason = RemoveBuffReason.Other)
		{
			return default(bool);
		}

		public int GetRecoverySpSlot(CharacterBase owner, int defaultSlot)
		{
			return default(int);
		}

		private int GetAliveNumInParty(CharacterBase origin)
		{
			return default(int);
		}

		public bool IsExpire()
		{
			return default(bool);
		}

		public void AddActivateNum(CharacterBase owner)
		{
		}

		public void AddExpireCount()
		{
		}

		public bool IsCoolDown()
		{
			return default(bool);
		}

		private bool IsBuffAbility()
		{
			return default(bool);
		}

		public void WriteSyncData(AbilitySyncData outData)
		{
		}

		public void ReadSyncData(AbilitySyncData data)
		{
		}

		public int GetLoopNum()
		{
			return default(int);
		}

		public void SetConditionallyAbilityDirty()
		{
		}
	}
}
