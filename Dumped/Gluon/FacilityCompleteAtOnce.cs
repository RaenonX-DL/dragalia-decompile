using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FacilityCompleteAtOnce : PopupBase
	{
		private const int necessaryCostOfDragonHammer = 1;

		[SerializeField]
		private Text titleLabel;

		[SerializeField]
		private Button cancelButton;

		[SerializeField]
		private Button useCrystalButton;

		[SerializeField]
		private Button useStoneButton;

		[SerializeField]
		private Button useDragonHammerButton;

		[SerializeField]
		private Text content;

		[SerializeField]
		private Text curCrystalLabel;

		[SerializeField]
		private Text curStoneLabel;

		[SerializeField]
		private Text curDragonHammerLabel;

		[SerializeField]
		private Text costCrystalLabel;

		[SerializeField]
		private Text costStoneLabel;

		[SerializeField]
		private Text costDragonHammerLabel;

		private FacilityViewController facilityCtrl;

		protected override void Start()
		{
		}

		public void SetContent(FacilityViewController facilityVC)
		{
		}
	}
}
