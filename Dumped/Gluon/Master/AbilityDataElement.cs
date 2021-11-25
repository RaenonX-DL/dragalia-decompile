using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbilityDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private int _PartyPowerWeight;

		[SerializeField]
		private int _PartyPriority;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Details;

		[SerializeField]
		private int _ViewAbilityGroupId1;

		[SerializeField]
		private int _ViewAbilityGroupId2;

		[SerializeField]
		private int _ViewAbilityGroupId3;

		[SerializeField]
		private int _ViewAbilityGroupId21;

		[SerializeField]
		private int _ViewAbilityGroupId22;

		[SerializeField]
		private int _ViewAbilityGroupId23;

		[SerializeField]
		private string _AbilityIconName;

		[SerializeField]
		private int _UnitType;

		[SerializeField]
		private int _ElementalType;

		[SerializeField]
		private int _WeaponType;

		[SerializeField]
		private int _OnSkill;

		[SerializeField]
		private int _SkillOwner;

		[SerializeField]
		private int _SkillOwnerFlags;

		[SerializeField]
		private int _OwnerMode;

		[SerializeField]
		private int _BaseCrestGroupId;

		[SerializeField]
		private int _TriggerBaseCrestGroupCount;

		[SerializeField]
		private AbilityCondition _ConditionType;

		[SerializeField]
		private int _RequiredBuff;

		[SerializeField]
		private int _DisappearToEnableBuff;

		[SerializeField]
		private int _IncludeGameEnd;

		[SerializeField]
		private int _ExpireCondition;

		[SerializeField]
		private float _ConditionValue;

		[SerializeField]
		private float _ConditionValue2;

		[SerializeField]
		private string _ConditionString;

		[SerializeField]
		private int _NotResetWhenDie;

		[SerializeField]
		private int _BindCharaId;

		[SerializeField]
		private int _Probability;

		[SerializeField]
		private int _OccurenceNum;

		[SerializeField]
		private int _MaxCount;

		[SerializeField]
		private float _CoolTime;

		[SerializeField]
		private int _CoolTimeActivateType;

		[SerializeField]
		private AbilityTargetAction _TargetAction;

		[SerializeField]
		private int _IncludesEnhancedTargetActions;

		[SerializeField]
		private int _ShiftGroupId;

		[SerializeField]
		private string _HeadText;

		[SerializeField]
		private int _AbilityType1;

		[SerializeField]
		private int _VariousId1a;

		[SerializeField]
		private int _VariousId1b;

		[SerializeField]
		private int _VariousId1c;

		[SerializeField]
		private string _VariousId1str;

		[SerializeField]
		private int _AbilityLimitedGroupId1;

		[SerializeField]
		private AbilityTargetAction _TargetAction1;

		[SerializeField]
		private float _AbilityType1UpValue;

		[SerializeField]
		private int _AbilityType2;

		[SerializeField]
		private int _VariousId2a;

		[SerializeField]
		private int _VariousId2b;

		[SerializeField]
		private int _VariousId2c;

		[SerializeField]
		private string _VariousId2str;

		[SerializeField]
		private int _AbilityLimitedGroupId2;

		[SerializeField]
		private AbilityTargetAction _TargetAction2;

		[SerializeField]
		private float _AbilityType2UpValue;

		[SerializeField]
		private int _AbilityType3;

		[SerializeField]
		private int _VariousId3a;

		[SerializeField]
		private int _VariousId3b;

		[SerializeField]
		private int _VariousId3c;

		[SerializeField]
		private string _VariousId3str;

		[SerializeField]
		private int _AbilityLimitedGroupId3;

		[SerializeField]
		private AbilityTargetAction _TargetAction3;

		[SerializeField]
		private float _AbilityType3UpValue;

		public int Id => default(int);

		public int EventId => default(int);

		public int PartyPowerWeight => default(int);

		public int PartyPriority => default(int);

		public string Name => null;

		public string Details => null;

		public int ViewAbilityGroupId1 => default(int);

		public int ViewAbilityGroupId2 => default(int);

		public int ViewAbilityGroupId3 => default(int);

		public int ViewAbilityGroupId21 => default(int);

		public int ViewAbilityGroupId22 => default(int);

		public int ViewAbilityGroupId23 => default(int);

		public string AbilityIconName => null;

		public int UnitType => default(int);

		public int ElementalType => default(int);

		public int WeaponType => default(int);

		public int OnSkill => default(int);

		public int SkillOwner => default(int);

		public int SkillOwnerFlags => default(int);

		public int OwnerMode => default(int);

		public int BaseCrestGroupId => default(int);

		public int TriggerBaseCrestGroupCount => default(int);

		public AbilityCondition ConditionType => default(AbilityCondition);

		public int RequiredBuff => default(int);

		public int DisappearToEnableBuff => default(int);

		public int IncludeGameEnd => default(int);

		public int ExpireCondition => default(int);

		public float ConditionValue => default(float);

		public float ConditionValue2 => default(float);

		public string ConditionString => null;

		public int NotResetWhenDie => default(int);

		public int BindCharaId => default(int);

		public int Probability => default(int);

		public int OccurenceNum => default(int);

		public int MaxCount => default(int);

		public float CoolTime => default(float);

		public int CoolTimeActivateType => default(int);

		public AbilityTargetAction TargetAction => default(AbilityTargetAction);

		public int IncludesEnhancedTargetActions => default(int);

		public int ShiftGroupId => default(int);

		public string HeadText => null;

		public int AbilityType1 => default(int);

		public int VariousId1a => default(int);

		public int VariousId1b => default(int);

		public int VariousId1c => default(int);

		public string VariousId1str => null;

		public int AbilityLimitedGroupId1 => default(int);

		public AbilityTargetAction TargetAction1 => default(AbilityTargetAction);

		public float AbilityType1UpValue => default(float);

		public int AbilityType2 => default(int);

		public int VariousId2a => default(int);

		public int VariousId2b => default(int);

		public int VariousId2c => default(int);

		public string VariousId2str => null;

		public int AbilityLimitedGroupId2 => default(int);

		public AbilityTargetAction TargetAction2 => default(AbilityTargetAction);

		public float AbilityType2UpValue => default(float);

		public int AbilityType3 => default(int);

		public int VariousId3a => default(int);

		public int VariousId3b => default(int);

		public int VariousId3c => default(int);

		public string VariousId3str => null;

		public int AbilityLimitedGroupId3 => default(int);

		public AbilityTargetAction TargetAction3 => default(AbilityTargetAction);

		public float AbilityType3UpValue => default(float);
	}
}
