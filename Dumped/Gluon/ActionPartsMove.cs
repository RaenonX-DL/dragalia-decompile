using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsMove : ActionParts
	{
		private readonly MoveData _partsData;

		private ActionMove _move;

		private RandomXorshift _random;

		private RunActionRandomParameter _runActionParam;

		public ActionPartsMove(Gluon.ActionData.ActionParts resource)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		public override void Clear()
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

		private Vector3 CalculateStartPosition()
		{
			return default(Vector3);
		}

		public override void Stop()
		{
		}

		private void SetupTeleport(out Vector3 position, out Vector3 direction)
		{
		}

		private void CalcMovePosition(Vector3 start, ref Vector3 end, ref float duration)
		{
		}
	}
}
