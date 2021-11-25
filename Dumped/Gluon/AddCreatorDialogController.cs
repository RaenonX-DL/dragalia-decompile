using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AddCreatorDialogController : PopupBase
	{
		[SerializeField]
		private GameObject dialogObj;

		private FortViewController fortViewCtrl;

		[SerializeField]
		private Text dialogTitle;

		[SerializeField]
		private Text smithTitle;

		[SerializeField]
		private Text infoLabel;

		[SerializeField]
		private Text currentSmithCountLabel;

		[SerializeField]
		private Text addedSmithCountLabel;

		[SerializeField]
		private Text curCrystalLabel;

		[SerializeField]
		private Text curStoneLabel;

		[SerializeField]
		private Text lackOfCrystalLabel;

		[SerializeField]
		private Button crystalButton;

		[SerializeField]
		private Button cancelButton;

		[SerializeField]
		private Text costCrystalLabel;

		[SerializeField]
		private Text costStoneLabel;

		[SerializeField]
		private GameObject purchaseStoneImage;

		[SerializeField]
		private GameObject usePaidStoneImage;

		private int cost;

		public void OnInit(FortViewController fortViewCtrl)
		{
		}

		public void OnBackButtonPressed()
		{
		}

		public void OnAddCreatorByStoneButtonPressed()
		{
		}

		public void OnAddCreatorByDiamondButtonPressed()
		{
		}
	}
}
