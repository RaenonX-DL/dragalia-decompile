/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlScrollBar : FlUIBase
	{
		// Fields
		protected string _barMotionPath;
		protected FlMotion _barMotion;
		protected string _moveMotionPath;
		protected FlMotion _moveMotion;
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
		protected float _rangeValue;
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
		public FlScrollBarComponent Component { get; }
		public FlMotion BarMotion { get; }
		public FlMotion MoveMotion { get; }
		public FlButton MoveButton { get; }
		public int StepCount { get; }
		public float Value { get; }
		public float CurrentValue { get; }
		public float RangeValue { get; }
		public float MaxValue { get; }
		public float MinValue { get; }
		public Action ActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlAction FlActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Constructors
		public FlScrollBar();
	
		// Methods
		public void SetOtherPath(string barMotionPath, string moveMotionPath, string moveButtonMotionPath);
		protected override bool _InitializeThisData();
		protected override void _InitializeThisData_PostProcess();
		private void _OnDownInMoveButton(object arg);
		private void _OnDownLoopMoveButton(object arg);
		private void _OnDownOutMoveButton(object arg);
		protected override void _OnActive();
		protected override void _Update_DownIn_Init();
		protected override void _InitializeValueChange();
		protected override void _UpdateValueChange();
		private void FixScrollValue(float inputValue, out float outputValue, out float outputValuePercent, out float outputRangePercent);
		protected override void _UpdatePrevValueChange();
		protected override void _ResetPrevValue();
		protected override void _UpdateValueChangeStart();
		protected override void _UpdateValueChangeLoop();
		protected override void _UpdateValueChangeEnd();
		private void _UpdateDirection();
		private void _UpdateRangePosition();
		private float _GetPercentValueFromPosition(Vector3 worldPosition);
		public override bool _UpdateUI(object arg);
		public void SetValue(float value);
		public void SetValue(float value, bool animation);
		public void SetValue(float value, bool animation, bool executeAction);
		public void SetRange(float minValue, float maxValue, float rangeValue);
		public void SetStepCount(int stepCount);
		public override void SetEnable(bool enable, FlUIEnableTypes enableType = FlUIEnableTypes.Normal);
		public override void SetParentUI(FlUIBase parentInputUI);
	}
}
