using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeSkipFloorListCell : TableViewCell<DmodeSkipFloorListCell.DmodeSkipFloorListCellData>
	{
		public class DmodeSkipFloorListCellData
		{
			public int skipFloorCount;

			public int destinationFloorNum;

			public DmodeSkipFloorListCellData(int skipFloorCount, int destinationFloorNum)
			{
			}
		}

		[SerializeField]
		private Text destinationFloorText;

		private Action<int> onCellPressedCallback;

		public override void UpdateContent(DmodeSkipFloorListCellData cellData)
		{
		}

		public void AddOnCellPressedCallback(Action<int> callback)
		{
		}

		public void OnCellPressed()
		{
		}
	}
}
