using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeDragonRewardDetailInfoCell : DmodeUnitItemDetailInfoCell
	{
		[SerializeField]
		[Header("Rare")]
		private GameObject[] rareGOs;

		[SerializeField]
		private Text rarePriceText;

		[SerializeField]
		[Header("Button")]
		private Button chooseButton;

		[SerializeField]
		[Header("Balloon")]
		private Transform balloon;

		private DmodeDungeonItem item;

		private int rarePrice;

		public void Setup(DmodeDungeonItem item, int rarePrice)
		{
		}

		public void UpdatePriceView()
		{
		}

		private void Start()
		{
		}

		public void OnChooseButtonPressed()
		{
		}
	}
}
