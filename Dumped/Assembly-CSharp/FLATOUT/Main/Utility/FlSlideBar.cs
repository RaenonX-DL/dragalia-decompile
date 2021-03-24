/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlSlideBar : FlUIBase
	{
		// Fields
		protected string _barMotionPath;
		protected FlMotion _barMotion;
		protected string _moveButtonMotionPath;
		protected FlButton _moveButton;
		protected Vector3 _startPosition;
		protected Vector3 _endPosition;
		protected float _value;
		protected float _prevValue;
		protected float _blendTime;
		protected FlBlendValue _blendValue;
		protected float _minValue;
		protected float _maxValue;
		protected int _stepCount;
		protected Vector3 _worldPositionForTouchInput;
		[CompilerGenerated]
		private Action _ActionValueChangeStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionValueChangeLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionValueChangeEnd_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionValueChangeStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionValueChangeLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionValueChangeEnd_k__BackingField;
	
		// Properties
		public FlSlideBarComponent Component { get; }
		public FlMotion BarMotion { get; }
		public FlButton MoveButton { get; }
		public int StepCount { get; }
		public float Value { get; }
		public float CurrentValue { get; }
		public float MinValue { get; }
		public float MaxValue { get; }
		public Action ActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlAction FlActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Constructors
		public FlSlideBar();
	
		// Methods
		public void SetOtherPath(string barMotionPath, string moveButtonMotionPath);
		protected override bool _InitializeThisData();
		protected override void _InitializeThisData_PostProcess();
		private void _OnDownInSliderButton(object value);
		private void _OnDownLoopSliderButton(object value);
		private void _OnDownOutSliderButton(object value);
		protected override void _OnActive();
		public override void _Release();
		protected override void _Update_DownIn_Init();
		protected override void _InitializeValueChange();
		protected override void _UpdateValueChange();
		private void _FixSliderValue(float inputValue, out float outputValue, out float outputValuePercent);
		private void _UpdateDirection();
		private void _UpdateRangePosition();
		private float _GetPercentValueFromPosition(Vector3 worldPosition);
		protected override void _UpdatePrevValueChange();
		protected override void _ResetPrevValue();
		protected override void _UpdateValueChangeStart();
		protected override void _UpdateValueChangeLoop();
		protected override void _UpdateValueChangeEnd();
		public override bool _UpdateUI(object arg);
		public void SetValue(float value);
		public void SetValue(float value, bool animation);
		public void SetValue(float value, bool animation, bool executeAction);
		public void SetStepCount(int stepCount);
		public void SetRange(float minValue, float maxValue);
		public void SetBlendTime(float blendTime);
		public override void SetEnable(bool enable, FlUIEnableTypes enableType = FlUIEnableTypes.Normal);
		public override void SetParentUI(FlUIBase parentInputUI);
	}
}
