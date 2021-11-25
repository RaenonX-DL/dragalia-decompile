using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class EventRankingListPage : EventQuestPageBase
	{
		[SerializeField]
		private EventRankingListCanvas eventRankingListCanvas;

		[SerializeField]
		private EventRankingList eventRankingList;

		public Transform edgeToEdgeTransform;

		public override void OnPageBecomeActive(object data)
		{
		}

		private void GetRankingUserList()
		{
		}

		private void LoadAndOpenRankingUserList()
		{
		}

		public void OnRankingListScrollPosChanged(Vector2 scrollPos)
		{
		}

		private IEnumerator WaitSupportListOpenAnimationCoroutine()
		{
			return null;
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public void BackButtonPressed()
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		private void CellButtonPressed()
		{
		}
	}
}
