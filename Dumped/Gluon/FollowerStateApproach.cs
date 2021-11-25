using UnityEngine;

namespace Gluon
{
	public class FollowerStateApproach : IState<FollowerController>
	{
		private float elapsedSec;

		private bool playedEffect;

		public override void OnStateEnter()
		{
		}

		public override void OnStateExit()
		{
		}

		public override void OnStateUpdate()
		{
		}

		private bool CheckBRItem()
		{
			return default(bool);
		}

		private void SetMoveTarget(Vector3 moveTarget)
		{
		}
	}
}
