using System;
using Gluon.Bullet;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class PivotBulletData : BulletWithMarkerData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.Bullet.ActionPartsPivotBullet.BaseAxisType _baseAxis;

		[SerializeField]
		[HideInInspector]
		private Vector3 _anchorPos;

		[SerializeField]
		[HideInInspector]
		private float _pivotRadius;

		[SerializeField]
		[HideInInspector]
		private float _anchorForward;

		[SerializeField]
		[HideInInspector]
		private ActionCollisionPos _collisionPosId;

		[SerializeField]
		[HideInInspector]
		private float _winchSpeed;

		[SerializeField]
		[HideInInspector]
		private bool _useMarker;

		[SerializeField]
		[HideInInspector]
		private bool _isUpdateAnchorPos;

		[SerializeField]
		[HideInInspector]
		private bool _isFinishHitTrap;

		public Gluon.Bullet.ActionPartsPivotBullet.BaseAxisType baseAxis => default(Gluon.Bullet.ActionPartsPivotBullet.BaseAxisType);

		public Vector3 anchorPos => default(Vector3);

		public float pivotRadius => default(float);

		public float anchorForward => default(float);

		public ActionCollisionPos collisionPosId => default(ActionCollisionPos);

		public float winchSpeed => default(float);

		public bool useMarker => default(bool);

		public bool isUpdateAnchorPos => default(bool);

		public bool isFinishHitTrap => default(bool);
	}
}
