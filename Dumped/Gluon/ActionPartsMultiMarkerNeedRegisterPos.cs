using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsMultiMarkerNeedRegisterPos : ActionPartsMarker
	{
		private readonly MultiMarkerNeedRegisterPositionData _partsData;

		private RandomXorshift _random;

		private RunActionRandomParameter _runActionParam;

		public ActionPartsMultiMarkerNeedRegisterPos(Gluon.ActionData.ActionParts resource)
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

		private void CreateMarkerAreaAnchorRandomOffsetAddAnchorPos(MultiMarkerNeedRegisterPositionData srcData)
		{
		}

		private void CreateMarkerMultiControlPlayers(MultiMarkerNeedRegisterPositionData srcData)
		{
		}

		protected void CreateMarker(MarkerData srcData, Vector3 position)
		{
		}
	}
}
