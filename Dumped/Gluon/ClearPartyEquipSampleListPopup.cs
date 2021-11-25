using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ClearPartyEquipSampleListPopup : CommonPopup
	{
		public Text questName;

		public ClearPartyEquipSampleListController equipSampleListController;

		[SerializeField]
		[Header("UI")]
		private Text descriptionText;

		[HideInInspector]
		public SceneBase scene;

		private int targetQuestId;

		private int[] targetCharaIds;

		private int questGroupId;

		private int[] questIds;

		private int pageIndex;

		private float scrollPos;

		private int partySwitchNo;

		private bool isSoloQuest;

		public static ClearPartyEquipSampleListPopup Create(SceneBase scene)
		{
			return null;
		}

		public void InitPopup(int questId, int[] charaIds, int partySwitchNo = 1)
		{
		}

		private void LoadPartyEquipSampleDatas()
		{
		}

		public void SetPrevPopupData(int questGroupId, int[] questIds, int pageIndex, float scrollPos)
		{
		}

		public void OnBackButtonPressed()
		{
		}

		public void OnReloadButtonPressed()
		{
		}

		private void OnSetButtonPressed(ClearPartyEquipSampleListCellData cellData, int indexInParty)
		{
		}

		private void ShowPartyChangePopup(int sampleDataIndex, int indexInParty)
		{
		}

		private void UpdatePartyData(int partyIndex, PartyList partyList)
		{
		}

		private bool CheckDuplicateCharacter(ClearPartyEquipSampleListCellData cellData, int indexInParty)
		{
			return default(bool);
		}

		private bool IsShowUnitEmptyPopup(ClearPartyEquipSampleListCellData cellData, int indexInParty)
		{
			return default(bool);
		}

		private bool IsShowUnitEmptyPopup(ClearPartyEquipSampleListCellData cellData)
		{
			return default(bool);
		}
	}
}
