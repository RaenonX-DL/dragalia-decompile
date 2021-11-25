using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickRollingStoneElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _Speed;

		[SerializeField]
		private float _FallAccel;

		[SerializeField]
		private float _RollIntervalSec;

		[SerializeField]
		private float _IntervalSec;

		[SerializeField]
		private int _EffectTrigger;

		[SerializeField]
		private string _ActionHitAttribute;

		[SerializeField]
		private float _Attack;

		[SerializeField]
		private int _RateDamage;

		public string Id => null;

		public float Speed => default(float);

		public float FallAccel => default(float);

		public float RollIntervalSec => default(float);

		public float IntervalSec => default(float);

		public int EffectTrigger => default(int);

		public string ActionHitAttribute => null;

		public float Attack => default(float);

		public int RateDamage => default(int);
	}
}
