using UnityEngine;

namespace Gluon
{
	public class PlayerStateQuickTurn : PlayerStateBase
	{
		public enum Direction
		{
			Back,
			Right,
			Left
		}

		private float elapsedTime;

		private Vector3 subVelocity;

		private float time;

		public Direction direction;

		public override void OnStateEnter()
		{
		}

		public override void OnStateUpdate()
		{
		}

		public override void OnStateExit()
		{
		}
	}
}
