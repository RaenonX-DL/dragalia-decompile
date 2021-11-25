using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildPenaltyAppliedWarningPopup : PopupBase
	{
		[SerializeField]
		private HyperLinkText content;

		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private Text deletedContentSectionComment;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildPenaltyAppliedWarningPopup";

		private const string RegexURL = "https?://(?:[!-~]+\\.)+[!-~]+";

		private readonly string textColor;

		private Action onClose;

		private const float en_us_add_X = 0f;

		private const float en_us_add_Y = -0.8f;

		private const float zn_cn_add_Y = 1.6f;

		private const float en_us_default_X = 0f;

		private const float en_us_default_Y = -2f;

		public static bool CreateIfNeededAsync(Action onDone)
		{
			return default(bool);
		}

		public static GuildPenaltyAppliedWarningPopup Create(string content, int penaltyTextType, Action onClose)
		{
			return null;
		}

		private void Awake()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnHyperLinkClick(string url)
		{
		}
	}
}
