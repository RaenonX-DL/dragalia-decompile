/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DismantleWeaponScene : SceneBase
	{
		// Fields
		private DismantleWeaponCanvas mainCanvas;
		private ulong dismantleTargetId;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__3_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__3_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__3 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DismantleWeaponScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__3(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public DismantleWeaponScene __4__this;
			public DismantleWeaponListCellData equipData;
	
			// Constructors
			public __c__DisplayClass11_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_1
		{
			// Fields
			public DismantleWeaponConfirmPopup confirmDialog;
			public __c__DisplayClass11_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass11_1();
	
			// Methods
			internal void _IconButtonPressed_b__0();
			internal void _IconButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public DismantleWeaponScene __4__this;
			public CommonIconListCellData data;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _IconButtonLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public CraftDisassembleResponse res;
			public DismantleWeaponScene __4__this;
			public CommonPopup pop;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _ShowResultPop_b__0();
		}
	
		// Constructors
		public DismantleWeaponScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void OnEnterScene();
		public void BackButtonPressed();
		private void LoadCraftWeapon();
		private ulong[] CreateDataIdList();
		public void OnSortButtonClicked();
		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void SendDismantleWeaponData(ulong keyId);
		private void ShowResultPop(CraftDisassembleResponse res);
		public override void OnPresentReceived();
		[CompilerGenerated]
		private void _SendDismantleWeaponData_b__13_0(CraftDisassembleResponse res);
	}
}
