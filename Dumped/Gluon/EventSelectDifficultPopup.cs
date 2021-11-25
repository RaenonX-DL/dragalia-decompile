using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventSelectDifficultPopup : PopupBase, ICustomMessage
	{
		[SerializeField]
		public RectTransform frameRT;

		[SerializeField]
		public Text titleText;

		[SerializeField]
		private Text closeButtonText;

		[SerializeField]
		private Text eventItemCountText;

		[SerializeField]
		private Transform contentTransform;

		[SerializeField]
		private Text descriptionText;

		[SerializeField]
		private Transform descriptionObj;

		[SerializeField]
		[Header("Tags")]
		private Transform multiTag;

		[SerializeField]
		private Transform soloTag;

		[SerializeField]
		[Header("PriceIcons")]
		private Image itemIcon;

		private FlashPlayerManager flashPlayerManager;

		[SerializeField]
		private TabBase questMultiTab;

		private QuestSupportCanvas.PlayType playType;

		private int baseQuestGroupId;

		private List<QuestEventMenuElement> cellDataList;

		private List<QuestCell> questCellList;

		private void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void SetLSize()
		{
		}

		public void SetContent(List<QuestEventMenuElement> cellDataList)
		{
		}

		private void UpdateMultiStaminaQuestCellList()
		{
		}

		private void UpdateContent(List<QuestEventMenuElement> cellData)
		{
		}

		private void SetDescriptionText(QuestEventMenuElement eventMenuElement)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		private void SetBonus(QuestEventMenuElement eventMenuElement)
		{
		}

		public void OpenDefaultTab(int baseQuestGroupId)
		{
		}

		public void OnSelectedTab(int num)
		{
		}

		private void UpdateContentWithTabData()
		{
		}
	}
}
