using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsMultiMarkerNeedRegisterPos : ActionParts
	{
		[SerializeField]
		private MultiMarkerNeedRegisterPositionData _data;

		public override PartsData data => null;
	}
}
