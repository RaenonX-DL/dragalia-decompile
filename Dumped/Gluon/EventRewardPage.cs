using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventRewardPage : EventQuestPageBase, ICustomMessage
	{
		private TabViewBase tabView;

		[SerializeField]
		private EventRewardTabButton[] tabButtons;

		[SerializeField]
		private Button receiveAllButton;

		[SerializeField]
		private EventRewardCtrl bronzeCtrl;

		[SerializeField]
		private EventRewardCtrl silverCtrl;

		[SerializeField]
		private EventRewardCtrl goldCtrl;

		private bool isInited;

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void SetTabPage(int index)
		{
		}

		public void UpdateReceivedItems()
		{
		}

		public void UpdateReceiveButtonInformation()
		{
		}

		public void SetContent()
		{
		}

		public void OnBackButtonTouched()
		{
		}

		public void UpdateTabButtons(int curIndex)
		{
		}

		public void OnReceipAllButtonTouched()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private IEnumerator WaitForInitialzing(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
			return null;
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}
	}
}
