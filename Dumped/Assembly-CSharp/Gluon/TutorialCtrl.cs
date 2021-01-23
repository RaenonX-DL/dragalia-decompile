/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialCtrl : MonoBehaviour
	{
		// Fields
		private const float SystemMsgTutorialUIAdjustPosY = 100f;
		private const float SystemMsgDisplayTimeLength = 6f;
		private const int WALK_FRAME = 45;
		private const int BUTTON_PRIORITY_OFFSET = 10;
		private const float MOVE_TUTORIAL_FINISH_POS_Z = 12f;
		private SysMessageUI sysMessage;
		private FingerUI finger;
		private Color backgroundColor;
		private int startCurrentArea;
		private const int fontSize = 24;
		private bool isPopEnemy;
		private string dialogTitle;
		private bool isOpenDualWindow;
		private Canvas dualWindowCanvas;
		private InGameUICtrl inGameUICtrl;
		private Coroutine tutorialJudgeCoroutine;
		private bool isChangeSysMessagePos;
		private const int TUTORIAL_FLT_HEAD = 30;
		private const int TUTORIAL_FLT_LAST = 37;
		private const int TUTORIAL_FLT_MAX = 8;
		private const int TUTORIAL_FLASH_REACT_MAX = 3;
		private float[] anime_react_frame;
		private const float SKILL_DRAGON_FINGER_SHOWFRAME = 35f;
		private const float FLASH_ANIM_CREATED_RATE = 30f;
	
		// Nested types
		private enum DialogState
		{
			Select = 0,
			Ok = 1,
			Cancel = 2
		}
	
		[CompilerGenerated]
		private sealed class _TutorialArea1_d__28 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialCtrl __4__this;
			private MainGameCtrl _mainGameCtrl_5__2;
			private CharacterManager _charaManager_5__3;
			private NotifyCharacter.OpenPlaceNameParam _param_5__4;
			private PlayerCharacter _playerChara_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialArea1_d__28(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialArea2_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialCtrl __4__this;
			private MainGameCtrl _mainGameCtrl_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialArea2_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public MainGameCtrl mainGameCtrl;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal bool _TutorialArea3_b__0();
			internal bool _TutorialArea3_b__1();
			internal bool _TutorialArea3_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _TutorialArea3_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialCtrl __4__this;
			private __c__DisplayClass30_0 __8__1;
			private Vector2 _uiPos_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TutorialArea3_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayScript_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string scriptName;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayScript_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitStartTutorial_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitStartTutorial_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitSysMessage_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitSysMessage_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitDualWindow_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitDualWindow_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _MoveAttackTutorialCoroutine_d__40 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialCtrl __4__this;
			private MainGameCtrl _mainGameCtrl_5__2;
			private int _walkFrameCount_5__3;
			private int _reactNum_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MoveAttackTutorialCoroutine_d__40(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _AvoidTutorialCoroutine_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialCtrl __4__this;
			private MainGameCtrl _mainGameCtrl_5__2;
			private PlayerCtrl _playerchara_5__3;
			private int _reactNum_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AvoidTutorialCoroutine_d__41(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TutorialCtrl();
	
		// Methods
		private void Start();
		private void OnDestroy();
		private void EventPopEnemy();
		[IteratorStateMachine]
		private IEnumerator TutorialArea1();
		[IteratorStateMachine]
		private IEnumerator TutorialArea2();
		[IteratorStateMachine]
		private IEnumerator TutorialArea3();
		[IteratorStateMachine]
		private IEnumerator PlayScript(string scriptName);
		[IteratorStateMachine]
		private IEnumerator WaitStartTutorial();
		[IteratorStateMachine]
		private IEnumerator WaitSysMessage();
		private void PauseInGame(bool pause);
		private void OpenDualWindow(int[] key);
		private void OnCompleteDualWindow();
		[IteratorStateMachine]
		private IEnumerator WaitDualWindow();
		private string GetGuideWindowText(int key);
		public bool IsOpenWindow();
		[IteratorStateMachine]
		private IEnumerator MoveAttackTutorialCoroutine();
		[IteratorStateMachine]
		private IEnumerator AvoidTutorialCoroutine();
		private void AddSkillButtonOrderInLayer(int add);
		private void SetSkillButtonEnableTap(bool enable);
		private void AddDragonButtonOrderInLayer(int add);
		private void ChangeSystemMessagePos();
		private void CloseSystemMessage();
	}
}
