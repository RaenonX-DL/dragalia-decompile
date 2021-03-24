/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlCheckButton : FlUIBase
	{
		// Fields
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
		[CompilerGenerated]
		private Action _ActionCheckStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionUncheckLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionChecked_k__BackingField;
		[CompilerGenerated]
		private Action _ActionUncheckStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionCheckLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionUnchecked_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionCheckStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionUncheckLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionChecked_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionUncheckStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionCheckLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionUnchecked_k__BackingField;
	
		// Properties
		public FlCheckButtonComponent Component { get; }
		public bool Check { get; }
		public Action ActionCheckStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionUncheckLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionChecked { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionUncheckStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionCheckLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionUnchecked { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlAction FlActionCheckStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionUncheckLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionChecked { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionUncheckStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionCheckLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionUnchecked { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		public enum CheckButtonTypes
		{
			Simple = 0,
			Normal = 1
		}
	
		public enum StateTypes
		{
			None = 0,
			Check_Init = 1,
			Check_Loop = 2
		}
	
		public enum LabelTypes
		{
			Loop = 0,
			DownIn = 1,
			DownLoop = 2,
			DownOut = 3,
			Check = 4,
			Disable = 5,
			SelectIn = 6,
			SelectLoop = 7,
			SelectOut = 8,
			OverIn = 9,
			OverLoop = 10,
			OverOut = 11
		}
	
		// Constructors
		public FlCheckButton();
	
		// Methods
		protected override void _InitializeThisData_PostProcess();
		protected override void _InitializeUILabelNameTable();
		private void _InitializeCheckLabelList();
		private void _UpdateLabelName();
		private string _GetLabel(LabelTypes labelType);
		protected override void _Update_Common_Start();
		protected override void _Update(bool update = true);
		protected override void _Update_Loop_Init();
		protected override void _Update_DownOut_Init();
		private void _Update_Check_Init();
		private void _Update_Check_Loop();
		public override bool _IsDownState();
		public bool GetCheck();
		public void SetCheck(bool value);
		public void SetCheck(bool value, bool animation);
		public void SetCheck(bool value, bool animation, bool executeAction);
		public override void SetEnable(bool enable, FlUIEnableTypes enableType = FlUIEnableTypes.Normal);
	}
}
