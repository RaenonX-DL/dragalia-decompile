using System;
using System.Runtime.CompilerServices;

namespace FLATOUT.Main.Utility
{
	public class FlUpDownArrow : FlUIBase
	{
		protected string _upButtonMotionPath;

		protected FlButton _upButton;

		protected string _downButtonMotionPath;

		protected FlButton _downButton;

		protected int _value;

		protected int _prevValue;

		protected int _minValue;

		protected int _maxValue;

		protected bool _enableLoopValue;

		protected bool _isValueChangeUp;

		protected bool _valueChangeByDownInStart;

		public FlSlideBarComponent Component => null;

		public FlButton UpButton => null;

		public FlButton DownButton => null;

		public int Value => default(int);

		public int MinValue => default(int);

		public int MaxValue => default(int);

		public bool EnableLoopValue => default(bool);

		public Action ActionValueChangeUp
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

		public Action ActionValueChangeDown
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

		public FlAction FlActionValueChangeUp
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

		public FlAction FlActionValueChangeDown
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

		public void SetOtherPath(string upButtonMotionPath, string downButtonMotionPath)
		{
		}

		protected override bool _InitializeThisData()
		{
			return default(bool);
		}

		protected override void _InitializeThisData_PostProcess()
		{
		}

		private void _OnArrowButtonDown(object arg)
		{
		}

		private void _OnArrowButtonDownLoop(object arg)
		{
		}

		private void _OnArrowButtonDownOut(object arg)
		{
		}

		protected override void _Update_Loop_Init()
		{
		}

		protected override void _UpdateValueChange()
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

		private void _UpdateDirection()
		{
		}

		public override bool _UpdateUI(object arg)
		{
			return default(bool);
		}

		public void SetValue(int value)
		{
		}

		public void SetValue(int value, bool executeAction)
		{
		}

		public void SetRange(int minValue, int maxValue)
		{
		}

		public void SetEnableLoopValue(bool enable)
		{
		}
	}
}
