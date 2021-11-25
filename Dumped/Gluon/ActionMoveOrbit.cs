using UnityEngine;

namespace Gluon
{
	public class ActionMoveOrbit : ActionInterval
	{
		private ActionMoveExecution moveExec;

		private GameObject _goAnchor;

		private GameObject _goMovePoint;

		private float _rotateSpeed;

		private float _winchSpeed;

		public ActionMoveOrbit(Vector3 anchor, float rotateSpeed, float winchSpeed)
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
