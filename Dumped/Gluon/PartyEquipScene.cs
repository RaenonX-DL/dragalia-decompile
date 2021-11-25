using System;
using System.Collections;
using System.Collections.Generic;
using Cute.Cri;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipScene : SceneBase
	{
		public PartyEquipUICanvas mainCanvas;

		public const string prefabDir = "Prefabs/OutGame/Party/PartyEquip/";

		public EquipUnitListController equipUnitListController;

		public Camera mainCamera;

		private AudioPlayback bgmPlayback;

		private Button backButton;

		private int backButtonSortingOrder;

		private GameObject attributeMatch;

		private Coroutine attributeMatchUpdateParentGroupAlphaCoroutine;

		private const string attributeMatchPathBase = "Prefabs/OutGame/Party/Flash/pf_AttributeMatch";

		private const string attributeMatchReplaceTextMaterialPathBase = "Images/OutGame/Party/AttributeMatch/AttributeMatch";

		private TableViewCell<CommonIconListCellData> unlockEffectTargetCell;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnPresentReceived()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private void SetupTutorial()
		{
		}

		private void GoPartyScene(PartySceneState state)
		{
		}

		public void OnBackButtonPressed()
		{
		}

		public void SavePartyData(UnityAction saveEndCallBack)
		{
		}

		private void InitIconList()
		{
		}

		public void LoadEquipListData()
		{
		}

		private List<ulong> InsertActiveEquipmentToFilteredList(List<ulong> filteredList)
		{
			return null;
		}

		private GiftType GetEquipGiftType()
		{
			return default(GiftType);
		}

		public void OnSortButtonClicked()
		{
		}

		private ulong[] CreateDataIdList()
		{
			return null;
		}

		private string GetEquipChangeAlertTitleString()
		{
			return null;
		}

		private string GetEquipAlreadyEquipMessage()
		{
			return null;
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void outButtonPressed()
		{
		}

		public void OnSkillCellPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void FooterButtonLongPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void PartyEditPopup(string tabName, Footer.MenuTab tabType, bool fromMatching, bool isLongPressed)
		{
		}

		private void IncludingDuplicateAbilityCrestAction(Action callBack)
		{
		}

		private void SendMainPartyAndGoAnotherScene(string tabName, Footer.MenuTab tabType, bool fromMatching, bool isLongPressed)
		{
		}

		private void GoAnotherScene(string tabName, Footer.MenuTab tabType, bool fromMatching, bool isLongPressed)
		{
		}

		private void SelectEquipIconCellData(ulong keyId, CommonEquipIconCellData equipData, bool hasOutButtonSelectState)
		{
		}

		private void SelectEquipUnit(CommonEquipIconCellData equipData)
		{
		}

		private void RefreshCrestState(PartySettingList userCharaData)
		{
		}

		private void RemoveEquipUnitByCharaId(int charaId, ulong keyId)
		{
		}

		public void ReloadWeaponModel()
		{
		}

		private void DetachFooterCallback()
		{
		}

		private void CreateAttributeMatch(ElementalType type)
		{
		}

		private IEnumerator UpdateAttributeMatchParentGroupAlpha(FlPlane flPlane)
		{
			return null;
		}

		public static string GetAttributePathAdderForText(ElementalType element)
		{
			return null;
		}

		public void SetAttributeMatch(AutoPartyConfigData selectData)
		{
		}

		private void SetAttributeMatch(CommonEquipIconCellData equipData)
		{
		}

		public CommonListCustomSortData SkillListSort(CommonListCustomSortData data)
		{
			return null;
		}

		private void SendEditSkillUnlockData(int unlockCharaId)
		{
		}

		private void PlayReleaseEditSkillUnlockEffect()
		{
		}
	}
}
