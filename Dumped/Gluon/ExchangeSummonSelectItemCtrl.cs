using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class ExchangeSummonSelectItemCtrl : TableViewController<ExchangeSummonSelectItemCellData>
	{
		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private float delayFrame;

		public GiftType giftType;

		private int summonId;

		private const float cellHeight = 148f;

		protected override void Awake()
		{
		}

		public void Init(int summonId, List<ulong> idList, Action<ExchangeSummonSelectItemCellData> onClick)
		{
		}

		public void ReloadContents(List<ulong> idList, Action<ExchangeSummonSelectItemCellData> onClick)
		{
		}

		protected override TableViewCell<ExchangeSummonSelectItemCellData> CreateCellForIndex(int index)
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
