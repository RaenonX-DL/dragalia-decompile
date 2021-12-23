using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectMemoryEventPage : QuestSelectEventPageBase, ICustomMessage
	{
		[SerializeField]
		[Header("Active")]
		public GameObject activeEventGO;

		public SimpleAnimationCell activeTitleAnimationCell;

		public QuestMenuMemoryEventBanner activeBanner;

		[SerializeField]
		[Header("Template")]
		public QuestMenuMemoryEventBanner templateBanner;

		[SerializeField]
		[Header("RecommendedBuild")]
		public GameObject recommendedGO;

		public SimpleAnimationCell recommendedTitleAnimationCell;

		public Transform recommendedParent;

		[SerializeField]
		[Header("RecommendedRaid")]
		public GameObject recommendedRaidGO;

		public SimpleAnimationCell recommendedRaidTitleAnimationCell;

		public Transform recommendedRaidParent;

		[SerializeField]
		[Header("RecommendedDefence")]
		public GameObject recommendedDefenceGO;

		public SimpleAnimationCell recommendedDefenceTitleAnimationCell;

		public Transform recommendedDefenceParent;

		[SerializeField]
		[Header("RecommendedIntercept")]
		public GameObject recommendedInterceptGO;

		public SimpleAnimationCell recommendedInterceptTitleAnimationCell;

		public Transform recommendedInterceptParent;

		[SerializeField]
		[Header("RecommendedEventOthers")]
		public GameObject recommendedEventOthersGO;

		public SimpleAnimationCell recommendedEventOthersTitleAnimationCell;

		public Transform recommendedEventOthersParent;

		[SerializeField]
		[Header("RecommendedSpecial")]
		public GameObject recommendedSpecialGO;

		public SimpleAnimationCell recommendedSpecialTitleAnimationCell;

		public Transform recommendedSpecialParent;

		[SerializeField]
		[Header("OthersBuild")]
		public GameObject othersGO;

		public SimpleAnimationCell otherTitleAnimationCell;

		public Transform othersParent;

		[SerializeField]
		[Header("OthersRaid")]
		public GameObject othersRaidGO;

		public SimpleAnimationCell otherRaidTitleAnimationCell;

		public Transform othersRaidParent;

		[SerializeField]
		[Header("OthersDefence")]
		public GameObject othersDefenceGO;

		public SimpleAnimationCell otherDefenceTitleAnimationCell;

		public Transform othersDefenceParent;

		[SerializeField]
		[Header("OthersIntercept")]
		public GameObject othersInterceptGO;

		public SimpleAnimationCell otherInterceptTitleAnimationCell;

		public Transform othersInterceptParent;

		[SerializeField]
		[Header("OthersEventOthers")]
		public GameObject othersEventOthersGO;

		public SimpleAnimationCell otherEventOthersTitleAnimationCell;

		public Transform othersEventOthersParent;

		[SerializeField]
		[Header("OthersSpecial")]
		public GameObject othersSpecialGO;

		public SimpleAnimationCell otherSpecialTitleAnimationCell;

		public Transform othersSpecialParent;

		[SerializeField]
		[Header("Publisher")]
		public UIAnimationPublisher publisher;

		[SerializeField]
		[Header("HowTo")]
		public ButtonWithSelectedImage howtoButtonWithSelectedImage;

		private QuestSelectInstance.QuestEventData eventData;

		private const string prefMemoryTutorial = "__MemoryEventTutorialPU";

		private Dictionary<int, float> scrollValueDic;

		[SerializeField]
		private int tutorialPageCount;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
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

		private void CreateEventList()
		{
		}

		private void SetEventList(List<int> eventList, GameObject go, SimpleAnimationCell animationCell, Transform parent, ref int delayIndex)
		{
		}

		public void OnBackButtonTouched()
		{
		}

		public void OnHowToButtonPressed()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
