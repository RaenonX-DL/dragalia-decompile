using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeWeaponElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _WeaponSkinId;

		[SerializeField]
		private Gluon.WeaponType _WeaponType;

		[SerializeField]
		private Gluon.ElementalType _ElementalType;

		[SerializeField]
		private int _StrengthParamGroupId;

		[SerializeField]
		private int _StrengthAbilityGroupId;

		[SerializeField]
		private int _StrengthSkillGroupId;

		[SerializeField]
		private int _IsDefaultWeapon;

		public int Id => default(int);

		public int WeaponSkinId => default(int);

		public Gluon.WeaponType WeaponType => default(Gluon.WeaponType);

		public Gluon.ElementalType ElementalType => default(Gluon.ElementalType);

		public int StrengthParamGroupId => default(int);

		public int StrengthAbilityGroupId => default(int);

		public int StrengthSkillGroupId => default(int);

		public int IsDefaultWeapon => default(int);
	}
}
