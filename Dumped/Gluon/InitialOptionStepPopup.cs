using System;
using UnityEngine;

namespace Gluon
{
	public class InitialOptionStepPopup : PopupBase
	{
		public enum PageIndex
		{
			Vocal,
			Graphic,
			UILayout,
			Max
		}

		public static OptionModel.Setting setting;

		public PageViewBase pageView;

		public UIAnimationPublisher publisher;

		public ButtonPressedMarkEventSender nextButtonPressedMark;

		public ButtonPressedMarkEventSender prevButtonPressedMark;

		private Action onCompleted;

		public static void CreateModule(Action onCompleted)
		{
		}

		protected override void Start()
		{
		}

		private void SetPageContent(GameObject page, int index)
		{
		}

		public static void CreateFinalConfirmPopup(Action onCompelte, InitialOptionStepPopup thisPopup)
		{
		}

		public void OnNextButtonPressed()
		{
		}

		public void OnReturnButtonPressed()
		{
		}

		private static void ReApplySetting()
		{
		}

		public static void OnVocalSettingChanged(int value)
		{
		}

		public static void OnGraphicQualityChanged(int value)
		{
		}

		public static void OnUILayoutChanged(bool value)
		{
		}
	}
}
