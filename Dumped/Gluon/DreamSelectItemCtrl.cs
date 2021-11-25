using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class DreamSelectItemCtrl : TableViewController<DreamSelectItemCtrl.DreamSelectItemCellData>
	{
		public class DreamSelectItemCellData
		{
			public int entity_id;

			public int entity_type;
		}

		private const float cellHeight = 148f;

		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private float delayFrame;

		public GiftType giftType;

		private int price;

		protected override void Awake()
		{
		}

		public void Init(int price, List<ulong> cellData)
		{
		}

		public void ReloadContents(List<ulong> cellData)
		{
		}

		protected override TableViewCell<DreamSelectItemCellData> CreateCellForIndex(int index)
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
