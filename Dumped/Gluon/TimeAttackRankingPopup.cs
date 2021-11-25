using System.Collections;
using Cute.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TimeAttackRankingPopup : PopupBase
	{
		public enum WebViewCategory
		{
			timeAttackRanking,
			timeAttackRankingEvent
		}

		private const string prefabPath = "Prefabs/OutGame/TitleMenu/TimeAttackRankingPopup";

		[SerializeField]
		private Rect margin;

		[SerializeField]
		private RectTransform popupRect;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text noInfoText;

		private int questId;

		private WebViewCategory categoryType;

		private readonly Localize.TextId[] webViewTitleTextId;

		private readonly string[] webViewUrlFunctionName;

		private const string urlParameterFormatForQuestId = "&quest_id={0}";

		private const string urlParameterFormatForViewerId = "&viewer_id={0}";

		private void Awake()
		{
		}

		public static TimeAttackRankingPopup Create()
		{
			return null;
		}

		public void InitSetting(WebViewCategory category, int id = 0)
		{
		}

		private IEnumerator ShowWebView(WebViewCategory category, string path)
		{
			return null;
		}

		private void SetMargin()
		{
		}

		public void WebMessageCallBack(string msg)
		{
		}

		public void OnRewardButtonPressed()
		{
		}

		public void OnHelpButtonPressed()
		{
		}

		private void OnHide()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public static void OnError(ErrorType errorType, int resultCode)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
