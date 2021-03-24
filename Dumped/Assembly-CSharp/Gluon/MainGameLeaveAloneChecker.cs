/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MainGameLeaveAloneChecker
	{
		// Fields
		private bool _isRequestLeaveAlone;
		private CommonDialog _leaveAloneDialog;
		private CommonDialog.Param _leaveAloneDialogParam;
		private float _warnningTime;
		private float _exitTime;
		public const float LEAVE_ALONE_WARNNING_TIME = 20f;
		public const float LEAVE_ALONE_EXIT_TIME = 30f;
		public const float LEAVE_ALONE_WARNNING_OFFSET_TIME = 10f;
	
		// Properties
		public bool isRequestLeaveAlone { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public InGameTime gameTime;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _CheckLeaveAlone_b__1(CommonDialog obj);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<CommonDialog> __9__11_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CheckLeaveAlone_b__11_0(CommonDialog obj);
		}
	
		// Constructors
		public MainGameLeaveAloneChecker();
	
		// Methods
		public void SetLeaveAloneTime(QuestDataElement qde);
		public void CheckLeaveAlone();
		private bool IsPauseLeaveAloneTime();
		private void ResetLeaveAloneTime();
	}
}
