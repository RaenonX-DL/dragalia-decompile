using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickDownElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _SensingRangeX;

		[SerializeField]
		private float _SensingRangeZ;

		[SerializeField]
		private string _ActionHitAttribute;

		[SerializeField]
		private Gluon.ActionMarker _Marker;

		[SerializeField]
		private float _Attack;

		[SerializeField]
		private int _RateDamage;

		public string Id => null;

		public float SensingRangeX => default(float);

		public float SensingRangeZ => default(float);

		public string ActionHitAttribute => null;

		public Gluon.ActionMarker Marker => default(Gluon.ActionMarker);

		public float Attack => default(float);

		public int RateDamage => default(int);
	}
}
