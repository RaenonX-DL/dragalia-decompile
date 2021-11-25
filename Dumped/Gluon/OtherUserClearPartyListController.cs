using System;
using UnityEngine;

namespace Gluon
{
	public class OtherUserClearPartyListController : TableViewController<OtherUserClearPartyListCellData>
	{
		public enum OtherUserClearPartyCellType
		{
			normalType,
			partySwitchType
		}

		public Action<OtherUserClearPartyListCellData, int> sampleButtonCallBack;

		public GameObject emptyListTextObj;

		public float cellWidth;

		public float cellHeight;

		public float partySwitchCellHeight;

		public OtherUserClearPartyCellType cellType;

		public GameObject[] listOriginalCells;

		private const int maxListCellCount = 20;

		public bool hasListData => default(bool);

		public void LoadList(int questId, int pageIdex)
		{
		}

		protected override TableViewCell<OtherUserClearPartyListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		private GameObject GetOriginCellObject(OtherUserClearPartyCellType type)
		{
			return null;
		}
	}
}
