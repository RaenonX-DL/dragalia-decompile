using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonOddsPopupTotalBlock : MonoBehaviour
	{
		[SerializeField]
		public Text sumText;

		public Text charaSumText;

		public Text dragonSumText;

		public Text amuletSumText;

		public GameObject charaLine;

		public GameObject dragonLine;

		public GameObject amuletLine;

		private Rarity rarity;

		private bool isPickup;

		public void Setup(OddsRate data, Rarity rarity, bool isPickup)
		{
		}

		private void SetupSubBunch(OddsUnitDetail[] oddsList, GameObject normalLine)
		{
		}
	}
}
