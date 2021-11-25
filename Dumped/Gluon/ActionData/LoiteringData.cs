using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class LoiteringData : ActionParts.PartsData
	{
		public enum MoveTarget
		{
			random,
			repeatMoveFB,
			repeatMoveLR
		}

		public enum MoveType
		{
			walkMove,
			timeMove,
			turningMove
		}

		[SerializeField]
		[HideInInspector]
		private bool _isTurnedMove;

		[SerializeField]
		[HideInInspector]
		private float _distance;

		[SerializeField]
		[HideInInspector]
		private MoveTarget _moveTarget;

		[SerializeField]
		[HideInInspector]
		private MoveType _moveType;

		[SerializeField]
		[HideInInspector]
		private float _idleDurationSec;

		[SerializeField]
		[HideInInspector]
		private string _moveMotion;

		[SerializeField]
		[HideInInspector]
		private float _delayMoveMotionSec;

		[SerializeField]
		[HideInInspector]
		private float _moveDurationSec;

		[SerializeField]
		[HideInInspector]
		private bool _isLoop;

		public bool isTurnedMove => default(bool);

		public float distance => default(float);

		public MoveTarget moveTarget => default(MoveTarget);

		public MoveType moveType => default(MoveType);

		public float idleDurationSec => default(float);

		public string moveMotion => null;

		public float delayMoveMotionSec => default(float);

		public float moveDurationSec => default(float);

		public bool isLoop => default(bool);
	}
}
