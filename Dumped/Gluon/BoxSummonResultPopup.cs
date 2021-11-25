using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BoxSummonResultPopup : PopupBase
	{
		public class BoxSummonResultData
		{
			public int entityId;

			public GiftType entityType;

			public int quantity;

			public int count;

			public BoxSummonResultData(int entity_id, int entity_type, int entity_quantity, int count)
			{
			}
		}

		public class BoxSummonResultPickUpData
		{
			public int entityId;

			public GiftType entityType;

			public int quantity;

			public int count;

			public int pickupItemState;

			public int twoStepId;

			public BoxSummonResultPickUpData(int entity_id, int entity_type, int entity_quantity, int count, int pick, int two)
			{
			}
		}

		[SerializeField]
		private GameObject pickupItemsObj;

		[SerializeField]
		private Text summonObtainedText;

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

		public static BoxSummonResultPopup Create()
		{
			return null;
		}

		private void OnEnable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void SetCurrentPage(EventQuestPageBase page)
		{
		}

		private void SetupContents()
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
