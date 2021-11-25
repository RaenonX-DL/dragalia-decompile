using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public interface FortUIEventInterface : IEventSystemHandler
	{
		void OnPlayRightSlideIn();

		void OnPlayRightSlideOut();

		void OnRightSlideIn();

		void OnRightSlideOut();

		void OnBottomSlideIn();

		void OnBottomSlideOut();

		void OnFacilitySelectCancel(bool playBottomSlideOut);

		void OnFacilityVanished(GameObject gameObject);

		void OnFacilityStateChanged(ManagedFacilityDialogController.ExecutedFacilityAction executedFacilityAction);
	}
}
