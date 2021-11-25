using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MultiDropBulletRegisteredPosData : DropBulletData
	{
		[SerializeField]
		[HideInInspector]
		private float _generateInterval;

		[SerializeField]
		[HideInInspector]
		private float[] _markerDelay;

		public static int MARKER_DELAY_MAX;

		public float generateInterval => default(float);

		public float[] markerDelay => null;
	}
}
