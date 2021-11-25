using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ContactChangeDragonPopup : PopupBase
	{
		[SerializeField]
		private CommonIcon extraCharaIcon;

		[SerializeField]
		private Transform extraCharaDecoNode;

		[SerializeField]
		public CommonIcon[] recentPettedDragonIcons;

		public Transform[] recentSortDecoNodes;

		public GameObject[] favorIcons;

		public ContactChangeDragonListController listController;

		public ContactChangeDragonListBase listBase;

		public Text emptyPettedDragonText;

		private List<int> recentMasterIdList;

		private int selectedId;

		public static ContactChangeDragonPopup Create(UnityAction<int> onClose)
		{
			return null;
		}

		public void Setup()
		{
		}

		private void SetupExtraChara()
		{
		}

		private void IconButtonPressed(CommonIconListCellData dataCommon, TableViewCell<CommonIconListCellData> cellCommon)
		{
		}

		public void LoadListData()
		{
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

		public void OnCloseButtonPressed()
		{
		}

		public void OnSelect(int masterId)
		{
		}

		private bool IsFavor(int dragonId)
		{
			return default(bool);
		}
	}
}
