using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectEventDetailPage : PageBase, ICustomMessage
	{
		[SerializeField]
		private Transform contentTransfrom;

		[SerializeField]
		private float duration;

		[SerializeField]
		private QuestSelectEventShortCut questSelectEventShortCut;

		[SerializeField]
		private GameObject eventEndDiscription;

		public AnimationListOneCol listAnimation;

		[SerializeField]
		private TabBase questMultiTab;

		public QuestSupportCanvas.PlayType playType;

		[SerializeField]
		private GameObject questClearPartyButtonObj;

		private int baseQuestGroupId;

		protected NormalEventSelectScene questSelectScene;

		private QuestEventGroupElement groupElement;

		private List<QuestEventMenuElement> eventData;

		private QuestStoryClearReward storyReward;

		private Dictionary<int, float> scrollValueDic;

		private const string showWalkerInfoKey = "ShowWalkerHowToPlay";

		private bool isLoading;

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

		public void OpenDefaultTab(int baseQuestGroupId)
		{
		}

		public void OnSelectedTab(int num)
		{
		}

		private IEnumerator Load()
		{
			return null;
		}

		public override bool IsLoading()
		{
			return default(bool);
		}

		public override void OnPageBecomeInActive()
		{
		}

		public void LoadData()
		{
		}

		private IEnumerator CreateList()
		{
			return null;
		}

		public void UpdateCreateList()
		{
		}

		private IEnumerator UpdateCreateListCoroutine()
		{
			return null;
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private IEnumerator StartEnterAnimationCo(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
			return null;
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		public bool ClickTargetQuestCell(int eventQuestId)
		{
			return default(bool);
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public void OnBackButtonTouched()
		{
		}

		public void OnMainQuestButtonTouched()
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private IEnumerator QuestWallCheck()
		{
			return null;
		}

		private IEnumerator QuestSimpleEventCheck()
		{
			return null;
		}

		private void TutorialMultiBattle()
		{
		}

		private void TutorialDragonBattle()
		{
		}

		private IEnumerator TutorialDragonBattleCoroutine(TouchGuardObject guardObj)
		{
			return null;
		}

		private void TutorialInterceptionBattle()
		{
		}

		private IEnumerator TutorialInterceptionBattleCoroutine(TouchGuardObject guardObj)
		{
			return null;
		}

		private void SetDispQuestClearPartyButton()
		{
		}

		public void OnClearPartyButtonPressed()
		{
		}
	}
}
