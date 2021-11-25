using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QRBonusRewardTableViewController : TableViewController<QuestResultModel.QuestBonus.QuestBonusInfo>
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

		public virtual void SetBonusRewardItemInfo(QuestResultModel.QuestBonus rewardItemList)
		{
		}

		public virtual void SetBonusRewardItemInfo(string title, string mainText, List<QuestResultModel.QuestBonus.QuestBonusInfo> rewardItemList)
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
	}
}
