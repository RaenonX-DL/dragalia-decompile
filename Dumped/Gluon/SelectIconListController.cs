using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SelectIconListController : SelectIconListControllerBase
	{
		public class SelectedItemData
		{
			public List<int> candidateIdList;

			public int selectedId;

			public int limitBreakCount;

			public int maxCount;

			public List<ulong> tempKeyIds;

			private ulong keyId;

			public void Clear()
			{
			}

			public void AddCandidateId(int id)
			{
			}

			public bool IsEnable(int id)
			{
				return default(bool);
			}

			public bool IsValid(ShopTradeProductData.TradeShopItemData.NeedMaterialInfo info)
			{
				return default(bool);
			}
		}

		public static SelectListType listType;

		public static SelectedItemData selectedItem;

		public Action<List<ulong>> onSelectionChanged;

		public SelectListCanvas mainCanvas;

		[SerializeField]
		private SelectIconListBase selectIconListBase;

		[SerializeField]
		private Button decideButton;

		private SelectIconListController listController;

		public const string prefabDir = "Prefabs/OutGame/SelectList/";

		private IEnumerator loadUnitDetailCoroutine;

		public int dataListCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void Start()
		{
		}

		private int SelectTargetListSort(ConfigDialogSortData currCell, ConfigDialogSortData nextCell)
		{
			return default(int);
		}

		protected override void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void UpdateSelectFrameInfo()
		{
		}

		private void SelectFrameResetPresed()
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private IEnumerator UnloadScene()
		{
			return null;
		}

		private void ListTabButtonPressed()
		{
		}

		private void LoadListData()
		{
		}

		private ulong[] CreateDataIdList(out GiftType giftType, int id, int limitBreakCount)
		{
			return null;
		}

		protected override CommonIconListCellData CreateDragonCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateWeaponCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateAmuletCellData(ulong keyId, int decoNum)
		{
			return null;
		}

		protected override void UpdateContents()
		{
		}

		public ulong[] GetAutoSelectKeys(int maxSelect)
		{
			return null;
		}

		private void ResetSelectInfo()
		{
		}

		protected override void UnSelectIcon(ulong targetKey)
		{
		}

		public void OnSortApplied()
		{
		}

		public void OnSortButtonClicked()
		{
		}
	}
}
