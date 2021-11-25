using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsTanatosHourglassDrop : ActionParts
	{
		private readonly TanatosHourglassDropData _partsData;

		private ActionMove _move;

		private int _movePointIndex;

		public ActionPartsTanatosHourglassDrop(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		protected override bool OnFixedUpdate(float delta)
		{
			return default(bool);
		}

		public override void Stop()
		{
		}
	}
}
