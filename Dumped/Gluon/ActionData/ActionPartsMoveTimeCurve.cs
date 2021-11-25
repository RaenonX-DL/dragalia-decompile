using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsMoveTimeCurve : ActionParts
	{
		[SerializeField]
		private MoveTimeCurveData _data;

		public override PartsData data => null;
	}
}
