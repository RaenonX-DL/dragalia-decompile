using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestRewardTableViewController : TableViewController<QuestResultModel.FirstClearModel.FirstClearItemInfo>
	{
		[SerializeField]
		private int _maxCellCount;

		[SerializeField]
		protected Button closeButton;

		[SerializeField]
		protected Text uiTitle;

		[SerializeField]
		protected Text uiMainText;

		[SerializeField]
		protected DragEventScrollRect dragScrollRect;

		[SerializeField]
		protected Image _frame;

		[SerializeField]
		protected Vector3 centerPos;

		protected float cellHeight;

		public int maxCellCount => default(int);

		public Image frame => null;

		protected override void Start()
		{
		}

		protected virtual void LoadData()
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public virtual void SetRewardItemInfo(List<QuestResultModel.FirstClearModel.FirstClearItemInfo> rewardItemList)
		{
		}

		public void SetCloseButtonEvent(UnityAction action)
		{
		}

		public void SetText(string title, string mainText)
		{
		}

		public void DisableScroll()
		{
		}

		public void SetCellTopToCenter()
		{
		}

		public void SetCellCenterPositionY(float setPositionY)
		{
		}
	}
}
