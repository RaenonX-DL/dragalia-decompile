using System;
using UnityEngine;

namespace Gluon
{
	public class ClearPartyEquipSampleListController : TableViewController<ClearPartyEquipSampleListCellData>
	{
		public Action<ClearPartyEquipSampleListCellData, int> setButtonCallBack;

		[SerializeField]
		private Vector2 soloPartyCellSize;

		[SerializeField]
		private Vector2 multiPartyCellSize;

		private bool isSoloQuest;

		private static readonly string clearPartySoloCellPath;

		private static readonly string clearPartyMultiCellPath;

		public void LoadOriginalCell(bool isSoloQuest)
		{
		}

		public void LoadList(bool isSoloQuest)
		{
		}

		protected override TableViewCell<ClearPartyEquipSampleListCellData> CreateCellForIndex(int index)
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
	}
}
