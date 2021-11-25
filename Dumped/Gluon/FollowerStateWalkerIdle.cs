using UnityEngine;
using UnityEngine.AI;

namespace Gluon
{
	public class FollowerStateWalkerIdle : IState<FollowerController>
	{
		private enum MoveState
		{
			Stop,
			Walk,
			Run,
			GiveUpRun,
			PathPending,
			GiveUpCatch,
			Catch,
			PassToChara
		}

		private MoveState moveState;

		private float moveStateTimer;

		private float moveMargin;

		protected Vector3 targetPos;

		private Vector3 prevPos;

		private float stayTimer;

		private Transform walkerTarget;

		private bool caught;

		private bool giveUp;

		private NavMeshPath checkPath;

		private const string stateName_Catch = "skill_C";

		private const string stateName_Pass = "skill_B";

		private const string stateName_Wait = "skill_D";

		private float timer;

		private const float TIMER_LIMIT = 10f;

		public override void OnStateEnter()
		{
		}

		public override void OnStateUpdate()
		{
		}

		protected void UpdateMove()
		{
		}

		protected void Stop()
		{
		}

		private void BackToChara()
		{
		}
	}
}
