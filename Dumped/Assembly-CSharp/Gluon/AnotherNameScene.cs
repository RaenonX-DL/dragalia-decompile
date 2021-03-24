/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnotherNameScene : SceneBase
	{
		// Fields
		public GameObject httpGreenLight;
		private Canvas mainCanvas;
		private AnotherNameCellData nowSelectData;
		private NowSetName nowSetName;
		private NameListBase nameListBase;
		private EmblemList[] allNameList;
		private AnotherNameListController anotherNameListController;
		private readonly string mainCanvasPath;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__8_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AnotherNameScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public NameInfoPopup popup;
			public AnotherNameScene __4__this;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _NameButtonPressed_b__0();
			internal void _NameButtonPressed_b__1();
			internal void _NameButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _ShowCompleteDialog_b__0();
			internal void _ShowCompleteDialog_b__1();
			internal void _ShowCompleteDialog_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public SortAnotherNamePopup popup;
			public AnotherNameScene __4__this;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _ShowSortDialog_b__0();
			internal void _ShowSortDialog_b__1();
		}
	
		// Constructors
		public AnotherNameScene();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnDestroy();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void OnEnterScene();
		public override void OnPresentReceived();
		public void BackButtonPressed();
		public void NameButtonPressed(AnotherNameCellData selectData);
		private void SendAnotherNameData();
		private void SetDataOnSuccess(EmblemSetResponse res);
		private void GetAnotherNameData();
		private void GetDataOnSuccess(EmblemGetListResponse res);
		public void RequestUpdateResetNewFlag(EmblemList[] emblemList);
		private void ShowCompleteDialog();
		private void ShowSortDialog();
		private void SetSortInfo(AnotherNameSortData sortData);
		[CompilerGenerated]
		private void _RequestUpdateResetNewFlag_b__20_0(UpdateResetNewResponse res);
	}
}
