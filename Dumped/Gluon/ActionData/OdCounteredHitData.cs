using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class OdCounteredHitData : HitData
	{
		[SerializeField]
		[HideInInspector]
		private float _hitDuration;

		[SerializeField]
		[HideInInspector]
		private MarkerData _markerData;

		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsOdCounteredHit.IconBasePosition _iconBase;

		[SerializeField]
		[HideInInspector]
		private Vector3 _iconOffset;

		public float hitDuration => default(float);

		public MarkerData markerData => null;

		public Gluon.ActionPartsOdCounteredHit.IconBasePosition iconBase => default(Gluon.ActionPartsOdCounteredHit.IconBasePosition);

		public Vector3 iconOffset => default(Vector3);
	}
}
