using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsLoitering : ActionParts
	{
		private enum State
		{
			idle,
			turn,
			moving,
			motionSync
		}

		private readonly LoiteringData _partsData;

		private Vector3 _targetPos;

		private Vector3 _basePos;

		private float _elapsedSec;

		private float _moveElapsedSec;

		private State _state;

		private Vector3 _orgFoward;

		private float _reprateDir;

		private Vector3 _orgPos;

		private RandomXorshift _random;

		private RunActionRandomParameter _runActionParam;

		public ActionPartsLoitering(Gluon.ActionData.ActionParts resource)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void UpdateMove(float delta)
		{
		}
	}
}
