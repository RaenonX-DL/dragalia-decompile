using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InformationPopup : PopupBase
	{
		public enum WebViewCategory
		{
			Information,
			BattleRoyal
		}

		private const string prefabPath = "Prefabs/OutGame/TitleMenu/InformationPopup";

		[SerializeField]
		private Rect margin;

		[SerializeField]
		private RectTransform popupRect;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text noInfoText;

		[SerializeField]
		private Text toListText;

		[SerializeField]
		private ButtonSound toListSound;

		[SerializeField]
		public Toggle notDisplayTodayToggle;

		private const string prefsKeyNotDisplayTodaySettingKey = "NotDisplayTodaySetting";

		public const string detailPath = "#detail/{0}";

		private bool isShowTop;

		private bool isLoaded;

		private static int _notDisplayTodaySetting;

		public static bool isPreload;

		public static bool isPreloadSuccess;

		public static bool isPreloadError;

		public static bool isCheckPreloadUrl;

		private readonly Localize.TextId[] webViewTitleTextId;

		private readonly string[] webViewUrlFunctionName;

		private const string urlParameterForNoTransition = "&page=title";

		private static int NotDisplayTodayNum => default(int);

		private void Awake()
		{
		}

		public static InformationPopup Create()
		{
			return null;
		}

		public void InitSetting(WebViewCategory category, int detailId = 0)
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

		private bool ChangeToListTextByWebViewMessage(string msg)
		{
			return default(bool);
		}

		public void OnToListButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnToggleClickedNotDisplayToday(bool bOn)
		{
		}

		public static bool IsNotDisplayTodaySetting()
		{
			return default(bool);
		}

		public static bool IsDisplayedToday()
		{
			return default(bool);
		}

		private void SetShowTop(bool isTop)
		{
		}

		private IEnumerator SetButtonSound()
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}
	}
}
