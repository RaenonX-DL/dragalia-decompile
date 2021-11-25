using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectEventTopPage : QuestSelectEventPageBase, ICustomMessage
	{
		[SerializeField]
		private GameObject mainStoryMenuTitle;

		[SerializeField]
		private GameObject eventSpecialMenuTitle;

		[SerializeField]
		private GameObject eventNormalMenuTitle;

		[SerializeField]
		private GameObject eventChallengeMenuTitle;

		[SerializeField]
		private GameObject eventHighLevelMenuTitle;

		[SerializeField]
		private Transform disableMenuTitleParent;

		[SerializeField]
		private FlashPlayerManager flashPlayerManager;

		private int tutorialMultiBattleEventId;

		private int tutorialDragonBattleEventId;

		private int tutorialInterceptionBattleEventId;

		private float totalCellHeight;

		private Dictionary<int, float> scrollHeightDic;

		public static bool needRecreateTopList;

		private Sequence scrollSequence;

		private const float scrollDuration = 0.5f;

		private MainStoryMenuCell storyCell;

		private bool isEventListCreating;

		protected override void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private int SetupCategorizedEventMenuCell(List<QuestSelectInstance.QuestEventData> eventsData, GameObject normalPrefab, int startDelayIndex)
		{
			return default(int);
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		private void ClearEventList()
		{
		}

		private IEnumerator CreateEventList()
		{
			return null;
		}

		private void UpdateRemainTime()
		{
		}

		private void AddMenuTitle(GameObject menuTitleObj, int delayIndex)
		{
		}

		private void CreateTutorialEventList()
		{
		}

		public void OnBackButtonTouched()
		{
		}

		public void OnMainQuestButtonTouched()
		{
		}

		private void ChangePageToMainQuest()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		public override bool IsLoading()
		{
			return default(bool);
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public void SetScrollPosition(QuestSelectInstance.QuestEventData targetEvent)
		{
		}

		private void SetScrollTween(DragEventScrollRect dragEventScrollRect, float toValue, float duration)
		{
		}

		public void Reload(int eventId)
		{
		}

		public void ReloadList()
		{
		}

		private IEnumerator Reload()
		{
			return null;
		}
	}
}
