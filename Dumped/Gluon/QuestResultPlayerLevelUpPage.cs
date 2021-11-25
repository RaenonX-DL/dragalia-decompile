using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultPlayerLevelUpPage : MonoBehaviour
	{
		private enum RankUpType
		{
			RankUpOnly,
			Upper,
			Fort
		}

		[SerializeField]
		[Header("Level")]
		public Text uiBeforeLevelText;

		public Text uiAfterLevelText;

		[SerializeField]
		private GameObject textPanel;

		[SerializeField]
		[Header("Button")]
		public Button nextButton;

		public Text nextButtonText;

		[SerializeField]
		[Header("Animation")]
		public Transform lowerPanel;

		public Transform nextButtonPanel;

		[SerializeField]
		[Header("ViewSizeAdjust")]
		private RectTransform wholeFrameRectTrans;

		[SerializeField]
		private float wholeFrameVerticalSpacing;

		[SerializeField]
		private float wholeFrameHeightMax;

		[SerializeField]
		private RectTransform viewFrameRectTrans;

		[SerializeField]
		private float viewFrameHeightMax;

		[SerializeField]
		private int maxRowCount;

		[SerializeField]
		private GameObject[] validViewObjs;

		[HideInInspector]
		public Action onCloseDone;

		[SerializeField]
		private Canvas levelUpCanvasObj;

		[SerializeField]
		private GameObject flashCanvasObj;

		private GridLayoutGroup gridLayoutGroup;

		[SerializeField]
		private Canvas questResultPlayerLevelUpTopCanvas;

		[SerializeField]
		private GameObject fortObject;

		[SerializeField]
		private QuestResultRankUpRewardController fortTableViewCrl;

		[SerializeField]
		private GameObject friendObject;

		[SerializeField]
		private Text beforeFriendText;

		[SerializeField]
		private Text afterFriendText;

		[SerializeField]
		private GameObject staminaObject;

		[SerializeField]
		private Text beforeStaminaText;

		[SerializeField]
		private Text afterStaminaText;

		[SerializeField]
		private GameObject upperBonusObject;

		[SerializeField]
		private Transform commonIconTrans;

		[SerializeField]
		private RectTransform popupBackGroundTrans;

		private UnityEvent backKeyEvent;

		private const int popupHeightL = 808;

		private const int popupHeightM = 400;

		private const int popupHeightS = 270;

		private const string seLvUpSlideOut = "SE_OUT_COMMON_0035";

		private RankUpType rankUpType;

		private FlashPlayer flashPlayer;

		public QuestResultScene sceneObj
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

		public static QuestResultPlayerLevelUpPage Create(Transform parent, Action onCloseDone)
		{
			return null;
		}

		public void InitByData(int toLevel)
		{
		}

		private void Awake()
		{
		}

		public void OnCloseButtonClicked()
		{
		}

		private void DoRankupPanelAnimation()
		{
		}

		public void PlayLevelUpPanelAnimation(int toLevel)
		{
		}

		private void OnFadeInAnimation()
		{
		}

		private void OnFadeOutAnimation()
		{
		}

		private void ViewSizeAdjust()
		{
		}
	}
}
