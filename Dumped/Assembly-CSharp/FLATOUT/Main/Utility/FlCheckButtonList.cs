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
	public class FlCheckButtonList : FlUIBase
	{
		// Fields
		protected string _checkButtonObjectPrefixName;
		protected List<FlCheckButton> _checkButtonList;
		protected float _objectSpace;
		protected Vector3 _startPosition;
		protected Vector3 _endPosition;
		protected int _currentCount;
		protected int _prevCount;
		protected int _maxCount;
		protected int _currentIndex;
		protected int _prevIndex;
		protected FlCommonStateTypes _valueChangeState;
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
		public FlCheckButtonListComponent Component { get; }
		public int CurrentIndex { get; }
		public int Count { get; }
		public int MaxCount { get; }
		public List<FlCheckButton> CheckButtonList { get; }
		public Action ActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionValueChangeEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlAction FlActionValueChangeStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionValueChangeEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Constructors
		public FlCheckButtonList();
	
		// Methods
		public void SetOtherPath(string checkButtonObjectPrefixName);
		protected override bool _InitializeThisData();
		protected override void _InitializeThisData_PostProcess();
		private void _OnCheckStart(object arg);
		private void _OnCheckLoop(object arg);
		private void _OnCheckEnd(object arg);
		public override void _Release();
		protected override void _UpdateValueChange();
		private void _UpdateDirectionAndObjectSpace();
		private void _UpdateCheckButtonPosition();
		private void _UpdateCheckButtonState();
		protected override void _UpdatePrevValueChange();
		protected override void _ResetPrevValue();
		protected override void _UpdateValueChangeStart();
		protected override void _UpdateValueChangeLoop();
		protected override void _UpdateValueChangeEnd();
		public override bool _UpdateUI(object arg);
		public void SetIndex(int index);
		public void SetIndex(int index, bool animation);
		public void SetIndex(int index, bool animation, bool executeAction);
		public void SetCount(int count);
		public override void SetEnable(bool enable, FlUIEnableTypes enableType = FlUIEnableTypes.Normal);
		public override void SetParentUI(FlUIBase parentInputUI);
	}
}
