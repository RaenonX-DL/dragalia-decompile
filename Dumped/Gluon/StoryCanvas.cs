using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryCanvas : MonoBehaviour
	{
		public enum SortingOrder
		{
			Character = 0,
			UIBackground = 1,
			UIMain = 2,
			InGameUI = 300
		}

		public MainCameraCtrl mainCameraCtrl;

		public RenderMode tempInGameUIRenderMode;

		public int tempInGameUISortingOrder;

		[SerializeField]
		public GameObject rootObject;

		public StoryBackgroundCanvas backgroundCanvasScript;

		public StoryCharacterCanvas characterCanvasScript;

		[SerializeField]
		private Canvas uiCanvas;

		[SerializeField]
		private StorySettings storySettings;

		[SerializeField]
		private Text nameTextBase;

		[SerializeField]
		private GameObject nameTextsParent;

		[SerializeField]
		private Text messageTextBase;

		[SerializeField]
		private RectTransform messageTextParentsBase;

		[SerializeField]
		private Text monologueTextBase;

		[SerializeField]
		private CanvasGroup monologueTextParentGroupsBase;

		[SerializeField]
		private CanvasGroup telopGroup;

		[SerializeField]
		private Image telopImage;

		[SerializeField]
		private Text telopMainText;

		[SerializeField]
		private Text telopSubText;

		[SerializeField]
		private Text telopMainRubyText;

		[SerializeField]
		private Text telopSubRubyText;

		[SerializeField]
		private CanvasGroup topicGroup;

		[SerializeField]
		private Image topicImage;

		[SerializeField]
		private Image choiceImage;

		[SerializeField]
		private CanvasGroup choiceGroup;

		[SerializeField]
		private Button[] choiceButtons;

		[SerializeField]
		private Text[] choiceButtonTexts;

		[SerializeField]
		private CanvasGroup[] choiceButtonGroups;

		[SerializeField]
		private Button skipButton;

		[SerializeField]
		private Button logButton;

		[SerializeField]
		private Button autoButton;

		[SerializeField]
		private Image autoIconImage;

		[SerializeField]
		private CanvasGroup autoIconGroup;

		[SerializeField]
		private Image messagePageIconImage;

		[SerializeField]
		private CanvasGroup messagePageIconGroup;

		[SerializeField]
		private Image chapterIntroPageIconImage;

		[SerializeField]
		private CanvasGroup chapterIntroPageIconGroup;

		[SerializeField]
		private GameObject nextRootObj;

		[SerializeField]
		private Image messageWindowImage;

		[SerializeField]
		private CanvasGroup messageWindowGroup;

		[SerializeField]
		private Image nameWindowImage;

		[SerializeField]
		private CanvasGroup nameWindowGroup;

		[SerializeField]
		private CanvasGroup bottomButtonGroup;

		[SerializeField]
		private RectTransform monologueParent;

		[SerializeField]
		private RectTransform choiceButtonsParent;

		public void SetManagerDataArrays()
		{
		}

		public void InitializeIngameCuttSetting()
		{
		}

		public void SetIngameCuttSetting(bool playCuttFlag)
		{
		}

		private void OnDestroy()
		{
		}

		public void SetBackKeyEvent()
		{
		}
	}
}
