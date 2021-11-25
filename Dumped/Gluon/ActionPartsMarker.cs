using System.Runtime.InteropServices;
using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsMarker : ActionParts
	{
		private readonly MarkerData _partsData;

		public ActionPartsMarker(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		protected void CreateMarker(MarkerData markerData, [Optional] CommonObjectStatus target, int actionId = -1, [Optional] CommonObjectStatus targetObject)
		{
		}

		private ChargeMarker CreateMarkerToTarget(CommonObjectStatus target, MarkerData markerData)
		{
			return null;
		}
	}
}
