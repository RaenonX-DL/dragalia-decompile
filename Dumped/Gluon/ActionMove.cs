using UnityEngine;

namespace Gluon
{
	public class ActionMove : ActionMoveBase
	{
		protected Vector3 _startPos;

		protected Vector3 _endPos;

		protected Vector3 _distance;

		protected float _duration;

		private float _stepTime;

		private bool isUpdateXZ;

		private Rigidbody _rigidbody;

		private ActionMoveExecution moveExec;

		private ActionMoveGravity moveGravity;

		public ActionMove()
		{
		}

		public ActionMove(Vector3 startPos, Vector3 endPos, float duration, int property = 0)
		{
		}

		public void Startup(Vector3 startPos, Vector3 endPos, float duration, int property = 0)
		{
		}

		public void InitializeMoveGravity(float gravity)
		{
		}

		protected override void OnStart()
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Stop()
		{
		}

		protected override bool OnFixedUpdate(float delta)
		{
			return default(bool);
		}

		private void UpdateForcedTranslate(Vector3 targetPos)
		{
		}

		private bool CheckHitCollider(float delta, Vector3 pos)
		{
			return default(bool);
		}
	}
}
