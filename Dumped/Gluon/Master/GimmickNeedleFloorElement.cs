using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickNeedleFloorElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _IntervalSec;

		[SerializeField]
		private string _ActionHitAttribute;

		[SerializeField]
		private float _Attack;

		[SerializeField]
		private int _RateDamage;

		public string Id => null;

		public float IntervalSec => default(float);

		public string ActionHitAttribute => null;

		public float Attack => default(float);

		public int RateDamage => default(int);
	}
}
