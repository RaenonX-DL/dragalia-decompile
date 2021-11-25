using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlImageNumber : FlUIBase
	{
		public enum ImageNumberTypes
		{
			FixNumber,
			AnimationNumber
		}

		protected ImageNumberTypes _imageNumberType;

		protected string _numberObjectPrefixName;

		protected List<FlMotion> _numberMotionList;

		protected List<GameObject> _objectListForSpace;

		protected int _value;

		protected float _blendTime;

		protected int _digit;

		protected int _maxDigit;

		protected int _currentDigit;

		protected float _imageSpace;

		protected bool _animationFromLower;

		protected float _inDelayTime;

		protected float _outStartTime;

		protected float _outDelayTime;

		protected float _currentTime;

		protected FlUIAlignTypes _alignType;

		protected FlBlendIntValue _blendValue;

		protected int _prevValue;

		protected List<bool> _customFrameFlagList;

		protected string _imageNumberLabelIn;

		protected string _imageNumberLabelLoop;

		protected string _imageNumberLabelOut;

		public FlImageNumberComponent Component => null;

		public int Value => default(int);

		public int CurrentValue => default(int);

		public int Digit => default(int);

		public int MaxDigit => default(int);

		public float BlendTime => default(float);

		public FlUIAlignTypes AlignType => default(FlUIAlignTypes);

		public FlBlendIntValue BlendValue => null;

		public float InDelayTime => default(float);

		public float OutStartTime => default(float);

		public float OutDelayTime => default(float);

		public bool AnimationFromLower => default(bool);

		public ImageNumberTypes ImageNumberType => default(ImageNumberTypes);

		public List<FlMotion> NumberMotionList => null;

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

		public void SetOtherPath(string numberObjectPrefixName)
		{
		}

		protected override bool _InitializeThisData()
		{
			return default(bool);
		}

		protected override void _InitializeThisData_PostProcess()
		{
		}

		private void _CheckImageNumberType()
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

		private void _UpdateNumberMotionList(float value)
		{
		}

		private void _UpdateAnimation()
		{
		}

		private void _UpdateAlign()
		{
		}

		private void _UpdateImageSpace()
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

		public void SetValue(int value)
		{
		}

		public void SetValue(float value, bool animation)
		{
		}

		public void SetValue(int value, bool animation)
		{
		}

		public void SetValue(int value, bool animation, bool executeAction)
		{
		}

		public void SetInDelayTime(float value)
		{
		}

		public void SetOutStartTime(float value)
		{
		}

		public void SetOutDelayTime(float value)
		{
		}

		public void SetAnimationFromLower(bool fromLower)
		{
		}

		public void SetBlendTime(float time)
		{
		}

		public void SetAlignType(FlUIAlignTypes alignType)
		{
		}

		public void SetDigit(int digit)
		{
		}

		public void SetCustomFrame(int[] targetDigitList)
		{
		}

		public void SetDisableCustomFrame()
		{
		}
	}
}
