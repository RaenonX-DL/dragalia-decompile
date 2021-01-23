/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InitialOptionPopup : PopupBase
	{
		// Fields
		public CommonSliderSelection bgmSlider;
		public TabBase vocalTab;
		public Toggle bgmToggle;
		public CommonSliderSelection graphicQualitySlider;
		public TabBase fpsTab;
		public CommonSliderSelection resolutionSlider;
		private const string muteText = "MUTE";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public Action<bool> toggleCallback;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _TabCallbackToToggle_b__0(int index, bool isFromUI);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public Action<int> sliderCallback;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _SliderCallbackToInt_b__0(float x);
		}
	
		// Constructors
		public InitialOptionPopup();
	
		// Methods
		private void Awake();
		private void BindEvents();
		protected override void Start();
		private int GetEnumMaxValue<T>()
			where T : struct, IConvertible;
		private void TabCallbackToToggle(TabBase tab, Action<bool> toggleCallback);
		public void OnAppliedAnyAction();
		public void OnBGMValueChanged(float val);
		public void OnBGMToggled(bool value);
		public void OnVocalSettingChanged(int index, bool isFromUI);
		public void OnGraphicQualityChanged(int value);
		public void OnFPSToggled(bool value);
		public void OnResolutionChanged(int value);
		public virtual void OnCloseButtonPressed();
		private void SliderCallbackToInt(CommonSliderSelection slider, Action<int> sliderCallback);
	}
}
