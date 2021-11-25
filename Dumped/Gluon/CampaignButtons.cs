using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CampaignButtons : MonoBehaviour
	{
		public enum CampaignButtonsEnumType
		{
			BannerType,
			CellType
		}

		[SerializeField]
		public PointerEventHandler[] campaignButtons;

		[SerializeField]
		private Text[] campaignButtonText;

		[SerializeField]
		private GridLayoutGroup gridLayoutGroup;

		private Vector2 campaignPosOne;

		private Vector2 campaignPos;

		private CampaignDataWrapper[] campaignData;

		private List<CampaignDataWrapper> campaignDataList;

		private bool isVoidBattle;

		public void Initialize(int groupId, CampaignButtonsEnumType type)
		{
		}

		public void Initialize(QuestSelectInstance.QuestEventData eventData, CampaignButtonsEnumType type)
		{
		}

		public void Initialize(int groupId, bool isSoloMultiParent = false)
		{
		}

		public void Initialize(QuestDataElement questData, CampaignButtonsEnumType type)
		{
		}

		public void Initialize(QuestSelectInstance.QuestEventData eventData)
		{
		}

		public void HideCampaign(CampaignButtonsEnumType type)
		{
		}

		public static bool MayCampaignAvailable(QuestSelectInstance.QuestEventData eventData, bool useOnlyLegacyData = false)
		{
			return default(bool);
		}

		public static bool MayCampaignAvailable(int groupId, bool useOnlyLegacyData = false)
		{
			return default(bool);
		}

		public static QuestSupportCanvas.PlayType GetPlayType(int groupId)
		{
			return default(QuestSupportCanvas.PlayType);
		}

		public static bool MayCampaignAvailableByQuestId(int questId)
		{
			return default(bool);
		}

		private void GetCampaignData(int groupId, Queue<CampaignDataWrapper> campaignTypeQueue, bool isSoloMultiParent = false)
		{
		}

		private void GetCampaignData(QuestDataElement questData, Queue<CampaignDataWrapper> campaignTypeQueue)
		{
		}

		private void ShowCampaigns(CampaignButtonsEnumType type, Queue<CampaignDataWrapper> campaignTypeQueue)
		{
		}

		private void SetButton(PointerEventHandler peh, Text text, CampaignDataWrapper data)
		{
		}

		public void OnDecreaseStaminaSingle()
		{
		}

		public void OnRecoveryDoubleStaminaSingle()
		{
		}

		public void OnDecreaseStaminaMulti()
		{
		}

		public void OnRecoveryDoubleStaminaMulti()
		{
		}

		public void OnManaUp()
		{
		}

		public void OnCoinUp()
		{
		}

		public void OnItemDropUp()
		{
		}

		public void OnItemDropUpSingle()
		{
		}

		public void OnItemDropUpMulti()
		{
		}

		private void CreateCampaignPopup(CampaignType type)
		{
		}

		public void OnClickCampaignButton()
		{
		}
	}
}
