/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlImageNumber : FlUIBase
	{
		// Fields
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
		public FlImageNumberComponent Component { get; }
		public int Value { get; }
		public int CurrentValue { get; }
		public int Digit { get; }
		public int MaxDigit { get; }
		public float BlendTime { get; }
		public FlUIAlignTypes AlignType { get; }
		public FlBlendIntValue BlendValue { get; }
		public float InDelayTime { get; }
		public float OutStartTime { get; }
		public float OutDelayTime { get; }
		public bool AnimationFromLower { get; }
		public ImageNumberTypes ImageNumberType { get; }
		public List<FlMotion> NumberMotionList { get; }
		public Action ActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlAction FlActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		public enum ImageNumberTypes
		{
			FixNumber = 0,
			AnimationNumber = 1
		}
	
		// Constructors
		public FlImageNumber();
	
		// Methods
		public void SetOtherPath(string numberObjectPrefixName);
		protected override bool _InitializeThisData();
		protected override void _InitializeThisData_PostProcess();
		private void _CheckImageNumberType();
		public override void _Release();
		protected override void _InitializeValueChange();
		protected override void _UpdateValueChange();
		private void _UpdateNumberMotionList(float value);
		private void _UpdateAnimation();
		private void _UpdateAlign();
		private void _UpdateImageSpace();
		protected override void _UpdatePrevValueChange();
		protected override void _ResetPrevValue();
		protected override void _UpdateValueChangeStart();
		protected override void _UpdateValueChangeLoop();
		protected override void _UpdateValueChangeEnd();
		public void SetValue(int value);
		public void SetValue(float value, bool animation);
		public void SetValue(int value, bool animation);
		public void SetValue(int value, bool animation, bool executeAction);
		public void SetInDelayTime(float value);
		public void SetOutStartTime(float value);
		public void SetOutDelayTime(float value);
		public void SetAnimationFromLower(bool fromLower);
		public void SetBlendTime(float time);
		public void SetAlignType(FlUIAlignTypes alignType);
		public void SetDigit(int digit);
		public void SetCustomFrame(params int[] targetDigitList);
		public void SetDisableCustomFrame();
	}
}
