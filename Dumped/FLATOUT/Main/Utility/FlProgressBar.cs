using System;
using System.Runtime.CompilerServices;

namespace FLATOUT.Main.Utility
{
	public class FlProgressBar : FlUIBase
	{
		protected string _barMotionPath;

		protected FlMotion _barMotion;

		protected float _value;

		protected float _minValue;

		protected float _maxValue;

		protected float _blendTime;

		protected FlBlendValue _blendValue;

		protected float _prevValue;

		public FlProgressBarComponent Component => null;

		public FlMotion BarMotion => null;

		public float Value => default(float);

		public float CurrentValue => default(float);

		public float MinValue => default(float);

		public float MaxValue => default(float);

		public float BlendTime => default(float);

		public FlBlendValue BlendValue => null;

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

		public void SetOtherPath(string barMotionPath)
		{
		}

		protected override bool _InitializeThisData()
		{
			return default(bool);
		}

		protected override void _InitializeThisData_PostProcess()
		{
		}

		public override void _Release()
		{
		}

		protected override void _InitializeValueChange()
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

		protected override void _UpdateValueChangeEnd()
		{
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

		public void SetRange(float minValue, float maxValue)
		{
		}

		public void SetBlendTime(float time)
		{
		}
	}
}
