using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RetireConfirmDialog : InGameDialogBase
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

			public string cancelButtonText;

			public Action<RetireConfirmDialog> okButtonFunction;

			public Action<RetireConfirmDialog> cancelButtonFunction;

			public void SetupRetryParam()
			{
			}

			public void SetupRetireParam()
			{
			}
		}

		[SerializeField]
		[Header("components")]
		private RectTransform frameRt;

		[SerializeField]
		private GameObject buttonBase;

		[SerializeField]
		private Text cancelButtonText;

		[SerializeField]
		private Text okButtonText;

		[SerializeField]
		private Button cancelButton;

		[SerializeField]
		private Button okButton;

		[SerializeField]
		private Text title;

		[SerializeField]
		private Text detailText;

		[SerializeField]
		private Text manaNum;

		[SerializeField]
		private Text coinNum;

		[SerializeField]
		private Text[] itemText;

		[SerializeField]
		private Image frameImae;

		[SerializeField]
		private Image[] itemImage;

		[SerializeField]
		[Header("parameter")]
		private Color32 selectedColor;

		private Action<RetireConfirmDialog> cancelButtonFunction;

		private Action<RetireConfirmDialog> okButtonFunction;

		private RectTransform rootRt;

		private bool isRetire;

		private CommonDialog commonDialog;

		private CommonDialog.Param commonDialogParam;

		private int backKeyEventId;

		private static int backKeyEventCount;

		private const int numKind = 2;

		private const int numItem = 6;

		private static readonly Vector2[] FrameLayout;

		private static readonly Vector2[] DetailTextLayout;

		public static RetireConfirmDialog Create(GameObject parent)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Update()
		{
		}

		private void LoadEventSackMaterial(int type)
		{
		}

		public void Open(Param param)
		{
		}

		private void SetupLayout(Size type)
		{
		}

		public void Close(bool isPlayCloseSE = false)
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateItemCount(ref Text uiText, int count)
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		private void ExecCancelButtonPressed()
		{
		}

		public void OnOkButtonPressed()
		{
		}

		public void OnCancelButtonPressedFromMultiConfirmDialog(CommonDialog dlg)
		{
		}

		public void OnOkButtonPressedFromMultiConfirmDialog(CommonDialog dlg)
		{
		}

		public bool IsOpenMultiConfirmationDialog()
		{
			return default(bool);
		}

		private bool IsEnablePress()
		{
			return default(bool);
		}

		private void SetEnableButtons(bool b)
		{
		}
	}
}
