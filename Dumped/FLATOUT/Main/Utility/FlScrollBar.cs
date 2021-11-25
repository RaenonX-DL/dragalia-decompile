using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlScrollBar : FlUIBase
	{
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

		public FlScrollBarComponent Component => null;

		public FlMotion BarMotion => null;

		public FlMotion MoveMotion => null;

		public FlButton MoveButton => null;

		public int StepCount => default(int);

		public float Value => default(float);

		public float CurrentValue => default(float);

		public float RangeValue => default(float);

		public float MaxValue => default(float);

		public float MinValue => default(float);

		public Action ActionValueChangeStart
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

		public Action ActionValueChangeLoop
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

		public Action ActionValueChangeEnd
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

		public FlAction FlActionValueChangeStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionValueChangeLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionValueChangeEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public void SetOtherPath(string barMotionPath, string moveMotionPath, string moveButtonMotionPath)
		{
		}

		protected override bool _InitializeThisData()
		{
			return default(bool);
		}

		protected override void _InitializeThisData_PostProcess()
		{
		}

		private void _OnDownInMoveButton(object arg)
		{
		}

		private void _OnDownLoopMoveButton(object arg)
		{
		}

		private void _OnDownOutMoveButton(object arg)
		{
		}

		protected override void _OnActive()
		{
		}

		protected override void _Update_DownIn_Init()
		{
		}

		protected override void _InitializeValueChange()
		{
		}

		protected override void _UpdateValueChange()
		{
		}

		private void FixScrollValue(float inputValue, out float outputValue, out float outputValuePercent, out float outputRangePercent)
		{
		}

		protected override void _UpdatePrevValueChange()
		{
		}

		protected override void _ResetPrevValue()
		{
		}

		protected override void _UpdateValueChangeStart()
		{
		}

		protected override void _UpdateValueChangeLoop()
		{
		}

		protected override void _UpdateValueChangeEnd()
		{
		}

		private void _UpdateDirection()
		{
		}

		private void _UpdateRangePosition()
		{
		}

		private float _GetPercentValueFromPosition(Vector3 worldPosition)
		{
			return default(float);
		}

		public override bool _UpdateUI(object arg)
		{
			return default(bool);
		}

		public void SetValue(float value)
		{
		}

		public void SetValue(float value, bool animation)
		{
		}

		public void SetValue(float value, bool animation, bool executeAction)
		{
		}

		public void SetRange(float minValue, float maxValue, float rangeValue)
		{
		}

		public void SetStepCount(int stepCount)
		{
		}

		public override void SetEnable(bool enable, FlUIEnableTypes enableType = FlUIEnableTypes.Normal)
		{
		}

		public override void SetParentUI(FlUIBase parentInputUI)
		{
		}
	}
}
