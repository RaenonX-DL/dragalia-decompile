using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class ItemSentPresentBoxCtrl : TableViewController<ItemSentPresentBoxCellData>
	{
		public float cellHeight;

		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private float delayFrame;

		protected override void Awake()
		{
		}

		public void LoadData(List<ItemSentPresentBoxCellData> cellList)
		{
		}

		protected override TableViewCell<ItemSentPresentBoxCellData> CreateCellForIndex(int index)
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
