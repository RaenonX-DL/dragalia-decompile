using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickCurseboxElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _GenerationRange;

		[SerializeField]
		private float _CastingTime;

		[SerializeField]
		private float _Range;

		[SerializeField]
		private Gluon.ActionMarker _Marker;

		[SerializeField]
		private string _ActionHitAttribute;

		[SerializeField]
		private float _Attack;

		[SerializeField]
		private int _RateDamage;

		public string Id => null;

		public float GenerationRange => default(float);

		public float CastingTime => default(float);

		public float Range => default(float);

		public Gluon.ActionMarker Marker => default(Gluon.ActionMarker);

		public string ActionHitAttribute => null;

		public float Attack => default(float);

		public int RateDamage => default(int);
	}
}
