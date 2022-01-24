using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MultiMoveData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsMultiMove.TargetType _targetType;

		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsMultiMove.BaseType _baseType;

		[SerializeField]
		[HideInInspector]
		private int _fixedPosNum;

		[SerializeField]
		[HideInInspector]
		private Vector3[] _arrayFixedPos;

		[SerializeField]
		[HideInInspector]
		private float _moveSpeed;

		[SerializeField]
		[HideInInspector]
		private float _interval;

		[SerializeField]
		[HideInInspector]
		private float _turnTime;

		[SerializeField]
		[HideInInspector]
		private string _moveMotion;

		[SerializeField]
		[HideInInspector]
		private bool _isInvincible;

		[SerializeField]
		[HideInInspector]
		private bool _needsWarpOnClear;

		public Gluon.ActionPartsMultiMove.TargetType targetType => default(Gluon.ActionPartsMultiMove.TargetType);

		public Gluon.ActionPartsMultiMove.BaseType baseType => default(Gluon.ActionPartsMultiMove.BaseType);

		public int fixedPosNum => default(int);

		public Vector3[] arrayFixedPos => null;

		public float moveSpeed => default(float);

		public float interval => default(float);

		public float turnTime => default(float);

		public string moveMotion => null;

		public bool isInvincible => default(bool);

		public bool needsWarpOnClear => default(bool);
	}
}
