using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class QuestEventRewardCtrl : TableViewController<QuestEventRewardCellData>
	{
		public float cellHeight;

		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private float delayFrame;

		protected override void Awake()
		{
		}

		public void LoadData(List<QuestEventRewardCellData> cellList)
		{
		}

		protected override TableViewCell<QuestEventRewardCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void UpdateReceiveButtonInformation()
		{
		}

		public void StartEnterAnimation()
		{
		}

		public void StartExitAnimation()
		{
		}
	}
}
