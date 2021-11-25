using UnityEngine;

namespace Gluon
{
	public class FollowerStateIdle : IState<FollowerController>
	{
		private enum MoveState
		{
			Stop,
			Walk,
			Run,
			GiveUpRun,
			PathPending
		}

		private MoveState moveState;

		private float moveStateTimer;

		private float moveMargin;

		protected Vector3 targetPos;

		private Vector3 prevPos;

		private float stayTimer;

		protected bool updateTargetPos;

		public override void OnStateEnter()
		{
		}

		public override void OnStateExit()
		{
		}

		public override void OnStateUpdate()
		{
		}

		protected void UpdateMove(bool updateTargetPos, bool ignoreMoveMargin)
		{
		}

		protected void Stop()
		{
		}

		public void UpdateTargetPos()
		{
		}
	}
}
