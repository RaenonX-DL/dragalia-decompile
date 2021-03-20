/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class AbilityDataElement : IMasterElement
	{
		// Fields
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
		private AbilityCondition _ConditionType;
		[SerializeField]
		private int _RequiredBuff;
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
		private AbilityTargetAction _TargetAction;
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
	
		// Properties
		public int Id { get; }
		public int EventId { get; }
		public int PartyPowerWeight { get; }
		public int PartyPriority { get; }
		public string Name { get; }
		public string Details { get; }
		public int ViewAbilityGroupId1 { get; }
		public int ViewAbilityGroupId2 { get; }
		public int ViewAbilityGroupId3 { get; }
		public int ViewAbilityGroupId21 { get; }
		public int ViewAbilityGroupId22 { get; }
		public int ViewAbilityGroupId23 { get; }
		public string AbilityIconName { get; }
		public int UnitType { get; }
		public int ElementalType { get; }
		public int WeaponType { get; }
		public int OnSkill { get; }
		public int SkillOwner { get; }
		public int SkillOwnerFlags { get; }
		public int OwnerMode { get; }
		public AbilityCondition ConditionType { get; }
		public int RequiredBuff { get; }
		public int ExpireCondition { get; }
		public float ConditionValue { get; }
		public float ConditionValue2 { get; }
		public string ConditionString { get; }
		public int NotResetWhenDie { get; }
		public int BindCharaId { get; }
		public int Probability { get; }
		public int OccurenceNum { get; }
		public int MaxCount { get; }
		public float CoolTime { get; }
		public AbilityTargetAction TargetAction { get; }
		public int ShiftGroupId { get; }
		public string HeadText { get; }
		public int AbilityType1 { get; }
		public int VariousId1a { get; }
		public int VariousId1b { get; }
		public int VariousId1c { get; }
		public string VariousId1str { get; }
		public int AbilityLimitedGroupId1 { get; }
		public AbilityTargetAction TargetAction1 { get; }
		public float AbilityType1UpValue { get; }
		public int AbilityType2 { get; }
		public int VariousId2a { get; }
		public int VariousId2b { get; }
		public int VariousId2c { get; }
		public string VariousId2str { get; }
		public int AbilityLimitedGroupId2 { get; }
		public AbilityTargetAction TargetAction2 { get; }
		public float AbilityType2UpValue { get; }
		public int AbilityType3 { get; }
		public int VariousId3a { get; }
		public int VariousId3b { get; }
		public int VariousId3c { get; }
		public string VariousId3str { get; }
		public int AbilityLimitedGroupId3 { get; }
		public AbilityTargetAction TargetAction3 { get; }
		public float AbilityType3UpValue { get; }
	
		// Constructors
		public AbilityDataElement();
	}
}
