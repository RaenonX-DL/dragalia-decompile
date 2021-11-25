using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickBlastFloorElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _IntervalSec;

		[SerializeField]
		private float _SignsSec;

		[SerializeField]
		private float _FlameSec;

		[SerializeField]
		private float _HitInterval;

		[SerializeField]
		private string _ActionHitAttribute;

		[SerializeField]
		private float _Attack;

		[SerializeField]
		private int _RateDamage;

		public string Id => null;

		public float IntervalSec => default(float);

		public float SignsSec => default(float);

		public float FlameSec => default(float);

		public float HitInterval => default(float);

		public string ActionHitAttribute => null;

		public float Attack => default(float);

		public int RateDamage => default(int);
	}
}
