using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CharaModeDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ActionId;

		[SerializeField]
		private int _UniqueComboId;

		[SerializeField]
		private int _Skill1Id;

		[SerializeField]
		private int _Skill2Id;

		[SerializeField]
		private int _BurstAttackId;

		[SerializeField]
		private int _ChargeBreakId;

		[SerializeField]
		private int _DashAttack;

		[SerializeField]
		private int _DashOnAvoid;

		[SerializeField]
		private string _EffectName;

		[SerializeField]
		private int _EffectAuraId;

		[SerializeField]
		private int _EffectTrigger;

		[SerializeField]
		private string _EffectAttachName;

		[SerializeField]
		private string _IconName;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private int _GunMode;

		[SerializeField]
		private int _WeaponSkinId;

		public int Id => default(int);

		public int ActionId => default(int);

		public int UniqueComboId => default(int);

		public int Skill1Id => default(int);

		public int Skill2Id => default(int);

		public int BurstAttackId => default(int);

		public int ChargeBreakId => default(int);

		public int DashAttack => default(int);

		public int DashOnAvoid => default(int);

		public string EffectName => null;

		public int EffectAuraId => default(int);

		public int EffectTrigger => default(int);

		public string EffectAttachName => null;

		public string IconName => null;

		public string Text => null;

		public int GunMode => default(int);

		public int WeaponSkinId => default(int);
	}
}
