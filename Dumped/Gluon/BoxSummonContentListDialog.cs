using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BoxSummonContentListDialog : PopupBase
	{
		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text summonRemainText;

		[SerializeField]
		private GameObject rewardListContent;

		[SerializeField]
		private GameObject mainRewardBase;

		[SerializeField]
		private GameObject mainRewardItemTemplate;

		[SerializeField]
		private GameObject rewardLineTemplate;

		private List<GameObject> rewardIconInstances;

		private EventQuestPageBase currentPage;

		private void OnEnable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void SetCurrentPage(EventQuestPageBase page, bool bOpenFromResultPage)
		{
		}

		private void SetupContents(bool bOpenFromResultPage)
		{
		}

		private void TeardownContents()
		{
		}

		public void OnCloseButton()
		{
		}
	}
}
