using UnityEngine.EventSystems;

namespace Gluon
{
	public interface FacilityEventInterface : IEventSystemHandler
	{
		void OnBuildFocusAnimFinished();
	}
}
