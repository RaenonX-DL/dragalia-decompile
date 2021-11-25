using System;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ContinueDialog : InGameDialogBase
	{
		public class Param
		{
			public Action<ContinueDialog> retryButtonFunction;

			public Action<ContinueDialog> retireButtonFunction;

			public Action<ContinueDialog> continueButtonFunction;
		}

		[SerializeField]
		[Header("components")]
		protected RectTransform frameRt;

		[SerializeField]
		protected RectTransform stoneInfoRt;

		[SerializeField]
		protected RectTransform diaInfoRt;

		[SerializeField]
		protected Image frame;

		[SerializeField]
		protected Text title;

		[SerializeField]
		protected Text text;

		[SerializeField]
		protected Text remainCountText;

		[SerializeField]
		protected GameObject buttonBase;

		[SerializeField]
		protected Text retireButtonText;

		[SerializeField]
		protected Text retryButtonText;

		[SerializeField]
		protected Text stoneNumText;

		[SerializeField]
		protected Text stoneUseNumText;

		[SerializeField]
		protected Text diaNumText;

		[SerializeField]
		protected Text diaUseNumText;

		[SerializeField]
		protected Button retireButton;

		[SerializeField]
		protected Button retryButton;

		[SerializeField]
		protected Button stoneButton;

		[SerializeField]
		protected Button diaButton;

		[SerializeField]
		protected Button cameraButton;

		protected Action<ContinueDialog> retryButtonFunction;

		protected Action<ContinueDialog> retireButtonFunction;

		protected Action<ContinueDialog> continueButtonFunction;

		private RectTransform rootRt;

		private Param param;

		private CommonDialog _commonDialog;

		private CommonDialog.Param _commonDialogParam;

		private RetireConfirmDialog _retireConfirmDialog;

		private RetireConfirmDialog.Param _retireConfirmDialogParam;

		private ContinueCameraDialog _continueCameraDialog;

		private ContinueCameraDialog.Param _continueCameraDialogParam;

		private ContinueConfirmDialog _continueConfirmDialog;

		private ContinueConfirmDialog.Param _continueConfirmDialogParam;

		private static readonly Color defaultTextColor;

		private static readonly Color limitedTextColor;

		private const float brTextPosY = 100f;

		public static ContinueDialog Create(GameObject parent)
		{
			return null;
		}

		protected virtual void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void Update()
		{
		}

		public void Open(Param param)
		{
		}

		public void Close()
		{
		}

		public void CloseAll()
		{
		}

		public bool IsCloseAll()
		{
			return default(bool);
		}

		public void OnRetryButtonPressed()
		{
		}

		public void OnRetireButtonPressed()
		{
		}

		private void ExecRetireButtonPressed()
		{
		}

		public void OnCrystalButtonPressed()
		{
		}

		public void OnDiamondButtonPressed()
		{
		}

		public void OnCameraButtonPressed()
		{
		}

		private void OnRetryButtonPressedFromRetireConfirmDialog(RetireConfirmDialog sender)
		{
		}

		private void OnRetireButtonPressedFromRetireConfirmDialog(RetireConfirmDialog sender)
		{
		}

		private void OnCancelButtonPressedFromRetireConfirmDialog(RetireConfirmDialog sender)
		{
		}

		private void OnRetryButtonPressedFromMultiRetireConfirmDialog(RetireConfirmDialog sender)
		{
		}

		private void OnCancelButtonPressedFromMultiRetireConfirmDialog(RetireConfirmDialog sender)
		{
		}

		private void OnBackButtonPressedFromContinueCameraDialog(ContinueCameraDialog sender)
		{
		}

		private bool IsEnablePress()
		{
			return default(bool);
		}

		private void SetEnableButtons(bool b)
		{
		}

		private void OpenContinueConfirmDialog(bool isCrystal)
		{
		}

		private void OnCancelButtonPressedFromContinueConfirmDialog(ContinueConfirmDialog sender)
		{
		}

		private void OnConsumeCrystalButtonPressedFromContinueConfirmDialog(ContinueConfirmDialog sender)
		{
		}

		private void OnConsumeDragonDiamondButtonPressedFromContinueConfirmDialog(ContinueConfirmDialog sender)
		{
		}

		private void OnDungeonRetryCallback(DungeonRetryResponse res)
		{
		}

		private void OpenPurchaseDragonDiamondDialog()
		{
		}

		private void OnCancelButtonPressedFromPurchaseDragonDiamondDialog(CommonDialog sender)
		{
		}

		private void OnPurchaseButtonPressedFromPurchaseDragonDiamondDialog(CommonDialog sender)
		{
		}

		private void OnCancelButtonPressedFromPurchaseStonePopup()
		{
		}

		private void OnPurchaseButtonPressedFromPurchaseStonePopup()
		{
		}

		private void OpenContinueLimitInfoDialog()
		{
		}

		private void OnCloseButtonPressedFromContinuelimitInfoDialog(CommonDialog dlg)
		{
		}
	}
}
