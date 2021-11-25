using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlScrollBase : FlUIBase
	{
		public enum ScrollStateTypes
		{
			None,
			Scroll_Init,
			Scroll_Loop,
			ScrollOut_Init,
			ScrollOut_Loop,
			ScrollSpring_Init,
			ScrollSpring_Loop
		}

		public enum ScrollModeTypes
		{
			Normal,
			Endless
		}

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

		public float CurrentScrollPosition => default(float);

		public float ScrollRange => default(float);

		public float MinScrollPosition => default(float);

		public float MaxScrollPosition => default(float);

		public ScrollModeTypes ScrollModeType => default(ScrollModeTypes);

		public int SelectActionId => default(int);

		public bool IsAutoScroll => default(bool);

		public bool IsAutoScrollAnimation => default(bool);

		public ScrollStateTypes CurrentScrollState => default(ScrollStateTypes);

		public Action ActionScrollStart
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

		public Action ActionScrollLoop
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

		public Action ActionScrollOutStart
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

		public Action ActionScrollOutLoop
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

		public Action ActionScrollSpringStart
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

		public Action ActionScrollSpringLoop
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

		public Action ActionScrollEnd
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

		public FlAction FlActionScrollStart
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

		public FlAction FlActionScrollLoop
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

		public FlAction FlActionScrollOutStart
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

		public FlAction FlActionScrollOutLoop
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

		public FlAction FlActionScrollSpringStart
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

		public FlAction FlActionScrollSpringLoop
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

		public FlAction FlActionScrollEnd
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

		[Obsolete]
		public FlAction FlActionScrollInit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete]
		public FlAction FlActionWaitInit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void _InitializeThisData_PostProcess()
		{
		}

		protected override void _Reset()
		{
		}

		protected override void _ResetPrevValue()
		{
		}

		public override void _Release()
		{
		}

		protected override void _Update_Common_Start()
		{
		}

		protected override void _Update(bool update = true)
		{
		}

		protected override void _Update_DownIn_Init()
		{
		}

		protected override void _Update_DownLoop_Loop()
		{
		}

		protected virtual void _Update_Scroll_Init()
		{
		}

		protected virtual void _Update_Scroll_Loop()
		{
		}

		protected virtual void _Update_ScrollOut_Init()
		{
		}

		protected virtual void _Update_ScrollOut_Loop()
		{
		}

		protected virtual void _Update_ScrollSpring_Init()
		{
		}

		protected virtual void _Update_ScrollSpring_Loop()
		{
		}

		protected virtual void _Update_Scroll_End()
		{
		}

		protected override void _UpdateValueChange()
		{
		}

		protected override void _UpdatePrevValueChange()
		{
		}

		public virtual void SetBlankLength(float blankMultiplyValue)
		{
		}

		public virtual void SetAutoScroll(bool enable)
		{
		}

		public virtual void SetAutoScrollAnimation(bool enable)
		{
		}
	}
}
