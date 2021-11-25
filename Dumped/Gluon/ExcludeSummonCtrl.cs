using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ExcludeSummonCtrl : TableViewController<ExcludeSummonCellData>
	{
		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private float delayFrame;

		[SerializeField]
		public Text canExcludeNum;

		public GiftType giftType;

		private const float cellHeight = 148f;

		private List<ExcludeSummonCellData> excludeSummonCellDataList;

		protected override void Awake()
		{
		}

		public void Init(GiftType giftType, List<ulong> idList)
		{
		}

		public void ReloadContents(List<ulong> idList)
		{
		}

		public List<ExcludeSummonCellData> GetSortTableData()
		{
			return null;
		}

		public List<ExcludeSummonCellData> GetTableData()
		{
			return null;
		}

		public void SetAllExcludeSetting(bool excludeSetting)
		{
		}

		public void AllUpdateCell()
		{
		}

		protected override TableViewCell<ExcludeSummonCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void StartEnterAnimation()
		{
		}

		public void StartExitAnimation()
		{
		}
	}
}
