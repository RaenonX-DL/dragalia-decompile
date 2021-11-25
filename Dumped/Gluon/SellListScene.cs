using System.Collections;
using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SellListScene : SceneBase
	{
		public static SellListType listType;

		public static SellListActionType listActionType;

		public const string prefabDir = "Prefabs/OutGame/SellList/";

		public const int maxSellCount = 50;

		public SellListCanvas mainCanvas;

		private SellIconListBase sellIconListBase;

		private SellModeFrame sellModeFrame;

		private SellIconListController listController;

		private List<ulong> selectKeys;

		private bool isAllListIconLock;

		private Canvas gardCanvas;

		private List<ConfigDialogSortData> selectUserData;

		private long totalSellGold;

		private int totalSellMoon;

		private long beforeGold;

		private int beforeMoon;

		private Button sceneBackButton;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private IEnumerator UnloadScene()
		{
			return null;
		}

		public override void OnPresentReceived()
		{
		}

		public void BackButtonPressed()
		{
		}

		public void SetNoSelectableIconLayout(bool noSelectable)
		{
		}

		private bool IsEnableTotalMoon()
		{
			return default(bool);
		}

		private void SetCaption()
		{
		}

		private void LoadListData()
		{
		}

		public void OnSortButtonClicked()
		{
		}

		public void OnSortApplied()
		{
		}

		private ulong[] CreateDataIdList(out GiftType giftType)
		{
			return null;
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void UpdateEquipIconLock(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void UnSelectIcon(ulong targetKey)
		{
		}

		private void ListTabButtonPressed()
		{
		}

		private void SellModeButtonPressed()
		{
		}

		private void ResetSellInfo()
		{
		}

		private void UpdateSelectIconNumber()
		{
		}

		public int CheckSelectIcon(ulong keyId)
		{
			return default(int);
		}

		private void UpdateSellFrameInfo()
		{
		}

		private void SellFrameResetPresed()
		{
		}

		private void SellFrameBackPresed(bool skipListReload)
		{
		}

		private void SellFrameAutoPressed()
		{
		}

		private void SellFrameSellPressed()
		{
		}

		private int SellTargetListSort(ConfigDialogSortData currCell, ConfigDialogSortData nextCell)
		{
			return default(int);
		}

		private void DoAutoSelect()
		{
		}

		private void SendSellData()
		{
		}

		public void SendDataOnSuccess(DragonSellResponse res)
		{
		}

		public void SendDataOnSuccess(WeaponSellResponse res)
		{
		}

		public void SendDataOnSuccess(AmuletSellResponse res)
		{
		}

		private void ShowSellCompleteDialog()
		{
		}

		public void OnListChangeButtonPressed()
		{
		}
	}
}
