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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortMenuScene : SceneBase
	{
		// Fields
		public Camera mainCamera;
		public FortMenuCharaTalkSelector charaTalkSelector;
		public static string prefabDir;
		private FortMenuUICanvas mainCanvas;
		private FortMenuCharaCanvas charaCanvas;
		private bool isRequestFortInfoCompleted;
		private bool isRequestDragonContactInfoCompleted;
		private bool isTutorialRequired;
		private string charaVoiceGroupName;
		private GameObject charaCanvasPrefab;
		private TutorialType tutorialType;
	
		// Nested types
		private enum TutorialType
		{
			None = 0,
			Fort = 1,
			Craft = 2,
			CastleStory = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__14_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__14_1();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortMenuScene __4__this;
			private OutGameTopCharaTalkSelector.TalkData _talkData_5__2;
			private int _i_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_CastleStory_Coroutine_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortMenuScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_CastleStory_Coroutine_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public FortMenuScene __4__this;
			public UnityAction successCallback;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _RequestFortInfo_b__0();
			internal void _RequestFortInfo_b__1(FortGetDataResponse response);
			internal void _RequestFortInfo_b__2(ErrorType errorType, int flag);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public FortMenuScene __4__this;
			public UnityAction successCallback;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _RequestDragonContactInfo_b__0();
			internal void _RequestDragonContactInfo_b__1(DragonGetContactDataResponse response);
			internal void _RequestDragonContactInfo_b__2(ErrorType errorType, int flag);
		}
	
		// Constructors
		public FortMenuScene();
		static FortMenuScene();
	
		// Methods
		private void Awake();
		private void Start();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		public override void OnPresentReceived();
		public void OnCharaPressed();
		private void SetupTutorialState();
		private void StartTutorial();
		private void Tutorial_ToFort();
		private void Tutorial_CastleStory();
		[IteratorStateMachine]
		private IEnumerator Tutorial_CastleStory_Coroutine();
		private void CheckBadges();
		public void RequestFortInfo();
		public void RequestDragonContactInfo();
		[CompilerGenerated]
		private void _Start_b__13_0(UnityEngine.Object obj);
		[CompilerGenerated]
		private void _Start_b__13_1();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__14_0();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__14_2();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__14_3();
		[CompilerGenerated]
		private void _Tutorial_ToFort_b__19_0();
		[CompilerGenerated]
		private void _Tutorial_CastleStory_b__20_0();
		[CompilerGenerated]
		private void _Tutorial_CastleStory_Coroutine_b__21_0();
		[CompilerGenerated]
		private void _Tutorial_CastleStory_Coroutine_b__21_1();
	}
}
