using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FLATOUT.Main.Utility
{
	public class FlCheckButton : FlUIBase
	{
		public enum CheckButtonTypes
		{
			Simple,
			Normal
		}

		public enum StateTypes
		{
			None,
			Check_Init,
			Check_Loop
		}

		public enum LabelTypes
		{
			Loop,
			DownIn,
			DownLoop,
			DownOut,
			Check,
			Disable,
			SelectIn,
			SelectLoop,
			SelectOut,
			OverIn,
			OverLoop,
			OverOut
		}

		public CheckButtonTypes _checkButtonType;

		private StateTypes _currentState;

		private bool _checkChanged;

		private bool _executeCheckAction;

		private int _checkFlag;

		private List<List<string>> _checkLabelList;

		private string _labelCheck;

		private string _checkLabelLoop;

		private string _checkLabelDownIn;

		private string _checkLabelDownLoop;

		private string _checkLabelDownOut;

		private string _checkLabelCheck;

		private string _checkLabelLoop2;

		private string _checkLabelDownIn2;

		private string _checkLabelDownLoop2;

		private string _checkLabelDownOut2;

		private string _checkLabelCheck2;

		private string _checkLabelDisable;

		private string _checkLabelDisable2;

		private string _checkLabelSelectIn;

		private string _checkLabelSelectIn2;

		private string _checkLabelSelectLoop;

		private string _checkLabelSelectLoop2;

		private string _checkLabelSelectOut;

		private string _checkLabelSelectOut2;

		private string _checkLabelOverIn;

		private string _checkLabelOverIn2;

		private string _checkLabelOverLoop;

		private string _checkLabelOverLoop2;

		private string _checkLabelOverOut;

		private string _checkLabelOverOut2;

		public FlCheckButtonComponent Component => null;

		public bool Check => default(bool);

		public Action ActionCheckStart
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

		public Action ActionUncheckLoop
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

		public Action ActionChecked
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

		public Action ActionUncheckStart
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

		public Action ActionCheckLoop
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

		public Action ActionUnchecked
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

		public FlAction FlActionCheckStart
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

		public FlAction FlActionUncheckLoop
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

		public FlAction FlActionChecked
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

		public FlAction FlActionUncheckStart
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

		public FlAction FlActionCheckLoop
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

		public FlAction FlActionUnchecked
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

		protected override void _InitializeThisData_PostProcess()
		{
		}

		protected override void _InitializeUILabelNameTable()
		{
		}

		private void _InitializeCheckLabelList()
		{
		}

		private void _UpdateLabelName()
		{
		}

		private string _GetLabel(LabelTypes labelType)
		{
			return null;
		}

		protected override void _Update_Common_Start()
		{
		}

		protected override void _Update(bool update = true)
		{
		}

		protected override void _Update_Loop_Init()
		{
		}

		protected override void _Update_DownOut_Init()
		{
		}

		private void _Update_Check_Init()
		{
		}

		private void _Update_Check_Loop()
		{
		}

		public override bool _IsDownState()
		{
			return default(bool);
		}

		public bool GetCheck()
		{
			return default(bool);
		}

		public void SetCheck(bool value)
		{
		}

		public void SetCheck(bool value, bool animation)
		{
		}

		public void SetCheck(bool value, bool animation, bool executeAction)
		{
		}

		public override void SetEnable(bool enable, FlUIEnableTypes enableType = FlUIEnableTypes.Normal)
		{
		}
	}
}
