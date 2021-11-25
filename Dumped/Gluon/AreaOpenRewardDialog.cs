using System;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AreaOpenRewardDialog : CommonPopup
	{
		[SerializeField]
		private Text rewardTitleText;

		[SerializeField]
		private GameObject rewardListContent;

		[SerializeField]
		private Image enemyIcon;

		[SerializeField]
		private GameObject rewardLineTemplate;

		[SerializeField]
		private GameObject titleObject;

		[SerializeField]
		private GameObject enemyObject;

		[SerializeField]
		private GameObject afterEventMessageObject;

		private Action onCloseAction;

		private List<GameObject> rewardIconInstances;

		private EventQuestPageBase currentPage;

		private const string enemyIconPath = "Images/Icon/Combat/Enemy/{0:D5}/Icon_Combat_Enemy_{1:D2}";

		private void OnEnable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void SetCurrentPage(CombatEventLocationElement location, EventQuestPageBase page, bool isAfterEvent = false)
		{
		}

		private void SetupContents(CombatEventLocationElement location, bool isAfterEvent)
		{
		}

		private void TeardownContents()
		{
		}

		public void SetCloseAction(Action action)
		{
		}

		public void OnCloseButton()
		{
		}
	}
}
