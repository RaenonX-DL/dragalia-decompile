namespace Gluon
{
	public class ActionBlastRecovery : ActionBase
	{
		private enum State
		{
			None,
			Fall,
			Landing
		}

		private State state;

		private ActionMoveGravity blastMove;

		private DungeonObjectContact dunObjContact;

		public void SetParam(float gravity, float angle, bool isCtrl)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}
	}
}
