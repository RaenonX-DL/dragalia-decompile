using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsMoveTarget : ActionParts
	{
		private MoveTargetData _partsData;

		private Vector3 _targetPos;

		private Vector3 _basePos;

		private float _moveDistance;

		private float _speedRate;

		private float _velocity;

		public ActionPartsMoveTarget(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
		{
		}

		protected override void OnFinish()
		{
		}

		private void UpdateTarget()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}
	}
}
