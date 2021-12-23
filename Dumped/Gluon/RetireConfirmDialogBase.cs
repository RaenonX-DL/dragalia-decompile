using System;
using UnityEngine;

namespace Gluon
{
	public abstract class RetireConfirmDialogBase : InGameDialogBase
	{
		public enum Size
		{
			M,
			L
		}

		public class Param
		{
			public bool isRetire;

			public Size size;

			public string title;

			public string detail;

			public string okButtonText;

			public string okButtonText2;

			public string cancelButtonText;

			public Action onClickOkButton;

			public Action onClickOkButton2;

			public Action onClickCancelButton;

			public void Reset()
			{
			}

			public void SetupRetryParam()
			{
			}

			public void SetupRetireParam()
			{
			}
		}

		[SerializeField]
		[Header("components")]
		protected RectTransform frameRt;

		public Param param;

		protected RectTransform rootRt;

		protected CommonDialog commonDialog;

		protected CommonDialog.Param commonDialogParam;

		protected int backKeyEventId;

		protected static int backKeyEventCount;

		protected virtual void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public virtual void Open()
		{
		}

		public virtual bool Close(bool isPlayCloseSE = false)
		{
			return default(bool);
		}

		public bool IsOpenMultiConfirmationDialog()
		{
			return default(bool);
		}

		protected override void SetEnableButtons(bool b)
		{
		}

		public void OnClickCancelButton()
		{
		}

		protected void ExecCancelButtonPressed()
		{
		}
	}
}
