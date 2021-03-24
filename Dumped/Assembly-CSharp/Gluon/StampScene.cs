/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampScene : SceneBase
	{
		// Fields
		private Canvas mainCanvas;
		private Canvas popupBaseCanvas;
		private StampPageBase stampPageBase;
		private StampListFrame stampListFrame;
		private int pageselectStampId;
		private int listselectStampId;
		private bool goBackFlg;
		private StampSetData stampSetData;
		private int maxStampData;
		private string tab;
		private Footer.MenuTab menuTab;
		private Button saveButton;
		private readonly string mainCanvasPath;
		private readonly string stampVoice;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__15_0;
			public static Action __9__32_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _UnloadScene_b__15_0();
			internal void _OnError_b__32_0();
		}
	
		[CompilerGenerated]
		private sealed class _UnloadScene_d__15 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StampScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadScene_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public StampScene __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _ShowConfirmDialog_b__0();
			internal void _ShowConfirmDialog_b__1();
			internal void _ShowConfirmDialog_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public StampInfoPopup popup;
			public StampScene __4__this;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _ShowInfoDialog_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public StampScene __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _SendDataOnSuccess_b__0();
			internal void _SendDataOnSuccess_b__1();
			internal void _SendDataOnSuccess_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public StampListController listController;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal bool _waitEdgeToEdgeComplete_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _waitEdgeToEdgeComplete_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StampScene __4__this;
			private __c__DisplayClass31_0 __8__1;
			public StampList[] allStampList;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _waitEdgeToEdgeComplete_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public string tabName;
			public Footer.MenuTab tabType;
	
			// Constructors
			public __c__DisplayClass33_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass33_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass33_1();
	
			// Methods
			internal void _OnFooterPressed_b__0();
			internal void _OnFooterPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public UnityAction action;
	
			// Constructors
			public __c__DisplayClass34_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass34_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass34_1();
	
			// Methods
			internal void _OnHeaderPressed_b__0();
			internal void _OnHeaderPressed_b__1();
		}
	
		// Constructors
		public StampScene();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private IEnumerator UnloadScene();
		private void StampPageChange();
		private void SaveButtonPressed();
		private void ShowConfirmDialog();
		private void ShowInfoDialog(int selectStampId);
		private void SaveStampData();
		private void StampListButtonPressed(int selectStampId);
		private void StampPageButtonPressed(int selectStampId);
		private bool CheckChangeStampSet();
		private void SendStampData();
		private void SendDataOnSuccess(StampSetEquipStampResponse res);
		private void GetStampData();
		private void GetDataOnSuccess(StampGetStampResponse res);
		public void RequestUpdateResetNewFlag(StampList[] stampList);
		private void UpdateResetNewRequestOnSuccess(UpdateResetNewResponse res);
		private void EdgeToEdgeComplete();
		[IteratorStateMachine]
		private IEnumerator waitEdgeToEdgeComplete(StampList[] allStampList);
		public void OnError(ErrorType errorType, int resultCode);
		private void OnFooterPressed(string tabName, Footer.MenuTab tabType);
		private void OnHeaderPressed(UnityAction action);
		private void SaveButtonEnable(bool isEnable);
		public override void StartExitAnimation();
		public override void OnBeforeLeaving();
		public void OnDisable();
	}
}
