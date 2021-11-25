using System.Collections;

namespace Gluon
{
	public class PlayerStateDead : IState<PlayerCtrl>
	{
		public override void OnStateEnter()
		{
		}

		public override void OnStateUpdate()
		{
		}

		private IEnumerator Revive()
		{
			return null;
		}

		private void Reraise()
		{
		}
	}
}
