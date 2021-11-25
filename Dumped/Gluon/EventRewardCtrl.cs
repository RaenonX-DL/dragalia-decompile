using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class EventRewardCtrl : TableViewController<EventRewardCellData>
	{
		public float cellHeight;

		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private float delayFrame;

		protected override void Awake()
		{
		}

		public void LoadOriginalCell(bool isTotalDamageEvent)
		{
		}

		public void LoadData(List<EventRewardCellData> cellList)
		{
		}

		protected override TableViewCell<EventRewardCellData> CreateCellForIndex(int index)
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
