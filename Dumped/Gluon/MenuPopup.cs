using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class MenuPopup : CommonPopup, ICustomMessage
	{
		private enum MenuContents
		{
			None = -1,
			Item,
			PlayerInfo,
			Friend,
			Help,
			Option,
			Other,
			Shop,
			Guild,
			Album,
			Comic,
			HelpComic,
			AdvStory,
			Max
		}

		[SerializeField]
		private Text[] contentsText;

		[SerializeField]
		private Badge inquireBadge;

		private const string prefsKeyLastOpenComicEpisordNumKey = "LastOpenComicEpisordNum";

		[SerializeField]
		private Badge friendBadge;

		[SerializeField]
		private Badge shopBadge;

		[SerializeField]
		private Button guildButton;

		[SerializeField]
		private GameObject guildBadge;

		[SerializeField]
		private GameObject guildInviteBadge;

		[SerializeField]
		private Badge albumBadge;

		[SerializeField]
		private Text comicBalloonText;

		[SerializeField]
		private Text helpComicBalloonText;

		[SerializeField]
		private PointerEventHandler comicButton;

		[SerializeField]
		private TweenSequenceVisualizer animBalloonButtonPressed;

		[SerializeField]
		private TweenSequenceVisualizer animBalloonDefault;

		public static UnityAction<UnityAction> changeSceneCallback;

		private Footer.MenuTab tempCurrentMenuTab;

		public static MenuPopup Create()
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private void InitSetting()
		{
		}

		private void MenuContentsButtonPressed(int contentsIndex)
		{
		}

		public static void IrregularLoadScene(UnityAction loadSceneCallback)
		{
		}

		private static void PrepareLoadScene()
		{
		}

		private void RequestCartoonLatest(UnityAction successCallback)
		{
		}

		private void OnError(ErrorType errorType, int resultCode)
		{
		}

		private int GetComicNum()
		{
			return default(int);
		}

		private string GetMenuContentsText(MenuContents content)
		{
			return null;
		}

		public void UpdateBadge(bool hasNew)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public static bool IsShowShopBadge()
		{
			return default(bool);
		}

		public static bool IsShowAlbumBadge()
		{
			return default(bool);
		}

		public static bool IsShowMenuBadge()
		{
			return default(bool);
		}
	}
}
