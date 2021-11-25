using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventMenuCell : GradientCell
	{
		private enum CellLockStatus
		{
			Open,
			NeedQuestClear,
			NotOpenPeriod
		}

		public SimpleAnimationCell animationCell;

		private const int expGroupId = 20101;

		private const int goldGoupId = 20206;

		private const int elementalGroupId = 20200;

		public Image baseImage;

		public Text remainText;

		[SerializeField]
		private Image rankingIcon;

		[SerializeField]
		private RectTransform baseButton;

		[SerializeField]
		private RectTransform baseButtonSpecial;

		[SerializeField]
		private Image arrow;

		[SerializeField]
		[Header("RoutineRibbon")]
		public GameObject expRibbon;

		public GameObject goldRibbon;

		public GameObject elementalRibbon;

		protected QuestEventGroupElement groupElement;

		protected QuestSelectInstance.QuestEventData curEventData;

		[SerializeField]
		private GameObject questNewIconRoot;

		[SerializeField]
		private GameObject questNewGlowRoot;

		[SerializeField]
		protected Image[] treasureBoxClosedImages;

		[SerializeField]
		protected Image[] treasureBoxOpenedImages;

		[SerializeField]
		protected GameObject bonusObj;

		[SerializeField]
		protected GameObject lockObj;

		[SerializeField]
		protected Text lockConditionText;

		[SerializeField]
		private int astralLockConditionTextFontSize;

		[SerializeField]
		protected GameObject[] balloonExpertObj;

		[SerializeField]
		[Header("Campaign")]
		private Transform campaignTrans;

		private CampaignButtons campaign;

		[SerializeField]
		protected CampaignButtons campaignButton;

		private FlashPlayer flashNewIcon;

		private FlashPlayer flashNewGlow;

		private string campaginPath;

		private static readonly int bonusAnimationHash;

		private string unlockPUDetailText;

		private bool isParentLayer;

		private CellLockStatus cellLockStatue;

		public QuestSelectInstance.QuestEventData getCurEventData => null;

		protected FlashPlayerManager flashPlayerManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		public virtual void SetContent(QuestEventGroupElement groupElement, bool isShowArrow, FlashPlayerManager flashPlayerManager, bool isParentLayer = false, bool isViewNewBadge = false, QuestSupportCanvas.PlayType playType = QuestSupportCanvas.PlayType.both)
		{
		}

		public bool IsSameGroup(QuestEventGroupElement groupElement)
		{
			return default(bool);
		}

		public void SetCampaignIcon(QuestSupportCanvas.PlayType playType)
		{
		}

		protected void SetBonusInformation(QuestEventElement eventElement)
		{
		}

		private void SetBonusBoxes(int openedCount, int maxCount, QuestResetIntervalType bonusType)
		{
		}

		public virtual void SetContent(QuestSelectInstance.QuestEventData eventData, bool isShowArrow, FlashPlayerManager flashPlayerManager)
		{
		}

		private QuestUtil.QuestState GetQuestState(QuestEventGroupElement eventGroup)
		{
			return default(QuestUtil.QuestState);
		}

		protected void SetQuestStateIcon(QuestUtil.QuestState state)
		{
		}

		private static void SetActiveScale(GameObject obj, bool isActive)
		{
		}

		private void SetContentCommon(int id, bool isShowArrow, int eventGroupId)
		{
		}

		private void SetUnlockInfo(int eventId, int eventGroupId)
		{
		}

		private void SetEventTutorialLockText()
		{
		}

		private void ShowNextEventSchedulePopup()
		{
		}

		public static void OnNormalEventMenuCellTouched(QuestEventGroupElement groupElement, QuestSelectInstance.QuestEventData curEventData)
		{
		}

		public virtual void OnCellTouched()
		{
		}

		public override bool SetGradientShader()
		{
			return default(bool);
		}

		public void UpdateRemainTime()
		{
		}
	}
}
