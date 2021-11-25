using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ExAbilityDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Details;

		[SerializeField]
		private int _Category;

		[SerializeField]
		private string _AbilityIconName;

		[SerializeField]
		private int _PartyPowerWeight;

		[SerializeField]
		private int _UnitType;

		[SerializeField]
		private Gluon.ElementalType _ElementalType;

		[SerializeField]
		private Gluon.WeaponType _WeaponType;

		[SerializeField]
		private AbilityCondition _ConditionType;

		[SerializeField]
		private float _ConditionValue;

		[SerializeField]
		private int _Probability;

		[SerializeField]
		private int _AbilityType1;

		[SerializeField]
		private int _VariousId1;

		[SerializeField]
		private AbilityTargetAction _TargetAction1;

		[SerializeField]
		private float _AbilityType1UpValue0;

		[SerializeField]
		private int _AbilityType2;

		[SerializeField]
		private int _VariousId2;

		[SerializeField]
		private AbilityTargetAction _TargetAction2;

		[SerializeField]
		private float _AbilityType2UpValue0;

		[SerializeField]
		private int _AbilityType3;

		[SerializeField]
		private int _VariousId3;

		[SerializeField]
		private AbilityTargetAction _TargetAction3;

		[SerializeField]
		private float _AbilityType3UpValue0;

		public int Id => default(int);

		public string Name => null;

		public string Details => null;

		public int Category => default(int);

		public string AbilityIconName => null;

		public int PartyPowerWeight => default(int);

		public int UnitType => default(int);

		public Gluon.ElementalType ElementalType => default(Gluon.ElementalType);

		public Gluon.WeaponType WeaponType => default(Gluon.WeaponType);

		public AbilityCondition ConditionType => default(AbilityCondition);

		public float ConditionValue => default(float);

		public int Probability => default(int);

		public int AbilityType1 => default(int);

		public int VariousId1 => default(int);

		public AbilityTargetAction TargetAction1 => default(AbilityTargetAction);

		public float AbilityType1UpValue0 => default(float);

		public int AbilityType2 => default(int);

		public int VariousId2 => default(int);

		public AbilityTargetAction TargetAction2 => default(AbilityTargetAction);

		public float AbilityType2UpValue0 => default(float);

		public int AbilityType3 => default(int);

		public int VariousId3 => default(int);

		public AbilityTargetAction TargetAction3 => default(AbilityTargetAction);

		public float AbilityType3UpValue0 => default(float);
	}
}
