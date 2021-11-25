using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopDrawMaterialSummonPopup : PopupBase
	{
		[SerializeField]
		[Header("Texts")]
		public Text comment;

		public Text priceText;

		public Text beforeCountText;

		public Text afterCountText;

		public Text insufficientText;

		[SerializeField]
		[Header("Button")]
		public Button okButton;

		private int price;

		private Action onDraw;

		public static ShopDrawMaterialSummonPopup Create(int price, Action onDraw)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnSummonButtonPressed()
		{
		}
	}
}
