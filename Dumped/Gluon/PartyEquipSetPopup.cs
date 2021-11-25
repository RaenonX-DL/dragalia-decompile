using System;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipSetPopup : CommonPopup
	{
		public Image[] charaIcons;

		public GameObject[] selectedIcons;

		public Transform listParentTransform;

		public GameObject originCell;

		public Action<int, int> selectEquipSetCallBack;

		private PartyEquipSetPopupCell[] cells;

		private int selectCharaIndex;

		private int[] partyCharaIds;

		public const int maxSetCount = 3;

		public static PartyEquipSetPopup Create()
		{
			return null;
		}

		public void InitPopup(int defaultSelectIndex)
		{
		}

		public void UpdateCellList()
		{
		}

		public void OnCharaIconPressed(int index)
		{
		}

		private void SendRegistData(int dataIndex, string setName)
		{
		}

		private bool CanRegistEquipSetData()
		{
			return default(bool);
		}

		private AtgenRequestCharaUnitSetData CreateRegistData(bool isNameEditOnly, int dataIndex)
		{
			return null;
		}

		private void SelectCrestSet(int setIndex)
		{
		}
	}
}
