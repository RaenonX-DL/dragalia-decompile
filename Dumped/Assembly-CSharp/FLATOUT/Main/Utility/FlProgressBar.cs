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
	public class FlProgressBar : FlUIBase
	{
		// Fields
		protected string _barMotionPath;
		protected FlMotion _barMotion;
		protected float _value;
		protected float _minValue;
		protected float _maxValue;
		protected float _blendTime;
		protected FlBlendValue _blendValue;
		protected float _prevValue;
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
		public FlProgressBarComponent Component { get; }
		public FlMotion BarMotion { get; }
		public float Value { get; }
		public float CurrentValue { get; }
		public float MinValue { get; }
		public float MaxValue { get; }
		public float BlendTime { get; }
		public FlBlendValue BlendValue { get; }
		public Action ActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlAction FlActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Constructors
		public FlProgressBar();
	
		// Methods
		public void SetOtherPath(string barMotionPath);
		protected override bool _InitializeThisData();
		protected override void _InitializeThisData_PostProcess();
		public override void _Release();
		protected override void _InitializeValueChange();
		protected override void _UpdateValueChange();
		protected override void _UpdatePrevValueChange();
		protected override void _ResetPrevValue();
		protected override void _UpdateValueChangeStart();
		protected override void _UpdateValueChangeLoop();
		protected override void _UpdateValueChangeEnd();
		public void SetValue(float value);
		public void SetValue(float value, bool animation);
		public void SetValue(float value, bool animation, bool executeAction);
		public void SetRange(float minValue, float maxValue);
		public void SetBlendTime(float time);
	}
}
