/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlUpDownArrow : FlUIBase
	{
		// Fields
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
		[CompilerGenerated]
		private Action _ActionValueChangeUp_k__BackingField;
		[CompilerGenerated]
		private Action _ActionValueChangeDown_k__BackingField;
		[CompilerGenerated]
		private Action _ActionValueChangeStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionValueChangeUp_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionValueChangeDown_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionValueChangeStart_k__BackingField;
	
		// Properties
		public FlSlideBarComponent Component { get; }
		public FlButton UpButton { get; }
		public FlButton DownButton { get; }
		public int Value { get; }
		public int MinValue { get; }
		public int MaxValue { get; }
		public bool EnableLoopValue { get; }
		public Action ActionValueChangeUp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeDown { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlAction FlActionValueChangeUp { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeDown { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Constructors
		public FlUpDownArrow();
	
		// Methods
		public void SetOtherPath(string upButtonMotionPath, string downButtonMotionPath);
		protected override bool _InitializeThisData();
		protected override void _InitializeThisData_PostProcess();
		private void _OnArrowButtonDown(object arg);
		private void _OnArrowButtonDownLoop(object arg);
		private void _OnArrowButtonDownOut(object arg);
		protected override void _Update_Loop_Init();
		protected override void _UpdateValueChange();
		protected override void _UpdatePrevValueChange();
		protected override void _ResetPrevValue();
		protected override void _UpdateValueChangeStart();
		protected override void _UpdateValueChangeLoop();
		private void _UpdateDirection();
		public override bool _UpdateUI(object arg);
		public void SetValue(int value);
		public void SetValue(int value, bool executeAction);
		public void SetRange(int minValue, int maxValue);
		public void SetEnableLoopValue(bool enable);
	}
}
