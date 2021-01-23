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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildScene : SceneBase
	{
		// Fields
		[Header]
		[SerializeField]
		private Transform mainPageNode;
		[Header]
		[SerializeField]
		private GameObject httpGreenLight;
		public Camera mainUICamera;
		[HideInInspector]
		public Canvas canvas;
		[CompilerGenerated]
		private GuildTopPage _topPage_k__BackingField;
		private TouchGuardObject awakeTouchGuard;
	
		// Properties
		public GuildTopPage topPage { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__10_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__10_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__10 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GuildScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _OnInitReady_d__12 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildScene __4__this;
			private TaskAwaiter<GuildIndexResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GuildScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		private async void OnInitReady();
		private void LoadTopPage();
		private void OnEnterScene();
		public override void OnPresentReceived();
		public override void OnItemUsed();
	}
}
