using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestEventBannerPage : MonoBehaviour
	{
		[SerializeField]
		protected Image descripImage;

		[SerializeField]
		private Text durationText;

		[SerializeField]
		private Button scheduleButton;

		[SerializeField]
		protected Button howtoButton;

		[SerializeField]
		protected Button[] timeAttackRankingButton;

		[SerializeField]
		private Image descripImageBg;

		[SerializeField]
		private Sprite[] descripImageBgSprite;

		[SerializeField]
		private Material[] descripImageBgMaterial;

		[SerializeField]
		private GameObject questWallTotalLevelNode;

		[SerializeField]
		private Text questWallTotalLeveltext;

		[SerializeField]
		private Text questWallResetTimeDescriptionText;

		[SerializeField]
		private ButtonWithSelectedImage questWallHowToReset;

		[SerializeField]
		protected Button instructorButton;

		[SerializeField]
		private ButtonWithSelectedImage instructorButtonWithSelectedImage;

		private const int specialEvent = 0;

		private const int normalEvents = 1;

		[SerializeField]
		private GameObject durationObj;

		[SerializeField]
		protected GameObject BonusObj;

		[SerializeField]
		protected Image weeklyTextImage;

		[SerializeField]
		protected Image dailyTextImage;

		[SerializeField]
		protected Image[] treasureBoxClosedImages;

		[SerializeField]
		protected Image[] treasureBoxOpenedImages;

		[SerializeField]
		protected Image[] unStackTreasureBoxClosedImages;

		[SerializeField]
		protected Image completeImage;

		[SerializeField]
		protected Text resetText;

		[SerializeField]
		protected Transform dailyBonusCompleteParent;

		[SerializeField]
		protected Transform weeklyBonusCompleteParent;

		protected const int boxCount = 5;

		[SerializeField]
		protected GameObject questBonusObj;

		[SerializeField]
		protected GameObject bonusPlusImageObj;

		[SerializeField]
		protected GameObject bonusButton;

		[SerializeField]
		protected RectTransform buttonParent;

		protected QuestSelectInstance.QuestEventData curEventData;

		protected QuestEventElement eventElement;

		private bool isBonusCompleted;

		private float totalTime;

		protected bool isAnimating;

		private void Awake()
		{
		}

		public virtual void SetContent(QuestSelectInstance.QuestEventData eventData)
		{
		}

		public static bool IsSkipCategoryPage(QuestSelectInstance.QuestEventData eventData, out QuestEventGroupElement anyEnabledElem)
		{
			return default(bool);
		}

		private static QuestEventGroupElement GetAnySpecialEvent(QuestSelectInstance.QuestEventData eventData)
		{
			return null;
		}

		protected void SetQuestWallInfo(QuestEventElement eventElement)
		{
		}

		protected void SetBonusInformation(QuestEventElement eventElement)
		{
		}

		private void SetStackBonusBoxes(int dailyBonusRecieveCount, int activeStackCount, int maxCount, QuestResetIntervalType bonusType)
		{
		}

		private void SetBonusBoxes(int openedCount, int maxCount, QuestResetIntervalType bonusType)
		{
		}

		private void SetBonusRemain()
		{
		}

		protected void SetRemainInfo(QuestEventElement eventElem)
		{
		}

		private void SetBg(QuestEventElement eventElement)
		{
		}

		protected void SetDurationInfo()
		{
		}

		protected void SetDurationText(Text targetText, bool isOneLine)
		{
		}

		public void OnScheduleButtonTouched()
		{
		}

		public void OnHowToButtonTouched()
		{
		}

		public void OnPageTouched()
		{
		}

		public void OnTimeAttackRankingButton()
		{
		}

		private void Update()
		{
		}

		protected void timeAttackRankingButtonSetActive(bool isActive)
		{
		}

		protected void timeAttackRankingButtonResetPressedState()
		{
		}

		public void OnInstructorButton()
		{
		}
	}
}
