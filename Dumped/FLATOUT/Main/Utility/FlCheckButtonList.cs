using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlCheckButtonList : FlUIBase
	{
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

		public FlCheckButtonListComponent Component => null;

		public int CurrentIndex => default(int);

		public int Count => default(int);

		public int MaxCount => default(int);

		public List<FlCheckButton> CheckButtonList => null;

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

		public void SetOtherPath(string checkButtonObjectPrefixName)
		{
		}

		protected override bool _InitializeThisData()
		{
			return default(bool);
		}

		protected override void _InitializeThisData_PostProcess()
		{
		}

		private void _OnCheckStart(object arg)
		{
		}

		private void _OnCheckLoop(object arg)
		{
		}

		private void _OnCheckEnd(object arg)
		{
		}

		public override void _Release()
		{
		}

		protected override void _UpdateValueChange()
		{
		}

		private void _UpdateDirectionAndObjectSpace()
		{
		}

		private void _UpdateCheckButtonPosition()
		{
		}

		private void _UpdateCheckButtonState()
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

		public override bool _UpdateUI(object arg)
		{
			return default(bool);
		}

		public void SetIndex(int index)
		{
		}

		public void SetIndex(int index, bool animation)
		{
		}

		public void SetIndex(int index, bool animation, bool executeAction)
		{
		}

		public void SetCount(int count)
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
