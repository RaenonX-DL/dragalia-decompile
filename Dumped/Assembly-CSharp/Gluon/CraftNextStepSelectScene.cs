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
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftNextStepSelectScene : CraftEffectSceneBase
	{
		// Fields
		public static ulong baseWeaponKeyId;
		public static int baseWeaponMasterId;
		public static bool isShowNextStepPage;
		public static int selectNodeId;
		[SerializeField]
		private Transform overlayParent;
		private CraftCreateResponse craftResponse;
		private CraftNextStepSelectMainCanvas mainCanvas;
		private int craftTargetId;
		private int[] materialIds;
		private bool isGoToPowerup;
		private bool isNeedUpdateList;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__12_0;
			public static UnityAction __9__21_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__12_0();
			internal void _BackButtonPressed_b__21_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftNextStepSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadNextStepCoroutine_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftNextStepSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadNextStepCoroutine_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ReloadLoadListCoroutine_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftNextStepSelectScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ReloadLoadListCoroutine_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public string tabName;
			public Footer.MenuTab tabType;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _FooterButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public UnityAction nextSceneCallback;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _ChangeSceneCallback_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public CraftNextStepSelectScene __4__this;
			public int weaponId;
			public bool isUseBackup;
			public bool isChild;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _CheckNewFlag_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public CraftStepupConfirmPopup confirmDialog;
			public CraftNextStepSelectScene __4__this;
			public int prevWeaponId;
			public int weaponId;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _ShowStepupCraftPopup_b__0();
			internal void _ShowStepupCraftPopup_b__1();
			internal void _ShowStepupCraftPopup_b__2();
			internal void _ShowStepupCraftPopup_b__3(CraftStepupConfirmPopupBackupData backupData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public CraftNextStepSelectScene __4__this;
			public CraftStepupSendData sendData;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _SendCraftData_b__0(CraftCreateResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_1
		{
			// Fields
			public bool isFirstLoaded;
			public __c__DisplayClass27_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass27_1();
	
			// Methods
			internal void _SendCraftData_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public CraftGradeupSceneData initData;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _GoCraftGradeUpScene_b__0();
		}
	
		// Constructors
		public CraftNextStepSelectScene();
		static CraftNextStepSelectScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		public override void OnPresentReceived();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		[IteratorStateMachine]
		private IEnumerator LoadNextStepCoroutine();
		[IteratorStateMachine]
		private IEnumerator ReloadLoadListCoroutine();
		private void LoadNextStepList();
		private void LoadTreeDiagram();
		private void OnEnterScene();
		public void BackButtonPressed();
		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType);
		private void ChangeSceneCallback(UnityAction nextSceneCallback);
		private void OnCraftCellButtonPressed(CraftTargetSelectCellData cellData, bool isUseBackup = false);
		private void CheckNewFlag(int weaponId, bool isChild = false, bool isUseBackup = false);
		private void ShowStepupCraftPopup(int weaponId, bool isUseBackup = false);
		private void SendCraftData(CraftStepupSendData sendData);
		private void GoCraftGradeUpScene(int weaponId, bool isChild);
		private void OnDestroy();
		protected override void SetupCraftEffectData();
		private void AfterResultAction();
		protected override void CloseCraftEffect();
		protected override bool PlayNextEffect(bool isBackKey = false);
		[CompilerGenerated]
		private void _OnInitReady_b__15_0();
		[CompilerGenerated]
		private void _AfterResultAction_b__31_0();
		[CompilerGenerated]
		private void _AfterResultAction_b__31_1();
	}
}
