using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AfterPrologueDownloadCanvas : MonoBehaviour
	{
		public PageViewBase pageView;

		public GameObject pagerCenter;

		public Image[] charaHeaderBgs;

		public Image[] stars;

		public Image[] elementIcons;

		public Image[] weaponIcons;

		public Text charaName;

		public Text charaDesc;

		public GameObject checkMark;

		public Text downloadPercentText;

		public Text downloadingText;

		public GameObject charaHeader;

		public GameObject charaDetailButton;

		public GameObject charaFooter;

		public AnimationUITalkWindow talkWindow;

		public RectTransform tutorialFooterRectTransform;

		public CanvasGroup tutorialFooterCanvasGroup;

		public Gauge gauge;

		public GameObject gaugeBar;

		public GameObject gaugeBarCompleted;

		public RectTransform dotsRectTransform;

		public Image[] dots;

		public CanvasGroup frontBlackCG;

		private static List<TutorialUnitSelectListElement> charaList;

		private static List<int> charaIds;

		public float moveDuration;

		public static string prefabDir;

		private static string pagePrefabPath;

		private void Start()
		{
		}

		public void SetCharaInfo(int charaId)
		{
		}

		public void OnBeforePageChange(bool isToLeft)
		{
		}

		public void OnPageChanged(int pageIndex)
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		private void ExecuteTutorialStartAnimation()
		{
		}

		private void ExecuteTutorialEndAnimation()
		{
		}

		public void OnCheckButtonPressed()
		{
		}

		public static List<int> GetFavoriteCharaIdList()
		{
			return null;
		}

		public static List<TutorialUnitSelectListElement> GetNowTutorialUnitSelectList()
		{
			return null;
		}

		public static bool IsFavoriteCharaId(int charaId)
		{
			return default(bool);
		}

		public void SetDownloadPercentage(float value)
		{
		}

		private void ExecuteCharaFooterStartAnimation()
		{
		}

		private void ExecuteCharaFooterEndAnimation()
		{
		}

		private void HideCharaFooter()
		{
		}

		private void ExecuteCharaHeaderStartAnimation()
		{
		}

		private void ExecuteCharaHeaderEndAnimation()
		{
		}

		private void HideCharaHeader()
		{
		}

		private void ExecuteCharaDetailButtonStartAnimation()
		{
		}

		private void ExecuteCharaDetailButtonEndAnimation()
		{
		}

		private void HideCharaDetailButton()
		{
		}
	}
}
