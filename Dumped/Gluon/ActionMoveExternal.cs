using UnityEngine;

namespace Gluon
{
	public class ActionMoveExternal : ActionBase
	{
		private Vector3 velocity;

		private float duration;

		private float stepTime;

		private bool isExternalMoveAffected;

		public bool IsExternalMoveAffected => default(bool);

		public void SetParam(Vector3 startPos, Vector3 endPos, float duration)
		{
		}

		public override bool Update(float delta)
		{
			return default(bool);
		}

		protected override void OnFinish()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}
	}
}
