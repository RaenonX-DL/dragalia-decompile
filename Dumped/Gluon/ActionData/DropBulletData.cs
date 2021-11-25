using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class DropBulletData : BulletWithMarkerData
	{
		[SerializeField]
		[HideInInspector]
		private bool _fixedAim;

		[SerializeField]
		[HideInInspector]
		private Vector3 _aimPosition;

		[SerializeField]
		[HideInInspector]
		private bool _useLegacyClearMarker;

		public bool fixedAim => default(bool);

		public Vector3 aimPosition => default(Vector3);

		public bool useLegacyClearMarker => default(bool);
	}
}
