using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class FacilityDetailDialogController : FacilityDialogControllerBase
	{
		public enum DialogType
		{
			FacilityDetail,
			BuildCancelConfirm,
			LevelUpCancelConfirm,
			ToStoreConfirm
		}

		private enum UpdateType
		{
			None,
			BuildDuration,
			PassedIncomeTime
		}

		private DialogType dialogType;

		[SerializeField]
		private Button cancelButton;

		[SerializeField]
		private Button okButton;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text infoText;

		[SerializeField]
		private GameObject infoOnlyOffset;

		[SerializeField]
		private GameObject buildDurationRoot;

		[SerializeField]
		private Text buildDurationLabel;

		[SerializeField]
		private GameObject buildDurationOnlyOffset;

		[SerializeField]
		private GameObject maxIncomeTimeRoot;

		[SerializeField]
		private GameObject eventEffectRoot;

		[SerializeField]
		private Text eventTitleText;

		[SerializeField]
		private Text eventEffectText;

		[SerializeField]
		private Button gotoFortButton;

		[SerializeField]
		private Text gotoFortButtonText;

		private FacilityViewController facilityCtrl;

		private const int frameSizeWithEventEffect = 900;

		public Action onDialogClosed;

		private UpdateType curUpdateType;

		private FortBuildGaugeController fortBuildGaugeController;

		private readonly Vector3 leftButtonPos;

		private const float mainFacilityTextSpace = 40f;

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void CloseDialog()
		{
		}

		public void SetContent(FacilityViewController facilityVC, DialogType type, bool showGotoFortButton = false)
		{
		}

		public void SetContent(Facility facility, DialogType type, bool showGotoFortButton = false)
		{
		}

		public void onGotoFortButtonTouched()
		{
		}

		private void SetCancelButtonPosLeft()
		{
		}

		public void AddOnOkButtonCallback(UnityAction callBack)
		{
		}
	}
}
