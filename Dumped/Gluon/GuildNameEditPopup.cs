using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildNameEditPopup : PopupBase
	{
		public enum Type
		{
			Name,
			Motto,
			Notice
		}

		[SerializeField]
		[Header("OnOff")]
		public GameObject[] nameEditGOs;

		public GameObject[] mottoEditGOs;

		public GameObject[] noticeEditGOs;

		[SerializeField]
		[Header("Input")]
		public InputField inputField;

		public Text countText;

		public RectTransform inputFieldRT;

		public Button okButton;

		public Text normalizingComment;

		private Action<string> onOK;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildNameEditPopup";

		private GuildModel.GuildOption option;

		private Type type;

		private int textLimit;

		public const int textInputAllowance = 40;

		public static GuildNameEditPopup Create(Type type, GuildModel.GuildOption option, Action<string> onOK)
		{
			return null;
		}

		private bool IsTextCountNeedNormalize()
		{
			return default(bool);
		}

		protected override void Start()
		{
		}

		private string GetTrimmedString(string s)
		{
			return null;
		}

		private int GetTextLength(string s)
		{
			return default(int);
		}

		private void SetCountText()
		{
		}

		private void AdjustHeight()
		{
		}

		public void OnOKButtonPressed()
		{
		}
	}
}
