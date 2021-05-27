/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RandomMatchingAutoJoiningPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private GameObject debugGO;
		private const string prefabPath = "Prefabs/OutGame/EventQuest/RamdomMathing/RandomMatchingAutoJoiningPopup";
		private int questId;
		private int eventId;
		public static bool isRandomMatchingAutoJoining;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public Action onClose;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _ErrorTypeCheck_b__0(MultiPlayError.ErrorType err);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public bool isClearPartySaved;
	
			// Constructors
			public __c__DisplayClass13_0();
	
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
			public static Action __9__13_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _LoadSceneLoadingCheck_b__13_2();
		}
	
		[CompilerGenerated]
		private sealed class _LoadSceneLoadingCheck_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			private __c__DisplayClass13_0 __8__1;
			public RandomMatchingAutoJoiningPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSceneLoadingCheck_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public RandomMatchingAutoJoiningPopup();
		static RandomMatchingAutoJoiningPopup();
	
		// Methods
		public static RandomMatchingAutoJoiningPopup Create(int questId, int eventId);
		protected override void Start();
		private void Update();
		private void MatchingServiceStateChangedEventListener(MatchingService.StateType state);
		private void ErrorTypeCheck(MultiPlayError error, Action onClose = null);
		public void OnCancelButtonPressed();
		protected override void OnDestroy();
		private void StartQuest();
		[IteratorStateMachine]
		private IEnumerator LoadSceneLoadingCheck();
	}
}
