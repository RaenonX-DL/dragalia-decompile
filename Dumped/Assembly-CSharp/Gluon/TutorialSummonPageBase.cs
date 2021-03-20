/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialSummonPageBase : PageBase
	{
		// Fields
		public static readonly float NEXT_SUMMON_DELAY_START_TIME;
		public static readonly float NEXT_SUMMON_DELAY_END_TIME;
		public static readonly float NEXT_SUMMON_DELAY_ALLUNIT_POPUP_TIME;
	
		// Properties
		public TutorialSummonScene tutorialSummonScene { get; }
	
		// Nested types
		[CompilerGenerated]
		private struct _RequestRedoableSummonGetData_d__6 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public Action onComplete;
			private TaskAwaiter<RedoableSummonGetDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestRedoableSummonPreExec_d__7 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public Action onComplete;
			private TaskAwaiter<RedoableSummonPreExecResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestRedoableSummonFixExec_d__8 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public Action onComplete;
			private TaskAwaiter<RedoableSummonFixExecResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public TutorialSummonPageBase();
		static TutorialSummonPageBase();
	
		// Methods
		public void RequestTutorialStep(Action onComplete);
		public async void RequestRedoableSummonGetData(Action onComplete);
		public async void RequestRedoableSummonPreExec(Action onComplete);
		public async void RequestRedoableSummonFixExec(Action onComplete);
		public void UnloadSummonBgScene();
	}
}
