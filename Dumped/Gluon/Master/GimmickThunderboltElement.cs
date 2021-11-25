using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickThunderboltElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _SensingRange;

		[SerializeField]
		private float _Range;

		[SerializeField]
		private float _IntervalSec;

		[SerializeField]
		private float _ReviveSec;

		[SerializeField]
		private int _TriggeringNumber;

		[SerializeField]
		private Gluon.ActionMarker _Marker;

		[SerializeField]
		private string _HitAttribute;

		[SerializeField]
		private float _Attack;

		[SerializeField]
		private int _RateDamage;

		public string Id => null;

		public float SensingRange => default(float);

		public float Range => default(float);

		public float IntervalSec => default(float);

		public float ReviveSec => default(float);

		public int TriggeringNumber => default(int);

		public Gluon.ActionMarker Marker => default(Gluon.ActionMarker);

		public string HitAttribute => null;

		public float Attack => default(float);

		public int RateDamage => default(int);
	}
}
