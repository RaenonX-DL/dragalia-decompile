using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ActionMarkerElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _HitAttribute;

		[SerializeField]
		private float _PrepareSec;

		[SerializeField]
		private ActionMarkerShape _ShapeType;

		[SerializeField]
		private float _NearRange;

		[SerializeField]
		private float _FarRange;

		[SerializeField]
		private int _Attach;

		[SerializeField]
		private int _IsSelf;

		[SerializeField]
		private int _IsImpactWait;

		[SerializeField]
		private int _IsAICognition;

		public int Id => default(int);

		public string HitAttribute => null;

		public float PrepareSec => default(float);

		public ActionMarkerShape ShapeType => default(ActionMarkerShape);

		public float NearRange => default(float);

		public float FarRange => default(float);

		public int Attach => default(int);

		public int IsSelf => default(int);

		public int IsImpactWait => default(int);

		public int IsAICognition => default(int);
	}
}
