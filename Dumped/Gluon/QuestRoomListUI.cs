using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestRoomListUI : MonoBehaviour
	{
		[SerializeField]
		private Text questNumber;

		[SerializeField]
		private Image elementsSprite;

		[SerializeField]
		private Image elementsSprite2;

		[SerializeField]
		private Text questName;

		[SerializeField]
		private Image eventElementsSprite;

		[SerializeField]
		private Image eventElementsSprite2;

		[SerializeField]
		private Text eventQuestName;

		[SerializeField]
		private Image questThumbnailImage;

		[SerializeField]
		private UiImageExchanger cellFrame;

		[SerializeField]
		private CommonIcon charaIcon;

		[SerializeField]
		private Text userLevel;

		[SerializeField]
		private Text userName;

		[SerializeField]
		private Image[] numberOfPeopleImage;

		[SerializeField]
		private List<Sprite> numberOfPeopleSprite;

		[SerializeField]
		private Image selectArrow;

		[SerializeField]
		private Image grayoutTex;

		[SerializeField]
		[Header("BattlePower")]
		public GameObject battlePowerRoot;

		public Image battlePowerFrame;

		public Text battlePowerText;

		public CircleOutline battlePowerOutline;

		public GameObject requiredBattlePowerIcon;

		public GameObject recommendedBattlePowerIcon;

		[SerializeField]
		protected Color requiredBackGroundColor;

		[SerializeField]
		protected Color recommendedBackGroundColor;

		[SerializeField]
		protected Color requiredOutlineColor;

		[SerializeField]
		protected Color recommendedOutlineColor;

		[SerializeField]
		protected Color lackOfPartyPowerColor;

		[SerializeField]
		protected Color defaultPowerColor;

		[SerializeField]
		[Header("BP")]
		public GameObject[] needBPFrameList;

		[SerializeField]
		private Image[] bpBaseImages;

		[SerializeField]
		private Image[] bpOnImages;

		[SerializeField]
		private Image[] bpRedImages;

		[SerializeField]
		[Header("ForIdInput")]
		public Button cellButton;

		public GameObject detailButtonGO;

		[SerializeField]
		[Header("Item")]
		private GameObject questItemIconRoot;

		[SerializeField]
		private Image questItemIconImage;

		[SerializeField]
		private Text questItemNumText;

		[SerializeField]
		[Header("Guild")]
		private GameObject guildIconRoot;

		private const int MAX_MEMBER_NUM = 4;

		private int questId;

		private QuestSelectScene.Difficulty difficult;

		public Image SelectArrow => null;

		public GameObject blackObjectGO => null;

		public void UpdateContent(RoomListData itemData)
		{
		}

		public void GreyOutSetting()
		{
		}

		public void SetDisablePress()
		{
		}
	}
}
