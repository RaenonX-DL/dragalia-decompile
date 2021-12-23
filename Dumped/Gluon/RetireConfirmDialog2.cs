using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RetireConfirmDialog2 : RetireConfirmDialogBase
	{
		[SerializeField]
		[Header("components")]
		private RectTransform retireRootRt;

		[SerializeField]
		private RectTransform retryRootRt;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		[Header("retire components")]
		private Button retireCancelButton;

		[SerializeField]
		private Button retireOkButton;

		[SerializeField]
		private Text retireDPointText;

		[SerializeField]
		private Text retireDPointRareText;

		[SerializeField]
		private Text retireScoreText;

		[SerializeField]
		[Header("retry components")]
		private Button retryCancelButton;

		[SerializeField]
		private Button retryTopButton;

		[SerializeField]
		private Button retryFloorButton;

		[SerializeField]
		private Text retryLifeText;

		public static RetireConfirmDialog2 Create(GameObject parent)
		{
			return null;
		}

		public override void Open()
		{
		}

		private void SetActive(RectTransform rt, bool b)
		{
		}

		public void OnClickRetireOkButton()
		{
		}

		public void OnClickRetryTopButton()
		{
		}

		public void OnClickRetryFloorButton()
		{
		}
	}
}
