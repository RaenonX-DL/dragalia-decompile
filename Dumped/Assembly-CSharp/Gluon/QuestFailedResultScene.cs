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
	public class QuestFailedResultScene : SceneBase
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject httpGreenLight;
		[Header]
		[SerializeField]
		private Transform topNode;
		[SerializeField]
		private Image questBg;
		[SerializeField]
		private Image uiBackGround;
		public Canvas sceneCanvas;
		[SerializeField]
		public Camera mainCamera;
		private QuestFailedResultTopPage topPage;
		private EventKindType eventKindType;
	
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
			public QuestFailedResultScene __4__this;
	
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
		private sealed class _OnEnterSceneCoroutine_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestFailedResultScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnEnterSceneCoroutine_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestFailedResultScene();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		private void OnInitReadyRequestHttp();
		private void OnEnterScene();
		[IteratorStateMachine]
		private IEnumerator OnEnterSceneCoroutine();
		public void LoadTopView();
		public void LoadNextScene(string nextSceneName);
		private void OnDestroy();
		public override void OnBeforeLeaving();
	}
}
