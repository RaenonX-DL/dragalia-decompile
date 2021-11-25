using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonFriendListCell : MonoBehaviour
	{
		[SerializeField]
		[Header("Icons")]
		public CommonIcon charaIcon;

		public CommonIcon skillIcon;

		public Text plusText;

		public Transform charaListSortDecoTrans;

		private CommonIconListSortDeco deco;

		[SerializeField]
		[Header("AnotherName")]
		public Image anotherNameIcon;

		public Text anotherNameText;

		[SerializeField]
		[Header("PlayerInfo")]
		public Text playerLevelText;

		public Text usernameText;

		public Text lastPlayTimeText;

		[SerializeField]
		[Header("Style")]
		public Image frameImage;

		public Text lastPlayTimeTextInDialog;

		[SerializeField]
		[Header("Guild")]
		public GameObject guildGO;

		public Text guildNameText;

		public RawImage guildEmblem;

		[SerializeField]
		private GameObject skillTextRoot;

		[SerializeField]
		private Text skillText;

		[SerializeField]
		private GameObject skillTextWithSelectButtonRoot;

		[SerializeField]
		private Text skillTextWithSelectButton;

		[SerializeField]
		private bool _isShowSelectButton;

		[SerializeField]
		private Image friendIcon;

		[SerializeField]
		private GameObject manaPointRootObj;

		private CommonFriendListCellData data;

		private bool isInDialogStyle;

		private const string prefabPath = "Prefabs/OutGame/CommonFriendListCell";

		private Text manaPointText;

		private const float ShortSkillDescTextWidth = 128f;

		private Button onClickEventButton;

		public bool isShowSelectButton
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private static CommonFriendListCell Create(CommonFriendListCellData data, Transform parent, bool isInDialogStyle = false)
		{
			return null;
		}

		public void SetupByData(CommonFriendListCellData data, bool isInDialogStyle = false)
		{
		}

		private void Start()
		{
		}

		public void UpdateContent(CommonFriendListCellData data, bool isShortSkillDesc = false)
		{
		}

		public void SetTouchEventButtonObjectReference(Button button)
		{
		}

		public void SetManaPointDisplay(CommonFriendListCellData data)
		{
		}

		public static string LastPlayTimeToString(long lastPlayTime)
		{
			return null;
		}

		public void OnSupportCharacterIconPressed()
		{
		}

		public void SetUnitDetailModelOnCreated(UnityAction onCreated)
		{
		}

		public void SetUnitDetailModelBackButtonOnClick(UnityAction onCreated)
		{
		}

		private void FriendGetSupportCharaDetailRequest()
		{
		}

		private void OnSuccess(FriendGetSupportCharaDetailResponse res)
		{
		}
	}
}
