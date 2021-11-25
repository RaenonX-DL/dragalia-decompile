using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FortDetailDialogController : PopupBase
	{
		[SerializeField]
		private TabViewBase tabView;

		[SerializeField]
		private Text facilityCountLable;

		[SerializeField]
		private Text closeButtonText;

		[SerializeField]
		private Text levelText;

		[SerializeField]
		private Text totalLevelText;

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void OnBackButtonPressed()
		{
		}
	}
}
