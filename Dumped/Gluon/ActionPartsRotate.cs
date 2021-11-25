using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsRotate : ActionParts
	{
		private readonly RotateData _partsData;

		protected Quaternion _startEuler;

		protected Quaternion _endEuler;

		private float _stepTime;

		public ActionPartsRotate(Gluon.ActionData.ActionParts resource)
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
