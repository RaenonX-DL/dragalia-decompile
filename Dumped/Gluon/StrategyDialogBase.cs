using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public abstract class StrategyDialogBase : InGameDialogBase
	{
		public class Param
		{
			public Action onClickRetryButton;

			public Action onClickRetireButton;

			public Action onClickCloseButton;
		}

		[SerializeField]
		[Header("components")]
		protected RectTransform headRt;

		[SerializeField]
		protected RectTransform frameRt;

		[SerializeField]
		protected Text titleText;

		[SerializeField]
		[Tooltip("å\u0086\u008dæ\u008c\u0091æ\u0088¦ã\u0083\u009cã\u0082¿ã\u0083³")]
		protected Button retryButton;

		[SerializeField]
		[Tooltip("ã\u0083ªã\u0082¿ã\u0082¤ã\u0082¢ã\u0083\u009cã\u0082¿ã\u0083³")]
		protected Button retireButton;

		[SerializeField]
		[Tooltip("é\u0096\u0089ã\u0081\u0098ã\u0082\u008bã\u0083\u009cã\u0082¿ã\u0083³")]
		protected Button closeButton;

		public Param param;

		protected RectTransform rootRt;

		protected Text retryButtonText;

		protected Text retireButtonText;

		protected Text closeButtonText;

		protected CommonDialog performanceModeDialog;

		protected CommonDialog.Param performanceModeDialogParam;

		protected InGameOptionPopup optionPopup;

		protected bool isSwap;

		protected virtual void Initialize()
		{
		}

		public virtual void Open()
		{
		}

		public virtual bool Close(bool isPlayCloseSE = false)
		{
			return default(bool);
		}

		public void OnCloseButtonPressed()
		{
		}

		protected virtual bool ExecCloseButtonPressed()
		{
			return default(bool);
		}

		public void OnRetryButtonPressed()
		{
		}

		protected virtual bool ExecRetryButtonPressed()
		{
			return default(bool);
		}

		public void OnRetireButtonPressed()
		{
		}

		protected virtual bool ExecRetireButtonPressed()
		{
			return default(bool);
		}

		public void OnOptionButtonPressed()
		{
		}

		protected void OnClosedButtonPressedFromOptionDialog()
		{
		}

		protected void OnClosedButtonPressedFromPerformanceModeDialog(CommonDialog dlg)
		{
		}

		protected override void SetEnableButtons(bool b)
		{
		}
	}
}
