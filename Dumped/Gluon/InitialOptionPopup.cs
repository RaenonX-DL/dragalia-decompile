using System;
using UnityEngine.UI;

namespace Gluon
{
	public class InitialOptionPopup : PopupBase
	{
		public CommonSliderSelection bgmSlider;

		public TabBase vocalTab;

		public Toggle bgmToggle;

		public CommonSliderSelection graphicQualitySlider;

		public TabBase fpsTab;

		public CommonSliderSelection resolutionSlider;

		private const string muteText = "MUTE";

		private void Awake()
		{
		}

		private void BindEvents()
		{
		}

		protected override void Start()
		{
		}

		private int GetEnumMaxValue<T>() where T : struct, IConvertible
		{
			return default(int);
		}

		private void TabCallbackToToggle(TabBase tab, Action<bool> toggleCallback)
		{
		}

		public void OnAppliedAnyAction()
		{
		}

		public void OnBGMValueChanged(float val)
		{
		}

		public void OnBGMToggled(bool value)
		{
		}

		public void OnVocalSettingChanged(int index, bool isFromUI)
		{
		}

		public void OnGraphicQualityChanged(int value)
		{
		}

		public void OnFPSToggled(bool value)
		{
		}

		public void OnResolutionChanged(int value)
		{
		}

		public virtual void OnCloseButtonPressed()
		{
		}

		private void SliderCallbackToInt(CommonSliderSelection slider, Action<int> sliderCallback)
		{
		}
	}
}
