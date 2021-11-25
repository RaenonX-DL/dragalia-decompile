using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MoveTargetData : ActionParts.PartsData
	{
		public enum AimType
		{
			Target,
			Marker,
			StageCenter,
			Pivot,
			Registered,
			RegisteredGround,
			CenterEnemy,
			Summoner
		}

		public enum TranslateType
		{
			Speed_2D,
			Time_2D,
			Speed_3D,
			Time_3D
		}

		[SerializeField]
		[HideInInspector]
		private AimType _aim;

		[SerializeField]
		[HideInInspector]
		private TranslateType _translate;

		[SerializeField]
		[HideInInspector]
		private float _moveSpeed;

		[SerializeField]
		[HideInInspector]
		private float _turnSpeed;

		[SerializeField]
		[HideInInspector]
		private bool _isFixPosition;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offset;

		public AimType aim => default(AimType);

		public TranslateType translate => default(TranslateType);

		public float moveSpeed => default(float);

		public float turnSpeed => default(float);

		public bool isFixPosition => default(bool);

		public Vector3 offset => default(Vector3);
	}
}
