using UnityEngine;

namespace Gluon
{
	public class DmodeFafnirGrowthPage : DmodePageBase, ICustomMessage
	{
		[SerializeField]
		private DmodeServitorPassiveListController abilityListCtrl;

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private void OnBackButtonTouched()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
