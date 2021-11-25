using System;
using Gluon.Bullet;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class BindBulletData : BulletWithMarkerData
	{
		[SerializeField]
		[HideInInspector]
		private BindBulletObject.MoveType _moveType;

		[SerializeField]
		[HideInInspector]
		private Gluon.Bullet.ActionPartsBindBullet.GenerationPoint _generationPoint;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetPos;

		[SerializeField]
		[HideInInspector]
		private float _bindHeight;

		[SerializeField]
		[HideInInspector]
		private string _releaseHitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private int _releaseEffTrigger;

		[SerializeField]
		[HideInInspector]
		private float _bindingTime;

		public BindBulletObject.MoveType moveType => default(BindBulletObject.MoveType);

		public Gluon.Bullet.ActionPartsBindBullet.GenerationPoint generationPoint => default(Gluon.Bullet.ActionPartsBindBullet.GenerationPoint);

		public Vector3 offsetPos => default(Vector3);

		public float bindHeight => default(float);

		public string releaseHitAttrLabel => null;

		public int releaseEffTrigger => default(int);

		public float bindingTime => default(float);
	}
}
