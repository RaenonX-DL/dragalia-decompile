using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StampListController : TableViewController<StampListData>
	{
		public const float cellWidth = 114f;

		public const float cellHeight = 114f;

		public GameObject listFrameObject;

		private ScrollRect _scrollRect;

		private int tapIconIndex;

		public ScrollRect stampSelectScrollRect => null;

		protected override void Start()
		{
		}

		public void LoadData(StampList[] allStampDatas)
		{
		}

		protected override TableViewCell<StampListData> CreateCellForIndex(int index)
		{
			return null;
		}

		public void UpdateListIcon(int stampId, bool nowSelectFlag, bool tapSelectFlag)
		{
		}

		public bool IsNowSelect(int stampId)
		{
			return default(bool);
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
