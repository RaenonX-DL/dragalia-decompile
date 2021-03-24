/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonSliderSelection : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Slider slider;
		private CommonSlider _commonSlider;
		public UnityEngine.UI.Text currentValueText;
		public UnityEngine.UI.Text maxValueText;
		public Button minusButton;
		public Button plusButton;
		public Button maxButton;
		private List<string> displayValueTexts;
		private bool playPopSENextFrame;
		private int lastValue;
		private int invalidMinValue;
		private int invalidMaxValue;
		private int wholeNumberScale;
		[Header]
		[SerializeField]
		public bool isShowTapEffect;
		public Action<float> onValueChanged;
		[CompilerGenerated]
		private bool _isModifyingThroughSliderBar_k__BackingField;
	
		// Properties
		public CommonSlider commonSlider { get; }
		public bool isModifyingThroughSliderBar { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CommonSliderSelection();
	
		// Methods
		public void SetIsModifyingThroughSliderBar(bool value);
		private void DoPlayPoppingSE();
		public void PlayPoppingSE();
		private void LateUpdate();
		public void SetDisplayValueTexts(List<string> texts);
		public void SetInvalidValues(int invalidMax, int invalidMin = -1);
		public void SetWholeNumberScale(int scale);
		public void SetValues(long maxValue, long minValue = 1, long currentValue = 1);
		public int GetCurrentValue();
		private float AdjustByWholeNumberScale(float value);
		private bool AutoMatchWholeNumberScale();
		private void GetSeletableMinMaxValue(out float selectableMinValue, out float selectableMaxValue);
		public void OnSliderValueChanged(float val);
		public void OnPlusButton();
		public void OnMinusButton();
		public void OnMaxButton();
		public void SetDisableState(bool toEnabled, string disabledText = null);
	}
}
