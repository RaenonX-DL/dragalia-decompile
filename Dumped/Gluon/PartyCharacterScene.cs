using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyCharacterScene : SceneBase
	{
		public enum SelectState
		{
			None,
			CharacterSelected,
			IconSelected
		}

		private PartyCharacterUICanvas mainCanvas;

		private bool isOverrideOldPartyData;

		public Camera mainCamera;

		public Canvas bgCanvas;

		public QuestCharacterCtrl[] characterCtrls;

		private CommonPopup leaderCheackDialog;

		private Button backButton;

		public SelectState selectState;

		public CommonIconListCellData currentSelectedData;

		public static bool fromMatching;

		private static int partyIndexFromMatching;

		private static bool isClearPartyFromMatching;

		private int backButtonSortingOrder;

		private PartyCharacterListController partyListController;

		public AudioPlayback bgmPlayback;

		public static GameObject[][] tempAttributeMatchEffects;

		public static string BackSceneName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public override void OnPresentReceived()
		{
		}

		public void ReloadCharacterModel(int index, bool isPlayVoice, PartyReloadCharaAnimationType animationType = PartyReloadCharaAnimationType.LandAnimationNotDelay)
		{
		}

		public void RemoveCharacterModel(int index)
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		public void SavePartyData(UnityAction saveEndCallBack)
		{
		}

		private void SavePartyNo(int partySwitchIndex, UnityAction saveEndCallBack)
		{
		}

		private void SavePartySwichIndex(int partySwitchIndex)
		{
		}

		public void InitIconList()
		{
		}

		private IEnumerator LoadBaseListData()
		{
			return null;
		}

		public void OnSortButtonClicked()
		{
		}

		public void OnSortApplied()
		{
		}

		private ulong[] CreateDataIdList()
		{
			return null;
		}

		private void PutOutCharacter(int charaId, int charaIndexInParty)
		{
		}

		private void DisableCharaSelect()
		{
		}

		private void DisableIconSelect()
		{
		}

		private void DisablePartyAndIconSelect()
		{
		}

		public void OnCharacterButtonPressed(int index)
		{
		}

		public void OnCharacterButtonLongPressed(int index)
		{
		}

		private int GetIndexOfCharacterInParty(int index, int charaId)
		{
			return default(int);
		}

		private void SwapCharacterInParty(int index1, int index2)
		{
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void OutButtonPressed()
		{
		}

		public void ChangePartyChara(bool isAutoSelect = false)
		{
		}

		public void SetPartyListController(PartyCharacterListController controller)
		{
		}

		public void OnBackButtonPressed()
		{
		}

		private void GoMatchingScene()
		{
		}

		private void GoPartyTopScene()
		{
		}

		private void GoBackScene()
		{
		}

		public void OnEquipChangeButtonPressed()
		{
		}

		public void ChagePartyCallBack()
		{
		}

		public void PagerSelectCallBack(int index)
		{
		}

		private void ChangePartyCallBack(Action changeSuccessAction)
		{
		}

		public void CheckChangeParty(Action changeSuccessAction)
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

		public void CreatePartySettingTempararyCharaErrerPopupAndReload()
		{
		}

		private void GoAnotherScene(string tabName, Footer.MenuTab tabType, bool fromMatching, bool isLongPressed)
		{
		}

		private int CheckDuplicatePartyChara(int charaId)
		{
			return default(int);
		}

		private void ShowDuplicateCharaDialog(int charaId, int duplicateCharaId, int duplicateCharaRarity, UnityAction disableSelection)
		{
		}

		public void ChangeParty(int index)
		{
		}

		private void DetachFooterCallback()
		{
		}

		private void ReplaceAttributeMatchEffects(PartyCharacterUIStatus[] partyStatus)
		{
		}
	}
}
