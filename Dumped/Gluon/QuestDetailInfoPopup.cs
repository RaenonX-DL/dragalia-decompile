using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestDetailInfoPopup : CommonPopup
	{
		public class SortAbnormal
		{
			public AbnormalStatusType type;

			public int registAbnormalRate;

			public int sortId;
		}

		public ButtonSprite[] missionClearButtons;

		public GameObject missionDetailNode;

		public Text[] missionTexts;

		public Image elementImageIndex;

		public Image element2ImageIndex;

		public Image elementImageSimple;

		public Image element2ImageSimple;

		public QuestDifficultyImageSetter difficultyImageSetter;

		public Text uiQuestIndex;

		public Text uiTitleIndex;

		public Text uiTitleSimple;

		public GameObject uiTitleSimpleRoot;

		public Text uiClearCondition;

		public Text uiLoseCondition;

		public Text uiRebornCondition;

		public GameObject specialRuleObject;

		public GameObject specialRule2Object;

		public GameObject uiTreasure;

		public Text uiTreasureText;

		[SerializeField]
		private Text uiRewardCautionText;

		public GameObject uiTreasureNode;

		public GameObject uiBouns;

		public Text uiBounsText;

		public GameObject uiBounsNode;

		public GameObject uiDiscover;

		public Text uiDiscoverText;

		public GameObject uiDiscoverNode;

		public GameObject uiDragonSpher;

		public GameObject uiDragonSpherNode;

		public GameObject uiMissionReward;

		public Text uiMissionRewardText;

		public GameObject uiMissionRewardNode;

		public GameObject uiMissionCompleteReward;

		public Text uiMissionCompleteRewardText;

		public GameObject uiMissionCompleteRewardNode;

		public GameObject uiFirstClearReward;

		public Text uiFirstClearRewardText;

		public GameObject uiFirstClearRewardNode;

		public GameObject uiQuestCarryReward;

		public Text uiQuestCarryRewardText;

		public GameObject uiQuestCarryRewardNode;

		[SerializeField]
		private GameObject guestImage;

		[SerializeField]
		protected Image recommendedPowerIcon;

		[SerializeField]
		protected Image necessaryPowerIcon;

		[SerializeField]
		protected Image questPowerValueBackGround;

		[SerializeField]
		private Text uiPowerText;

		[SerializeField]
		[Header("Titles")]
		private Text questDetailTitle;

		[SerializeField]
		private Text clearConditionTitle;

		[SerializeField]
		private Text failureConditionTitle;

		[SerializeField]
		private Text missionDetailTitle;

		[SerializeField]
		private Text treasureTitle;

		[SerializeField]
		private Text discoverTitle;

		[SerializeField]
		private Text dailyTitle;

		[SerializeField]
		private Text missionRewardTitle;

		[SerializeField]
		private Text missionCompleteRewardTitle;

		[SerializeField]
		private Text firstClearRewardTitle;

		[SerializeField]
		[Header("Reborn")]
		private GameObject[] rebornSections;

		[SerializeField]
		private Text[] rebornTitles;

		[SerializeField]
		private Transform[] rebornRewardParents;

		[SerializeField]
		[Header("Others")]
		private GameObject abnormalStatusTitleNode;

		[SerializeField]
		private GameObject abnormalStatusNode;

		[SerializeField]
		private GameObject abnormalStatusCell;

		[SerializeField]
		private GameObject effectiveAbnormalStatusTitleNode;

		[SerializeField]
		private GameObject effectiveAbnormalStatusNode;

		[SerializeField]
		private GameObject effectiveAbnormalStatusCell;

		[SerializeField]
		[Header("SpecialTopItem")]
		private Image specialTopImage;

		[SerializeField]
		private CommonScrollRect commonScrollRect;

		private const float waitRenderTime = 0.1f;

		private ButtonSound buttonSound;

		private static UnityAction onUnitDetailModelCreated;

		private static UnityAction onUnitDetailModelBackButtonClicked;

		public int curQuestId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsQuestWall
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static QuestDetailInfoPopup Create(int questID, string qusetIndex, QuestSelectScene.Difficulty difficulty, UnityAction OnCloseCallback, bool showBlackLayer = true)
		{
			return null;
		}

		public void GetButtonSound()
		{
		}

		private void SetButtonSoundAction(PointerEventHandler eventHandler)
		{
		}

		public void SetItemTitleTexts(int questId)
		{
		}

		public void ReflectQuestMenuParam(int questID)
		{
		}

		public void ReflectQuestMenuParamQuestWall(int wallId)
		{
		}

		private List<EntityData> SortRewardData(List<EntityData> list)
		{
			return null;
		}

		private int GetMaterialPriority(EntityData rewardData)
		{
			return default(int);
		}

		public void InitDropList()
		{
		}

		private void ReflectRewardData(int questId)
		{
		}

		private void SetCommonIconButtonSound(CommonIcon icon, ButtonSound.SEType sEType)
		{
		}

		private void ReflectRewardDataQuestWall(int wallId)
		{
		}

		private void SetupIcon(EntityData ed, Transform parent, bool hadGot)
		{
		}

		private void SetIconListenerOnClickAndOnLongClick(CommonIcon icon)
		{
		}

		private void RequestAvailableDropList(int questID)
		{
		}

		private void OnSuccessQuestDropList(QuestDropListResponse res)
		{
		}

		public override void OnCloseButtonPressed()
		{
		}

		public void OnMissionButtonClicked()
		{
		}

		public void SetEnabled(Image image, Button button, bool isEnabled)
		{
		}

		public void SetPopupCanvasActive(bool value)
		{
		}

		public void ReOpen()
		{
		}

		private void InitGuest(int questId)
		{
		}

		private bool IsZeshiaReleasePoint(int charaId)
		{
			return default(bool);
		}
	}
}
