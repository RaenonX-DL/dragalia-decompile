using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectEventSubPage : QuestSelectEventPageBase, ICustomMessage
	{
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;

		[SerializeField]
		private QuestSelectEventShortCut questSelectEventShortCut;

		[SerializeField]
		private TabBase questMultiTab;

		public QuestSupportCanvas.PlayType playType;

		private int baseQuestGroupId;

		private QuestEventBannerPage bannerPage;

		private QuestSelectInstance.QuestEventData eventData;

		private Dictionary<int, float> scrollValueDic;

		private List<EventMenuCell> eventMenuCellList;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		private void OpenDefaultTab(int baseQuestGroupId)
		{
		}

		public void OnSelectedTab(int num)
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		private void CreateEventList(QuestSelectInstance.QuestEventData eventData)
		{
		}

		public void OnBackButtonTouched()
		{
		}

		public void OnMainQuestButtonTouched()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private void TutorialReleaseSubdue()
		{
		}

		private IEnumerator TutorialReleaseSubdueCoroutine()
		{
			return null;
		}
	}
}
