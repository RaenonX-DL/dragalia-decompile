using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public interface FortCameraEventInterface : IEventSystemHandler
	{
		void OnFacilityBuildFnishedAnimStart(GameObject focusTarget, Facility.eFacilityStatus status);

		void OnMainFacilityLevelUpFnishedAnimStart(GameObject focusTarget, FacilityViewController facilityViewController);
	}
}
