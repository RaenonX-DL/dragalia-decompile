using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickBombObjElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _SensingRange;

		[SerializeField]
		private float _ReviveSec;

		[SerializeField]
		private Gluon.ActionMarker _Marker;

		[SerializeField]
		private string _ActionHitAttribute;

		[SerializeField]
		private float _Attack;

		[SerializeField]
		private int _RateDamage;

		public string Id => null;

		public float SensingRange => default(float);

		public float ReviveSec => default(float);

		public Gluon.ActionMarker Marker => default(Gluon.ActionMarker);

		public string ActionHitAttribute => null;

		public float Attack => default(float);

		public int RateDamage => default(int);
	}
}
