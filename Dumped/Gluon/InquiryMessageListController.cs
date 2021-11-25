using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class InquiryMessageListController : TableViewController<InquiryMessageListCellData>
	{
		public const float cellHeight = 96f;

		public int pageCellCountMax;

		public RectTransform pagerBase;

		public TabButton[] pagerButtons;

		private int pagerIndex;

		private int totalDataCount;

		protected override void Awake()
		{
		}

		public void LoadData(List<InquiryMessageListCellData> cellList, int pagerIndex)
		{
		}

		protected override void UpdateContents()
		{
		}

		protected override void UpdateContentSize()
		{
		}

		protected override TableViewCell<InquiryMessageListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}
	}
}
