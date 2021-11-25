using System.Collections;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class WebViewScene : SceneBase
	{
		public enum WebViewCategory
		{
			None = -1,
			Comic,
			HelpComic,
			AdvStory
		}

		[SerializeField]
		private Rect margin;

		[SerializeField]
		private Text noInfoText;

		[SerializeField]
		private RectTransform webViewCanvasRect;

		[SerializeField]
		private RectTransform borderRectTrans;

		private bool isVisibleClientUI;

		private bool isInitialized;

		private const string urlParameterForIPhoneX = "&device=iphoneX";

		public static WebViewCategory currentCategory;

		private WebViewCategory tempCategory;

		private readonly string[] webViewUrlFunctionName;

		private const string webViewSceneName = "WebView";

		private const string msgInfomation = "Information_";

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private void InitSetting(WebViewCategory category)
		{
		}

		private void SetMargin()
		{
		}

		public void WebMessageCallBack(string msg)
		{
		}

		public static void SceneTransitionByWebViewMessage(string msg)
		{
		}

		public static void ReleaseCreatePopup(QuestEventElement qee)
		{
		}

		public static void ReleaseCreatePopup(QuestEventType type, QuestEventGroupElement qee)
		{
		}

		public static bool PlaySoundByWebViewMessage(string msg)
		{
			return default(bool);
		}

		private void OnDestroy()
		{
		}

		public override void OnPopupOpened()
		{
		}

		public override void OnPopupClosed()
		{
		}

		private void SetVisibleClientUI(bool visible)
		{
		}

		private static UnityAction GetShowWebViewPopupAction(WebViewPopup.WebViewCategory category)
		{
			return null;
		}

		private static UnityAction GetShowInfomationPopupAction(int informationId)
		{
			return null;
		}
	}
}
