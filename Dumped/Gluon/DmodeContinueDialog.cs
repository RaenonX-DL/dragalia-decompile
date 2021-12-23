using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeContinueDialog : InGameDialogBase
	{
		public class Param
		{
			public string titleText;

			public string detailText;

			public Action onClickRetireButton;

			public Action onClickRetryButton;

			public void SetupContinueParam()
			{
			}

			public void SetupTimeUpParam()
			{
			}
		}

		[SerializeField]
		[Header("components")]
		private RectTransform frameRt;

		[SerializeField]
		private Text retryLifeText;

		[SerializeField]
		[Tooltip("å\u0086\u008dæ\u008c\u0091æ\u0088¦ã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button retryButton;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text detailText;

		public Param param;

		private RectTransform rootRt;

		public static DmodeContinueDialog Create(GameObject parent)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Open()
		{
		}

		public bool Close(bool isPlayCloseSE = false)
		{
			return default(bool);
		}

		protected override void SetEnableButtons(bool b)
		{
		}

		public void OnRetireButtonPressed()
		{
		}

		private bool ExecRetireButtonPressed()
		{
			return default(bool);
		}

		public void OnRetryButtonPressed()
		{
		}
	}
}
