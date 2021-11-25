using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class EventQuestDetailListPage : PageBase, ICustomMessage
	{
		[SerializeField]
		private Transform contentTransfrom;

		[SerializeField]
		private float enterAnimationDuration;

		public AnimationListOneCol listAnimation;

		private int eventId;

		private Clb01EventLocationElement eventLocation;

		private List<QuestEventMenuElement> eventData;

		private Dictionary<int, float> scrollValueDic;

		private Action<EventQuestDetailListPage, Clb01EventLocationElement> onPageBecomeActive;

		private Action<EventQuestDetailListPage, CombatEventLocationElement> onPageBecomeActiveCombat;

		private bool isArena;

		public const int arenaEventId = 21405;

		public const int arenaLocationId = 6;

		public EventQuestScene eventQuestScene => null;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Initialize(Action<EventQuestDetailListPage, Clb01EventLocationElement> onPageBecomeActive)
		{
		}

		public void InitializeCombat(Action<EventQuestDetailListPage, CombatEventLocationElement> onPageBecomeActive)
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		public void LoadData(int eventId, Clb01EventLocationElement location)
		{
		}

		public void LoadData(int eventId, CombatEventLocationElement location)
		{
		}

		private void CreateList()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
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

		private void CreateQuestOpenPopup(List<QuestEventMenuElement> givenCellDataList)
		{
		}
	}
}
