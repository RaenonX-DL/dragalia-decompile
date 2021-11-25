using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EditSkillCharaOffsetElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EditSkillRelationId;

		[SerializeField]
		private Gluon.WeaponType _TargetWeaponType;

		[SerializeField]
		private float _SpOffset;

		[SerializeField]
		private float _StrengthOffset;

		[SerializeField]
		private float _RecoveryOffset;

		[SerializeField]
		private float _BuffDebuffOffset;

		public int Id => default(int);

		public int EditSkillRelationId => default(int);

		public Gluon.WeaponType TargetWeaponType => default(Gluon.WeaponType);

		public float SpOffset => default(float);

		public float StrengthOffset => default(float);

		public float RecoveryOffset => default(float);

		public float BuffDebuffOffset => default(float);
	}
}
