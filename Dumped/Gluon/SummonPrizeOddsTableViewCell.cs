using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonPrizeOddsTableViewCell : TableViewCell<SummonPrizeOddsTableViewData>
	{
		[SerializeField]
		private Text prizeName;

		[SerializeField]
		private Text num;

		[SerializeField]
		private Text percentage;

		[SerializeField]
		private Text captionText;

		[SerializeField]
		private Text captionPercentage;

		[SerializeField]
		private GameObject normalNode;

		[SerializeField]
		private GameObject captionNode;

		[SerializeField]
		private GameObject titleNode;

		public const float captionHeight = 60f;

		public const float titleHeight = 250f;

		public const float normalHeight = 32f;

		public override void UpdateContent(SummonPrizeOddsTableViewData data)
		{
		}
	}
}
