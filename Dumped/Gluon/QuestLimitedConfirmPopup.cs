using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestLimitedConfirmPopup : PopupBase
	{
		public enum LimitedQuestType
		{
			OnlyElementalType,
			OnlyWeaponType,
			ElementalAndWeaponType,
			None,
			Max
		}

		private const string prefabPath = "Prefabs/OutGame/QuestPrepare/QuestLimitedConfirmPopup";

		[SerializeField]
		[Header("Common")]
		private Text popupTitle;

		[SerializeField]
		private Button cancelButton;

		[SerializeField]
		private Text cancelText;

		[SerializeField]
		private Button changePartyButton;

		[SerializeField]
		private Text changePartyText;

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private Text closeText;

		[SerializeField]
		[Header("Icon in Text")]
		private Image titleElementIcon;

		[SerializeField]
		[Header("First Text")]
		private Text firstConfirmText;

		[SerializeField]
		private Image firstElementalIcon;

		[SerializeField]
		private LocalizeTextLayoutPadding iconVerticalPadding;

		[SerializeField]
		[Header("Second Text")]
		private Text secondConfirmText;

		[SerializeField]
		private Image secondElementalIcon;

		[SerializeField]
		private Text forCalcText;

		[SerializeField]
		private Text forCalcTtitleText;

		[SerializeField]
		[Header("Limited WeaponType")]
		private GameObject limitedWeaponTypeTitleIconPanel;

		[SerializeField]
		private GameObject limitedWeaponTypeFirstIconPanel;

		[SerializeField]
		private GameObject limitedWeaponTypeSecondIconPanel;

		[SerializeField]
		private Image limitedWeaponTypeBaseIcon;

		[SerializeField]
		private Image thirdElementalIcon;

		private string firstElementStr;

		private string secondElementStr;

		private UnityEvent cancelButtonPressed;

		private UnityEvent changePartyButtonPressed;

		private static readonly Localize.TextId[] limitedElementalTypeFirstTextIdList;

		private static readonly Localize.TextId[] limitedElementalTypeSecondTextIdList;

		private static readonly Localize.TextId[] limitedElementalAndWeaponTypeTextIdList;

		private LimitedQuestType limitedQuestType;

		public static QuestLimitedConfirmPopup Create(ElementalType limitedElementalType, List<WeaponType> limitedWeaponTypeList, bool setChangePartyButton)
		{
			return null;
		}

		private void SetupTextAndIcon(ElementalType limitedElementalType, List<WeaponType> limitedWeaponTypeList)
		{
		}

		private void SetupLimitedElementalTextAndIcon(ElementalType limitedElementalType)
		{
		}

		private void SetupLimitedElementalAndWeaponTextAndIcon(ElementalType limitedElementalType, List<WeaponType> limitedWeaponTypeList)
		{
		}

		private void BuildLayout()
		{
		}

		private new void Start()
		{
		}

		private void InitializeButtons(bool setPartyChangeButton)
		{
		}

		public void SetCallback(UnityAction closeCallback)
		{
		}

		public void SetCallback(UnityAction cancelCallback, UnityAction changePartyCallback)
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		public void OnChangePartyButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
