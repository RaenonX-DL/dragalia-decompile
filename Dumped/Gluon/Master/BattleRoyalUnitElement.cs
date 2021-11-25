using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalUnitElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BaseCharaDataId;

		[SerializeField]
		private int _DefaultWeaponSkinId;

		[SerializeField]
		private int _WeaponDataId;

		[SerializeField]
		private int _DragonDataId;

		[SerializeField]
		private int _SkillId;

		[SerializeField]
		private int _Hp;

		[SerializeField]
		private int _Atk;

		[SerializeField]
		private float _MoveSpeedRatio;

		[SerializeField]
		private float _AtkRangeRatio;

		[SerializeField]
		private float _SkillItemAtkRatio;

		[SerializeField]
		private float _RecoverySpPerSec;

		[SerializeField]
		private float _RecoveryDpPerSec;

		[SerializeField]
		private float _MinDamageCoef;

		[SerializeField]
		private float _DecayStartDistance;

		[SerializeField]
		private float _DecayEndDistance;

		[SerializeField]
		private int _NeedsNumWeaponLv2;

		[SerializeField]
		private int _NeedsNumWeaponLv3;

		[SerializeField]
		private int _NeedsNumWeaponLv4;

		[SerializeField]
		private int _NeedsNumWeaponLv5;

		[SerializeField]
		private int _NeedsNumWeaponLv6;

		[SerializeField]
		private int _NeedsNumWeaponLv7;

		[SerializeField]
		private int _NeedsNumWeaponLv8;

		[SerializeField]
		private int _NeedsNumWeaponLv9;

		[SerializeField]
		private float _AtkRatioWeaponLv2;

		[SerializeField]
		private float _AtkRatioWeaponLv3;

		[SerializeField]
		private float _AtkRatioWeaponLv4;

		[SerializeField]
		private float _AtkRatioWeaponLv5;

		[SerializeField]
		private float _AtkRatioWeaponLv6;

		[SerializeField]
		private float _AtkRatioWeaponLv7;

		[SerializeField]
		private float _AtkRatioWeaponLv8;

		[SerializeField]
		private float _AtkRatioWeaponLv9;

		[SerializeField]
		private int _HpLv2;

		[SerializeField]
		private int _HpLv3;

		[SerializeField]
		private int _HpLv4;

		[SerializeField]
		private int _HpLv5;

		[SerializeField]
		private int _HpLv6;

		[SerializeField]
		private int _HpLv7;

		[SerializeField]
		private int _HpLv8;

		[SerializeField]
		private int _HpLv9;

		[SerializeField]
		private int _ItemAbility01;

		[SerializeField]
		private int _ItemAbility02;

		[SerializeField]
		private int _ItemAbility03;

		[SerializeField]
		private int _ItemAbility04;

		[SerializeField]
		private int _ItemAbility05;

		[SerializeField]
		private int _ItemAbility06;

		[SerializeField]
		private int _ItemAbility07;

		[SerializeField]
		private int _ItemAbility08;

		[SerializeField]
		private int _ItemAbility09;

		[SerializeField]
		private int _ItemAbility10;

		public int Id => default(int);

		public int BaseCharaDataId => default(int);

		public int DefaultWeaponSkinId => default(int);

		public int WeaponDataId => default(int);

		public int DragonDataId => default(int);

		public int SkillId => default(int);

		public int Hp => default(int);

		public int Atk => default(int);

		public float MoveSpeedRatio => default(float);

		public float AtkRangeRatio => default(float);

		public float SkillItemAtkRatio => default(float);

		public float RecoverySpPerSec => default(float);

		public float RecoveryDpPerSec => default(float);

		public float MinDamageCoef => default(float);

		public float DecayStartDistance => default(float);

		public float DecayEndDistance => default(float);

		public int NeedsNumWeaponLv2 => default(int);

		public int NeedsNumWeaponLv3 => default(int);

		public int NeedsNumWeaponLv4 => default(int);

		public int NeedsNumWeaponLv5 => default(int);

		public int NeedsNumWeaponLv6 => default(int);

		public int NeedsNumWeaponLv7 => default(int);

		public int NeedsNumWeaponLv8 => default(int);

		public int NeedsNumWeaponLv9 => default(int);

		public float AtkRatioWeaponLv2 => default(float);

		public float AtkRatioWeaponLv3 => default(float);

		public float AtkRatioWeaponLv4 => default(float);

		public float AtkRatioWeaponLv5 => default(float);

		public float AtkRatioWeaponLv6 => default(float);

		public float AtkRatioWeaponLv7 => default(float);

		public float AtkRatioWeaponLv8 => default(float);

		public float AtkRatioWeaponLv9 => default(float);

		public int HpLv2 => default(int);

		public int HpLv3 => default(int);

		public int HpLv4 => default(int);

		public int HpLv5 => default(int);

		public int HpLv6 => default(int);

		public int HpLv7 => default(int);

		public int HpLv8 => default(int);

		public int HpLv9 => default(int);

		public int ItemAbility01 => default(int);

		public int ItemAbility02 => default(int);

		public int ItemAbility03 => default(int);

		public int ItemAbility04 => default(int);

		public int ItemAbility05 => default(int);

		public int ItemAbility06 => default(int);

		public int ItemAbility07 => default(int);

		public int ItemAbility08 => default(int);

		public int ItemAbility09 => default(int);

		public int ItemAbility10 => default(int);
	}
}
