/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRMatchingAutoJoiningPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/EventQuest/BattleRoyal/BRMatchingAutoJoiningPopup";
		private int questId;
		private int skinId;
		private int weaponSkinId;
		private bool silent;
		[SerializeField]
		private UnityEngine.UI.Text countdownText;
		[SerializeField]
		private GameObject debugGO;
		[SerializeField]
		private CanvasGroup silentCanvasGroup;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public Action onClose;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _ErrorTypeCheck_b__0(MultiPlayError.ErrorType err);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public bool isClearPartySaved;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _LoadSceneLoadingCheck_b__0();
			internal bool _LoadSceneLoadingCheck_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__16_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _LoadSceneLoadingCheck_b__16_2();
		}
	
		[CompilerGenerated]
		private sealed class _LoadSceneLoadingCheck_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			private __c__DisplayClass16_0 __8__1;
			public BRMatchingAutoJoiningPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSceneLoadingCheck_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BRMatchingAutoJoiningPopup();
	
		// Methods
		public static BRMatchingAutoJoiningPopup Create(int questId, int skinId, int weaponSkinId, bool silent = false);
		public void OnCancelButtonPressed();
		protected override void Start();
		private void MatchingServiceStateChangedEventListener(MatchingService.StateType state);
		private void ErrorTypeCheck(MultiPlayError error, Action onClose = null);
		private void Update();
		protected override void OnDestroy();
		private void StartQuest();
		[IteratorStateMachine]
		private IEnumerator LoadSceneLoadingCheck();
	}
}
