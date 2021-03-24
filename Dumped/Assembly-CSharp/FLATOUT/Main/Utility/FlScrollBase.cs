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
	public class FlScrollBase : FlUIBase
	{
		// Fields
		protected ScrollModeTypes _scrollModeType;
		protected ScrollStateTypes _currentScrollState;
		protected float _startWorldPosition;
		protected float _currentWorldPosition;
		protected float _diffWorldPosition;
		protected float _startScrollPosition;
		protected float _currentScrollPosition;
		protected float _prevScrollPosition;
		protected float _allScrollLength;
		protected float _scrollRange;
		protected float _minScrollPosition;
		protected float _maxScrollPosition;
		protected bool _useTargetScrollPosition;
		protected float _targetScrollPosition;
		protected float _outMinSpeed;
		protected float _outStartSpeed;
		protected float _outCurrentSpeed;
		protected float _outStartAccel;
		protected float _outCurrentAccel;
		protected float _blankLength;
		protected float _blankLengthMultiplyValue;
		protected FlBlendValue _scrollBlendValue;
		protected float _scrollCancelTime;
		protected float _currentScrollCancelTime;
		protected int _selectActionId;
		protected bool _isAutoScroll;
		protected bool _isAutoScrollAnimation;
		protected Vector3 _tempVector0;
		protected Vector3 _tempVector1;
		[CompilerGenerated]
		private Action _ActionScrollStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionScrollLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionScrollOutStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionScrollOutLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionScrollSpringStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionScrollSpringLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionScrollEnd_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionScrollStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionScrollLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionScrollOutStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionScrollOutLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionScrollSpringStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionScrollSpringLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionScrollEnd_k__BackingField;
	
		// Properties
		public float CurrentScrollPosition { get; }
		public float ScrollRange { get; }
		public float MinScrollPosition { get; }
		public float MaxScrollPosition { get; }
		public ScrollModeTypes ScrollModeType { get; }
		public int SelectActionId { get; }
		public bool IsAutoScroll { get; }
		public bool IsAutoScrollAnimation { get; }
		public ScrollStateTypes CurrentScrollState { get; }
		public Action ActionScrollStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionScrollLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionScrollOutStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionScrollOutLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionScrollSpringStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionScrollSpringLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionScrollEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlAction FlActionScrollStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionScrollLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionScrollOutStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionScrollOutLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionScrollSpringStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionScrollSpringLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionScrollEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		[Obsolete]
		public FlAction FlActionScrollInit { get; set; }
		[Obsolete]
		public FlAction FlActionWaitInit { get; set; }
	
		// Nested types
		public enum ScrollStateTypes
		{
			None = 0,
			Scroll_Init = 1,
			Scroll_Loop = 2,
			ScrollOut_Init = 3,
			ScrollOut_Loop = 4,
			ScrollSpring_Init = 5,
			ScrollSpring_Loop = 6
		}
	
		public enum ScrollModeTypes
		{
			Normal = 0,
			Endless = 1
		}
	
		// Constructors
		public FlScrollBase();
	
		// Methods
		protected override void _InitializeThisData_PostProcess();
		protected override void _Reset();
		protected override void _ResetPrevValue();
		public override void _Release();
		protected override void _Update_Common_Start();
		protected override void _Update(bool update = true);
		protected override void _Update_DownIn_Init();
		protected override void _Update_DownLoop_Loop();
		protected virtual void _Update_Scroll_Init();
		protected virtual void _Update_Scroll_Loop();
		protected virtual void _Update_ScrollOut_Init();
		protected virtual void _Update_ScrollOut_Loop();
		protected virtual void _Update_ScrollSpring_Init();
		protected virtual void _Update_ScrollSpring_Loop();
		protected virtual void _Update_Scroll_End();
		protected override void _UpdateValueChange();
		protected override void _UpdatePrevValueChange();
		public virtual void SetBlankLength(float blankMultiplyValue);
		public virtual void SetAutoScroll(bool enable);
		public virtual void SetAutoScrollAnimation(bool enable);
	}
}
