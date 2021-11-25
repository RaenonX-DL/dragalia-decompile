using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TutorialDualWindow : TutorialSimpleWindow
	{
		public RectTransform[] pageRectTransform;

		public Text[] windowTitle;

		public Image[] mainImage;

		public RubySupportedText descText;

		public RubySupportedText fadeText;

		public Button prevButton;

		public Button nextButton;

		public Button skipButton;

		public Text prevButtonText;

		public Text nextButtonText;

		public Text skipButtonText;

		public GameObject pagerCenter;

		public Sprite closeButtonSprite;

		private Action onCompleted;

		private Action skipCallback;

		private int currPageNum;

		private CommonPager[] pagers;

		private const float pagerWidth = 32f;

		private string[] imagefilenames;

		private string[] titleTexts;

		private string[] descTexts;

		private int totalPage;

		private bool isNowAnimation;

		private UIAnimationBase[] uiAnimations;

		private string skipConfirmText;

		private CommonPopup skipPopup;

		public static TutorialDualWindow CreateTutorialDualWindow(Canvas canvas, string[] imagefilenames, string[] titleTexts, string[] descTexts, int totalPageNum, Action onCompleted, string skipConfirmText = "", [Optional] Action skipCallback)
		{
			return null;
		}

		public void SetWindowTitle(string title, int index)
		{
		}

		public void SetMainImage(string filename, int imageIndex)
		{
		}

		public void OnPrevButtonPressed()
		{
		}

		public void OnNextButtonPressed()
		{
		}

		private void PlayPageAnimation(bool isNextPage)
		{
		}

		public void OnSkipButtonPressed()
		{
		}

		private void CloseDualWindow()
		{
		}

		public void StartEnterAnimation()
		{
		}
	}
}
