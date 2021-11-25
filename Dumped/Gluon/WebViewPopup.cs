using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class WebViewPopup : PopupBase
	{
		public enum WebViewCategory
		{
			Help,
			Terms,
			Copyright,
			PrivacyPolicy,
			PaymentServicesAct,
			SpecifiedCommercialTransactionAct,
			HealthPrecautions,
			Faq,
			SummonsInformation,
			InquiryAttention,
			questInfo,
			timeAttackReward,
			dragonBattleInfo,
			unionBunus,
			recommendedAbilityCrest,
			timeAttackRankingEventReward
		}

		public enum HelpAnchor
		{
			None,
			TimeAttack
		}

		private const string prefabPath = "Prefabs/OutGame/TitleMenu/WebViewPopup";

		[SerializeField]
		private Rect margin;

		[SerializeField]
		private RectTransform popupRect;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text noInfoText;

		[SerializeField]
		private RectTransform content;

		private readonly Localize.TextId[] webViewTitleTextId;

		private readonly string[] webViewUrlFunctionName;

		private const string urlParameterFormatForId = "&id={0}";

		private const string urlParameterFormatForCurrency = "&cur={0}";

		private const string urlParameterFormatForVersion = "&version={0}";

		private const string urlParameterFormatForQuestId = "&quest_id={0}";

		private const string urlParameterFormatDragonBattleInfoId = "&quest_group_id={0}";

		private static readonly Dictionary<HelpAnchor, string> urlParameterFormatForHelp;

		private void Awake()
		{
		}

		public static WebViewPopup Create()
		{
			return null;
		}

		public void InitSetting(WebViewCategory category, int id = 0, HelpAnchor anchor = HelpAnchor.None)
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

		public void OnCloseButtonPressed()
		{
		}

		public static void RequestPaymentGetListForGetCurrencySymbol([Optional] UnityAction successCallback)
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
