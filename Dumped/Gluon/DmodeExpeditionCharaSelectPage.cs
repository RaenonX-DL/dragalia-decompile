using System;
using System.Collections;
using System.Collections.Generic;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeExpeditionCharaSelectPage : DmodePageBase
	{
		[Serializable]
		private class ExpeditionPartySetting
		{
			public List<int> memberList;
		}

		[SerializeField]
		public CommonIconListBase iconListFrame;

		[SerializeField]
		private DmodeExpeditionCharaController charaListController;

		[SerializeField]
		private Image[] selectedImages;

		[SerializeField]
		private Sprite addPartySprite;

		[SerializeField]
		private Sprite selectPartySprite;

		[SerializeField]
		private Text maxFloorText;

		[SerializeField]
		private Text needTimeText;

		[SerializeField]
		private Button expeditionStartButton;

		[SerializeField]
		private ButtonWithSelectedImage expeditionStartWithSelectedImage;

		private CommonIconListCellData currentSelectedData;

		private int currentSelectIndex;

		private GameObject startDirectionObj;

		private FlRoot startDirectionFlRoot;

		private ExpeditionPartySetting partySetting;

		private bool isLeaving;

		private const string partyPrefKeyExpedition = "expedition.party";

		private ulong[] CreateDataIdList()
		{
			return null;
		}

		private void SavePartyToLocal()
		{
		}

		private bool LoadPartyFromLocal()
		{
			return default(bool);
		}

		public IEnumerator Load()
		{
			return null;
		}

		private void ReloadListData()
		{
		}

		public void Reload()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private void OnBackButtonTouched()
		{
		}

		private void ReturnToTopPage()
		{
		}

		public void OnSortButtonClicked()
		{
		}

		public void OnSortApplied()
		{
		}

		private int CheckDuplicatePartyChara(int charaId)
		{
			return default(int);
		}

		private void ShowDuplicateCharaDialog(int charaId, int duplicateCharaId, int duplicateCharaRarity, UnityAction disableSelection)
		{
		}

		public void OnCharacterButtonPressed(int index)
		{
		}

		public void OnCharacterButtonLongPressed(int index)
		{
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void ClearSelection()
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void OutButtonPressed()
		{
		}

		public void ReloadCharacterModel(int index, bool isPlayVoice, PartyReloadCharaAnimationType animationType = PartyReloadCharaAnimationType.LandAnimationNotDelay)
		{
		}

		public void OnStartPressed()
		{
		}

		private void StartExpedition()
		{
		}

		public void ResetStartButtonImage()
		{
		}

		private void LoadStartDirectionPrefab()
		{
		}

		private void PlayStartDirection(Action playEndCallBack)
		{
		}
	}
}
