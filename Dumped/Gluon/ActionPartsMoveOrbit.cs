using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsMoveOrbit : ActionParts
	{
		private readonly MoveOrbitData _partsData;

		private ActionMoveOrbit _move;

		public ActionPartsMoveOrbit(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Stop()
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
