using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class RoseTokenData : BulletData
	{
		[SerializeField]
		[HideInInspector]
		private int _generateNum;

		[SerializeField]
		[HideInInspector]
		private float _generateRadius;

		[SerializeField]
		[HideInInspector]
		private float _attackInterval;

		[SerializeField]
		[HideInInspector]
		private float _bloomSec;

		[SerializeField]
		[HideInInspector]
		private int _witherTrigger;

		[SerializeField]
		[HideInInspector]
		private float _witherActionRange;

		[SerializeField]
		[HideInInspector]
		private int _killCount;

		[SerializeField]
		[HideInInspector]
		private HitData _hitAttack;

		[SerializeField]
		[HideInInspector]
		private EffectData _effAttack;

		[SerializeField]
		[HideInInspector]
		private string _seAttack;

		[SerializeField]
		[HideInInspector]
		private HitData _hitHeal;

		[SerializeField]
		[HideInInspector]
		private EffectData _effHeal;

		[SerializeField]
		[HideInInspector]
		private string _seHeal;

		public int generateNum => default(int);

		public float generateRadius => default(float);

		public float attackInterval => default(float);

		public float bloomSec => default(float);

		public int witherTrigger => default(int);

		public float witherActionRange => default(float);

		public int killCount => default(int);

		public HitData hitAttack => null;

		public EffectData effAttack => null;

		public string seAttack => null;

		public HitData hitHeal => null;

		public EffectData effHeal => null;

		public string seHeal => null;
	}
}
