using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RecoverStaminaMultipleItemConfirmPopup : PopupBase
	{
		[SerializeField]
		[Header("Contents")]
		private Text commentText;

		[SerializeField]
		private GameObject LackStaminaTextParent;

		[SerializeField]
		private Text insufficientStaminaCommentText;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		[Header("BeforeAfter")]
		private Text beforeStaminaText;

		[SerializeField]
		private Text afterStaminaText;

		[SerializeField]
		private Text staminaTabText;

		[SerializeField]
		[Header("OnOff")]
		private Text staminaExceedsLimitText;

		[SerializeField]
		private Button useButton;

		[SerializeField]
		private RecoverStaminaMultiItemListController controller;

		private int _afterStamina;

		private bool isCreateRecoverDonePopup;

		private StaminaUtilBase staminaUtil;

		private int beforeStamina
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int afterStamina
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int absoluteStaminaMax
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static RecoverStaminaMultipleItemConfirmPopup CreateWithModel(bool isCreateRecoverDonePopup)
		{
			return null;
		}

		private void Setup(bool isCreateRecoverDonePopup)
		{
		}

		private bool IsUseButtonInteractable()
		{
			return default(bool);
		}

		protected override void Start()
		{
		}

		public void OnUseButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
