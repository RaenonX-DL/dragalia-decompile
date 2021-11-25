using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsRotateTimeCurve : ActionParts
	{
		private readonly RotateTimeCurveData _partsData;

		protected Quaternion _startRotation;

		private float _elapsed;

		public ActionPartsRotateTimeCurve(Gluon.ActionData.ActionParts resource)
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
