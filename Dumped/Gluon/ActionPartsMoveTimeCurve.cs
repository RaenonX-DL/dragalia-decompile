using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsMoveTimeCurve : ActionParts
	{
		private readonly MoveTimeCurveData _partsData;

		private ActionMoveTimeCurve _move;

		public ActionPartsMoveTimeCurve(Gluon.ActionData.ActionParts resource)
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

		protected override bool OnFixedUpdate(float delta)
		{
			return default(bool);
		}

		private void CalcDynamicDistance(ref Vector3 distance)
		{
		}

		private void CalcDynamicHeight(ref float height)
		{
		}
	}
}
