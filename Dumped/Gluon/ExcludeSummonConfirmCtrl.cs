using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class ExcludeSummonConfirmCtrl : TableViewController<ExcludeSummonConfirmCellData>
	{
		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private float delayFrame;

		private const float cellHeight = 148f;

		protected override void Awake()
		{
		}

		public void Init(int summonId, GiftType entityType, List<int> idList)
		{
		}

		public void ReloadContents(List<ExcludeSummonConfirmCellData> idList)
		{
		}

		protected override TableViewCell<ExcludeSummonConfirmCellData> CreateCellForIndex(int index)
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
