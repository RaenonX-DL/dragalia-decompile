using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ConfirmDialogCtrl : FacilityDialogControllerBase, ICustomMessage
	{
		public enum ConfirmDialogType
		{
			Build,
			LevelUp
		}

		[SerializeField]
		private Text titleLabel;

		[SerializeField]
		private Text confirmLabel;

		[SerializeField]
		private Text contentLabel;

		[SerializeField]
		private Text okButtonLabel;

		[SerializeField]
		private Text cancelButtonLabel;

		[SerializeField]
		private Text materialRequiredTitle;

		[SerializeField]
		private Text timeRequiredTitle;

		[SerializeField]
		private Text buildDurationLabel;

		[SerializeField]
		private GameObject eventEffectRoot;

		[SerializeField]
		private Text eventTitleText;

		[SerializeField]
		private Text eventEffectText;

		[SerializeField]
		private FacilityNecessaryMaterialContent necessaryMaterialContent;

		[SerializeField]
		private GameObject necessaryMaterialSpacer;

		[SerializeField]
		private GameObject withoutMaterialSpacer;

		private FortScene fortScene;

		public Action<Facility> okButtonPressed;

		[SerializeField]
		public UnityEvent cancelButtonPressed;

		public ConfirmDialogType type;

		[SerializeField]
		private Button cancelButton;

		private FortModel.BuildFacilityResult buildResult;

		private Button okButton;

		private Facility nextFacility;

		[SerializeField]
		private GameObject beginnerBuildCampaignIcon;

		[SerializeField]
		private Color beginnerBuildCampaignColor;

		private bool isBeginnerBuildTime;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnInit(ConfirmDialogType type, FortModel.BuildFacilityResult buildResult)
		{
		}

		public void OnOKButtonPressed()
		{
		}

		private void OnEndBeginnerBuildTime()
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public override bool SetContent(Facility facility, [Optional] Facility nextLevelFacility)
		{
			return default(bool);
		}

		private void SetEventEffectInfo(Facility facility, Facility nextLevelFacility)
		{
		}

		private void SetContentInfo(Facility facility, bool isLevelUp)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
