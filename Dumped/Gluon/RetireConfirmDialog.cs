using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RetireConfirmDialog : RetireConfirmDialogBase
	{
		[SerializeField]
		[Header("components")]
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
		private Text titleText;

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

		private static readonly Vector2[] FrameLayout;

		private static readonly Vector2[] DetailTextLayout;

		private const int numSackKind = 2;

		public static RetireConfirmDialog Create(GameObject parent)
		{
			return null;
		}

		protected override void Initialize()
		{
		}

		public void Update()
		{
		}

		private void LoadEventSackMaterial(int type)
		{
		}

		public override void Open()
		{
		}

		private void SetupLayout(Size type)
		{
		}

		private void UpdateItemCount(ref Text uiText, int count)
		{
		}

		public void OnClickOkButton()
		{
		}

		public void OnClickCancelButtonFromMultiConfirmDialog(CommonDialog dlg)
		{
		}

		public void OnClickOkButtonFromMultiConfirmDialog(CommonDialog dlg)
		{
		}
	}
}
