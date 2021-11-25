using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class OptionLanguageSettingPopup : PopupBase
	{
		public enum FromType
		{
			FirstBoot,
			TitleMenu,
			Option
		}

		[SerializeField]
		public Text commentText;

		public PointerEventHandler cancelButton;

		public PointerEventHandler closeButton;

		public GameObject singleButtonGameObject;

		public GameObject doubleButtonGameObject;

		private Action<Localize.Language, Localize.Language> onOk;

		private FromType fromType;

		private Localize.Language savedLanguage;

		private Localize.Language toChangeLanguage;

		private Localize.Language savedVoiceLanguage;

		private Localize.Language toChangeVoiceLanguage;

		private bool isVoiceOn;

		public static OptionLanguageSettingPopup Create(Action<Localize.Language, Localize.Language> onOk, FromType fromType)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void RefreshDisplayLanguage()
		{
		}

		public void OnChangeDisplayLanguageButtonPressed()
		{
		}

		public void OnCancelButtonPressed()
		{
		}

		public void OnOKButtonPressed()
		{
		}
	}
}
